using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    class csvWriter : Writer, ILogWriter
    {
     
        public void writeLogEntry(string entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException();
            }
            if(entry.Length <= 8 )
            {
                throw new LogMessageException("Log message must be more than 8 characters");
            }
            else
            {
                Console.WriteLine($"CSV Writing: {entry}");
            }
        }

        public override void setWriterName(string name)
        {
            Console.WriteLine($"csvWriter Class Setting Name: {name}");
        }
    }
}
