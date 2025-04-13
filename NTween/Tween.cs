using System;
using System.Collections.Generic;

namespace MyTween {

    public interface ITween {
        TweenParams Params { get; }
        void Update(float deltaTime);
    }

    public sealed class Tween {

    }

}