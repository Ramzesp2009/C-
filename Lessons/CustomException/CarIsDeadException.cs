using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string cause, DateTime time) : this(cause, time, string.Empty) { }
        public CarIsDeadException(string cause, DateTime time, string message) : this(cause, time, message, null) { }
        public CarIsDeadException(string cause, DateTime time, string message, SystemException inner) : base(message, inner)
        {
            //_messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
        //public override string Message => $"Car Error Message: {_messageDetails}";
    }
}
