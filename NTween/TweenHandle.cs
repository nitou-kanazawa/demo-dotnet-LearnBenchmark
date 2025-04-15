using System;

namespace NTween {

    // TODO キャンセル処理
    public struct TweenHandle : IDisposable {

        public readonly int StorageId { get; }

        /// <summary> TweenのId</summary>
        public readonly int Index { get; }

        internal TweenHandle(int id) {
            Index = id;
        }

        public bool IsValid() => Index >= 0;

        public void Dispose() {
            TweenManager.Unregister(this);
        }


        /// ----------------------------------------------------------------------------
        #region Static
        public static TweenHandle InValid() => new TweenHandle(-1);
        #endregion
    }


    public static class TweenHandleExtensions {

        public static bool IsActive(this TweenHandle handle) {
            return TweenManager.IsActive(handle);
        }

        public static void Cancel(this TweenHandle handle) {
        }
    }
}





/*

        public void Cancel() {
            Release();
        }

        private void Release() {
            TweenManager.Unregister(this);
            Id = -1;
        }

        private void TryComplete() {
            throw new NotImplementedException();
        }

        private void TryCancel() {
            throw new NotImplementedException();
        }

*/