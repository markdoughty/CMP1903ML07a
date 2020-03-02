using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    class txtWriter : Writer, ILogWriter
    {
        public void writeLogEntry(string entry)
        {
            Console.WriteLine($"TXT Writing: {entry}");
        }

        public override void setWriterName(string name)
        {
            Console.WriteLine($"txtWriter Class Setting Name: {name}");
        }
    }
}
