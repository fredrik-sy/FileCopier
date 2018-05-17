using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopier
{
    class Reader
    {
        private BoundedBuffer buffer;
        private int count;
        private List<string> stringList;

        public Reader(BoundedBuffer buffer, int nrOfStrings)
        {
            this.buffer = buffer;
        }

        public List<string> GetText
        {
            get { return stringList; }
        }

        public void ReadLoop()
        {
        }
    }
}
