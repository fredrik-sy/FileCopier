using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileCopier
{
    class Reader
    {
        private BoundedBuffer buffer;
        private Thread thread;

        public Reader(BoundedBuffer buffer)
        {
            this.buffer = buffer;
            Text = new List<string>();
        }

        /// <summary>
        /// Gets the text that has been read from the buffer.
        /// </summary>
        public List<string> Text { get; private set; }

        /// <summary>
        /// Gets a value indicating if the <see cref="Reader"/> is reading the text in the buffer.
        /// </summary>
        public bool IsWorking
        {
            get { return thread?.IsAlive == true; }
        }

        /// <summary>
        /// Starts a thread to read the text from the buffer.
        /// </summary>
        public void ReadText(int numberOfString)
        {
            Text.Clear();
            thread = new Thread(new ThreadStart(() => ReadFromBuffer(numberOfString)));
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// Reads the text from the buffer.
        /// </summary>
        private void ReadFromBuffer(int numberOfString)
        {
            for (int i = 0; i < numberOfString; ++i)
            {
                Text.Add(buffer.ReadData());
            }

            buffer.Clear();
        }
    }
}
