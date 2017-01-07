using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{
    public class Messages
    {
        #region Neutral/System Messages
        public class ContinueProcessing { }
        #endregion

        #region Success Messages
        public class InputSuccess
        {
            public string Reason { get; private set; }
            public InputSuccess(string reason)
            {
                Reason = reason;
            }
        }
        #endregion

        #region Error Messages
        public class InputError
        {
            public InputError(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }

        /// <summary>
        /// User provided blank input.
        /// </summary>
        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason) { }
        }

        /// <summary>
        /// User provided invalid input (currently, input w/ odd # chars)
        /// </summary>
        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason) { }
        }
        #endregion
    }
}
