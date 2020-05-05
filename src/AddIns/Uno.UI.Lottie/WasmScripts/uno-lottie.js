var Uno;
(function (Uno) {
    var UI;
    (function (UI) {
        class Lottie {
            static setAnimationProperties(newProperties) {
                const elementId = newProperties.elementId;
                Lottie.withPlayer(p => {
                    let currentAnimation = Lottie._runningAnimations[elementId];
                    if (!currentAnimation || Lottie.needNewPlayerAnimation(currentAnimation.properties, newProperties)) {
                        // Here we need a new player animation
                        // (some property changes required a new animation)
                        currentAnimation = Lottie.createAnimation(newProperties);
                    }
                    Lottie.updateProperties(currentAnimation, newProperties);
                });
                return "ok";
            }
            static stop(elementId) {
                Lottie.withPlayer(p => {
                    const a = Lottie._runningAnimations[elementId].animation;
                    a.stop();
                    Lottie.raiseState(a);
                });
                return "ok";
            }
            static play(elementId, fromProgress, toProgress, looped) {
                Lottie.withPlayer(p => {
                    const a = Lottie._runningAnimations[elementId].animation;
                    a.loop = looped;
                    const fromFrame = fromProgress * Lottie._numberOfFrames;
                    const toFrame = toProgress * Lottie._numberOfFrames;
                    a.playSegments([fromFrame, toFrame], false);
                    Lottie.raiseState(a);
                });
                return "ok";
            }
            static kill(elementId) {
                Lottie.withPlayer(p => {
                    Lottie._runningAnimations[elementId].animation.destroy();
                    delete Lottie._runningAnimations[elementId];
                });
                return "ok";
            }
            static pause(elementId) {
                Lottie.withPlayer(p => {
                    const a = Lottie._runningAnimations[elementId].animation;
                    a.pause();
                    Lottie.raiseState(a);
                });
                return "ok";
            }
            static resume(elementId) {
                Lottie.withPlayer(p => {
                    const a = Lottie._runningAnimations[elementId].animation;
                    a.play();
                    Lottie.raiseState(a);
                });
                return "ok";
            }
            static setProgress(elementId, progress) {
                Lottie.withPlayer(p => {
                    const animation = Lottie._runningAnimations[elementId].animation;
                    const frames = animation.getDuration(true);
                    const frame = frames * progress;
                    animation.goToAndStop(frame, true);
                    Lottie.raiseState(animation);
                });
                return "ok";
            }
            static getAnimationState(elementId) {
                const animation = Lottie._runningAnimations[elementId].animation;
                const state = Lottie.getStateString(animation);
                return state;
            }
            static needNewPlayerAnimation(current, newProperties) {
                if (current.jsonPath !== newProperties.jsonPath) {
                    return true;
                }
                if (newProperties.stretch !== current.stretch) {
                    return true;
                }
                if (newProperties.autoplay !== current.autoplay) {
                    return true;
                }
                if (newProperties.jsonPath !== current.jsonPath) {
                    return true;
                }
                return false;
            }
            static updateProperties(runningAnimation, newProperties) {
                const animation = runningAnimation.animation;
                const runningProperties = runningAnimation.properties;
                if (runningProperties == null || newProperties.rate != runningProperties.rate) {
                    animation.setSpeed(newProperties.rate);
                }
                runningAnimation.properties = newProperties;
            }
            static createAnimation(properties) {
                const existingAnimation = Lottie._runningAnimations[properties.elementId];
                if (existingAnimation) {
                    // destroy any previous animation
                    existingAnimation.animation.destroy();
                    existingAnimation.animation = null;
                }
                const config = Lottie.getPlayerConfig(properties);
                const animation = Lottie._player.loadAnimation(config);
                const runningAnimation = {
                    animation: animation,
                    properties: properties
                };
                Lottie._runningAnimations[properties.elementId] = runningAnimation;
                animation.addEventListener("complete", (e) => {
                    Lottie.raiseState(animation);
                });
                animation.addEventListener("loopComplete", (e) => {
                    Lottie.raiseState(animation);
                });
                animation.addEventListener("segmentStart", (e) => {
                    Lottie.raiseState(animation);
                });
                animation.addEventListener("data_ready", (e) => {
                    Lottie._numberOfFrames = animation.totalFrames;
                    Lottie.raiseState(animation);
                });
                Lottie.raiseState(animation);
                return runningAnimation;
            }
            static getStateString(animation) {
                const duration = animation.getDuration(false);
                const state = `${animation.animationData.w}|${animation.animationData.h}|` +
                    `${animation.isLoaded}|${animation.isPaused}|${duration}`;
                return state;
            }
            static raiseState(animation) {
                const element = animation.wrapper;
                const state = Lottie.getStateString(animation);
                element.dispatchEvent(new CustomEvent("lottie_state", { detail: state }));
            }
            static getPlayerConfig(properties) {
                let scaleMode = "none";
                switch (properties.stretch) {
                    case "Uniform":
                        scaleMode = "xMidYMid meet";
                        break;
                    case "UniformToFill":
                        scaleMode = "xMidYMid slice";
                        break;
                    case "Fill":
                        scaleMode = "noScale";
                        break;
                }
                const containerElement = Uno.UI.WindowManager.current.getView(properties.elementId);
                // https://github.com/airbnb/lottie-web/wiki/loadAnimation-options
                const playerConfig = {
                    path: properties.jsonPath,
                    loop: true,
                    autoplay: properties.autoplay,
                    name: `Lottie-${properties.elementId}`,
                    renderer: "svg",
                    container: containerElement,
                    rendererSettings: {
                        // https://github.com/airbnb/lottie-web/wiki/Renderer-Settings
                        preserveAspectRatio: scaleMode
                    }
                };
                return playerConfig;
            }
            static withPlayer(action) {
                if (Lottie._player) {
                    action(Lottie._player);
                }
                else {
                    require(["lottie"], (p) => {
                        if (!Lottie._player) {
                            Lottie._player = p;
                        }
                        action(p);
                    });
                }
            }
        }
        Lottie._runningAnimations = {};
        UI.Lottie = Lottie;
    })(UI = Uno.UI || (Uno.UI = {}));
})(Uno || (Uno = {}));
