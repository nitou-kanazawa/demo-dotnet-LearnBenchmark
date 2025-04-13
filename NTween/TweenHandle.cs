using System;

namespace MyTween {

    public struct TweenHandle {

        public int Id;
        private ITween _tween;

        public TweenHandle(ITween tween) {
            _tween = tween;
        }

        public void Cancel() {
            Relese();
        }

        private void Relese() {
            TweenManager.Unregister(_tween);
            _tween = null;
        }

    }
}