using System;
using System.Collections.Generic;

namespace NTween {

	internal sealed class TweenStorage {



		private readonly List<ITween> _tweens = new();

		/// <summary>
		///
		/// </summary>
		public IEnumerable<ITween> Tweens => _tweens;


		/// ----------------------------------------------------------------------------
		// Public Method

		internal TweenStorage() {

		}

		public TweenHandle Register(ITween tween) {
			if (tween.IsRegistered)
				Error.TweenAlreadyRegistered();

			// 対象の登録
			var index = _tweens.Count;
			tween.Index = index;
			_tweens.Add(tween);

			return new TweenHandle(index);
		}

		public void Unregister(TweenHandle handle) {
			int removeIndex = handle.Index;
			if (removeIndex < 0 || removeIndex >= _tweens.Count)
				return;

			var lastIndex = _tweens.Count - 1;

			// 対象の登録解除
			var removedTween = _tweens[removeIndex];
			removedTween.Index = -1;

			// 末尾要素の移動
			if (removeIndex != lastIndex) {
				var lastTween = _tweens[lastIndex];
				_tweens[removeIndex] = lastTween;
				lastTween.Index = removeIndex;
			}
			// リスト更新
			_tweens.RemoveAt(lastIndex);
		}

		public override bool Equals(object? obj) {
			return base.Equals(obj);
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		public override string? ToString() {
			return base.ToString();
		}
	}

}
