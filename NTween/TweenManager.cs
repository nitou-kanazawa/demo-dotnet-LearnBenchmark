using System;
using System.Collections.Generic;


namespace NTween {

    internal static class TweenManager {

        private static readonly TweenStorage _storage = new();

        public static TweenHandle Register(ITween tween) => _storage.Register(tween);

        public static void Unregister(TweenHandle handle) => _storage.Unregister(handle);

        internal static void Update(float deltaTime) {
            foreach (var tween in _storage.Tweens) {
                tween.Update(deltaTime);
            }
        }


        public static bool IsActive(TweenHandle handle) {
            return true;
        }
    }
}