using System;
using System.Collections.Generic;

namespace NTween {

	public interface ITween {
		public int Index { get; set; }
		public bool IsRegistered { get; }

		TweenParameters Params { get; }
		void Update(float deltaTime);
	}


	internal abstract class TweenBase {

		public int Index { get; set; }

		/// <summary>
		/// システムへ登録されているかどうか．
		/// </summary>
		public bool IsRegistered => Index != -1;

		public void ResetIndex() => Index = -1;
	}


	internal sealed class Tween : TweenBase, ITween {

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
