using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    // This class is used for passing the result of an operation between underlying classes
    // and forms. Allows result, message and exception details to be handled and passed
    class OperationResult
    {
        // Default constructor takes no arguments
        public OperationResult()
        {

        }

        // Overloaded constructor takes default is success value - true/false
        public OperationResult(bool isSuccessValue)
        {
            this.IsSuccess = isSuccessValue;
        } 

        #region Properties
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public bool IsException { get; set; }
        public Exception ResultException { get; set; }
        #endregion
    }
}
