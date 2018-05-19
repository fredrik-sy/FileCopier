using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileCopier
{
    class Modifier
    {
        private BoundedBuffer buffer;
        private Thread thread;

        public Modifier(BoundedBuffer buffer)
        {
            this.buffer = buffer;
            IndexesModified = new List<int>();
        }

        /// <summary>
        /// Gets the indexes where the text has been modified in the buffer.
        /// </summary>
        public List<int> IndexesModified { get; private set; }

        /// <summary>
        /// Gets a value indicating if the <see cref="Modifier"/> is modifying the text in the buffer.
        /// </summary>
        public bool IsWorking
        {
            get { return thread?.IsAlive == true; }
        }

        /// <summary>
        /// Starts a thread to modify the text in the buffer.
        /// </summary>
        public void ModifyText(string oldValue, string newValue, int numberOfString)
        {
            IndexesModified.Clear();
            thread = new Thread(new ThreadStart(() => ModifyInBuffer(oldValue, newValue, numberOfString)));
            thread.IsBackground = true;
            thread.Start();
        }

        /// <summary>
        /// Modifies the text in the buffer.
        /// </summary>
        private void ModifyInBuffer(string oldValue, string newValue, int numberOfString)
        {
            for (int i = 0; i < numberOfString; ++i)
            {
                IndexesModified.AddRange(buffer.ModifyData(oldValue, newValue));
            }
        }
    }
}
