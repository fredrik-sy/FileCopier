using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopier
{
    class Writer
    {
        private BoundedBuffer buffer;
        private List<string> textToWrite;

        public Writer(BoundedBuffer buffer, List<string> textIn)
        {
            this.buffer = buffer;
            textToWrite = textIn;
        }

        public void WriteLoop()
        {
            foreach (string s in textToWrite)
            {
                buffer.WriteData(s);
            }
        }
    }
}
