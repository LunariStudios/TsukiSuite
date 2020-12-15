using System;

namespace Lunari.Tsuki.Runtime.Exceptions {
    /// <inheritdoc     />
    ///  <summary>
    ///  What a Terrible Failure exception.
    ///  Meant to be used for conditions that should never occur, but blocks compilation if not checked, for example:
    ///  <code>
    /// public void GetHorizontalSign(bool leftCollision, bool rightCollision){
    ///     if (leftCollision == rightCollision) {
    ///         return UnitValue.Zero;
    ///     }
    ///     if (leftCollision) {
    ///         return UnitValue.MinusOne;
    ///     }
    ///     if (rightCollision) {
    ///         return UnitValue.One;
    ///     }
    ///     /*
    ///      * We will never get here, because 
    ///      * the program would have returned at the
    ///      * first conditional branch 
    ///      */
    ///     throw new WTFException();
    /// }</code>
    ///  Thanks google.
    ///  </summary>
    public class WTFException : Exception {
        public WTFException(string message = "Something went very wrong here") : base(message) { }
    }
}