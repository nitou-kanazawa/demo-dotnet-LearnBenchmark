using System;

namespace MyTween {

    public struct TweenHandle : IDisposable {

        private ITween _tween;

        public TweenHandle(ITween tween) {
            _tween = tween;
        }

        public void Dispose() {
            TweenManager.Unregister(_tween);
            _tween = null;
        }

    }
}