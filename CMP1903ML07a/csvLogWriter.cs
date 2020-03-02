using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    class csvLogWriter
    {
        private csvWriter _csvWriter;

        public csvLogWriter(csvWriter csvW)
        {
            _csvWriter = csvW;
        }

        public void Write(string m)
        {
            _csvWriter.writeLogEntry(m);
        }
    }
}
