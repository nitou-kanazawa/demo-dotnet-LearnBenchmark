using System;
using System.Collections.Generic;

namespace MyTween {

    internal static class TweenManager {

        private static readonly Dictionary<int, ITween> _tweens = new();


        public static TweenHandle Register(ITween tween) {
            if (_tweens.ContainsValue(tween))
                throw new InvalidOperationException("Tween is already registered.");

            var id = CreateId();
            _tweens.Add(id, tween);

            return new TweenHandle(id);
        }

        public static void Unregister(TweenHandle handle) {
            if (handle.IsEmpty())
                throw new InvalidOperationException();
            if (!_tweens.ContainsKey(handle.Id))
                throw new InvalidOperationException();

            _tweens.Remove(handle.Id);
        }

        internal static void Update(float deltaTime) {
            foreach (var tween in _tweens) {
                tween.Value.Update(deltaTime);
            }
        }

        private static int CreateId() {
            int nextId = 0;
            while (_tweens.ContainsKey(nextId)) {
                nextId++;
            }
            return nextId;
        }
    }

}