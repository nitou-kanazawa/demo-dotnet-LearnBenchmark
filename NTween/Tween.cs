using System;
using System.Collections.Generic;

namespace MyTween {

    public interface ITween {
        TweenParam Params { get; }
        void Update(float deltaTime);
    }

    internal sealed class Tween : ITween {

        public TweenParam Params { get; init; }

        public float time;

        public Tween(TweenParam param) {
            Params = param;
        }

        public void Update(float deltaTime) {

        }
    }

}