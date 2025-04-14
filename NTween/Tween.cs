using System;
using System.Collections.Generic;

namespace MyTween {

    public interface ITween {
        TweenParameters Params { get; }
        void Update(float deltaTime);
    }


    internal sealed class Tween : ITween {

        public TweenParameters Params { get; init; }

        public float time;


        public Tween(TweenParameters param) {
            Params = param;
        }

        public void Update(float deltaTime) {
            bool isCompleted;
            bool isDelayed;



        }
    }

}