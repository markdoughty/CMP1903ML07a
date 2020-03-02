using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    class LogWrite
    {
        private ILogWriter _LogWriter;

        public LogWrite(ILogWriter logWriter)
        {
            _LogWriter = logWriter;
        }

        public void Write(string entry)
        {
            _LogWriter.writeLogEntry(entry);
        }
    }
}
