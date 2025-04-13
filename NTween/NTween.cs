using System;
using MyTween;

namespace NTween {

    public static class NTween {

        public static TweenHandle Create(float from, float to, float duration) {
            var param = new TweenParam() {
                Duration = duration,
            };

            var tween = new Tween(param);
            var handle = TweenManager.Register(tween);

            return handle;
        }
    }

}