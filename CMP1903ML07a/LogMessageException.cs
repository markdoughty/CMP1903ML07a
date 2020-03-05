using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    //Custom Exception
    class LogMessageException : Exception
    {
        //Constructor
        public LogMessageException(string message) : base(message)
        {

        }
    }
}
