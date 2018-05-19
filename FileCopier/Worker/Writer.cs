using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileCopier
{
    class Writer
    {
        private BoundedBuffer buffer;
        private Thread thread;

        public Writer(BoundedBuffer buffer)
        {
            this.buffer = buffer;
        }

        /// <summary>
        /// Gets a value indicating if the <see cref="Writer"/> is writing the text in the buffer.
        /// </summary>
        public bool IsWorking
        {
            get { return thread?.IsAlive == true; }
        }

        /// <summary>
        /// Starts a thread to write the text to the buffer.
        /// </summary>
        public void WriteText(List<string> text)
        {
            thread = new Thread(new ThreadStart(() => WriteToBuffer(text)));
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// Writes the text to the buffer.
        /// </summary>
        private void WriteToBuffer(List<string> text)
        {
            for (int i = 0; i < text.Count; ++i)
            {
                buffer.WriteData(text[i]);
            }
        }
    }
}
