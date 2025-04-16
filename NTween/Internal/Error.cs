using System;
using System.Runtime.CompilerServices;

namespace NTween {

	/// <summary>
	///
	/// </summary>
	internal static class Error {






		public static void ArgumentNull(string message) {
			throw new ArgumentNullException(message);
		}


		public static void TweenAlreadyRegistered() {
			throw new InvalidOperationException("Tween is already registered.");
		}

		public static void TweenNotExists() {
			throw new InvalidOperationException("Tween has been destroyed or no longer exists.");
		}

		public static void MotionHasBeenCanceledOrCompleted() {
			throw new InvalidOperationException("Tween has already been canceled or completed.");
		}
	}

}
