using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    //Custom Eception
    class LogMessageException : Exception
    {
        public LogMessageException(string message) : base(message)
        {

        }
    }
}
