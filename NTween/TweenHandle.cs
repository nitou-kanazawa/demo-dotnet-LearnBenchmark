using System;

namespace MyTween {

    public struct TweenHandle {

        public int Id { get; private set; }

        internal TweenHandle(int id) {
            Id = id;
        }

        public bool IsEmpty() => Id < 0;

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


        /// ----------------------------------------------------------------------------
        #region Static
        public static TweenHandle Empty() => new TweenHandle(-1);
        #endregion
    }
}