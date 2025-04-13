using System;
using System.Collections.Generic;

namespace MyTween {

    internal static class TweenManager {

        private static List<ITween> _items = new();

        public static TweenHandle Register(ITween tween) {
            if (_items.Contains(tween))
                throw new InvalidOperationException();

            _items.Add(tween);

            return new TweenHandle();
        }

        public static void Unregister(ITween tween) {
            if (!_items.Contains(tween))
                throw new InvalidOperationException();

            _items.Remove(tween);
        }

    }

}