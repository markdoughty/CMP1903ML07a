using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903ML07a
{
    class Writer
    {
        public virtual void setWriterName(string name)
        {
            Console.WriteLine($"Base Class Setting Name: {name}");
        }
    }
}
