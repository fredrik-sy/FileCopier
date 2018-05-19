using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopier
{
    class BoundedBuffer
    {
        private TextLine[] buffer;
        private RichTextBox rtxSource;
        private int rtxSourcePos;
        private int rtxDestinationPos;
        private object lockObject = new object();

        private int modifyPos;
        private int readPos;
        private int writePos;

        public BoundedBuffer(int size, RichTextBox rtxSource)
        {
            buffer = new TextLine[size];
            this.rtxSource = rtxSource;
        }

        /// <summary>
        /// Gets or sets the value indicating if the user should be notified with a <see cref="MessageBox"/>
        /// when a value in buffer is changing.
        /// </summary>
        public bool Notify { get; set; }

        /// <summary>
        /// Replaces all occurrences of the oldValue with the newValue in a string from buffer.
        /// </summary>
        public IEnumerable<int> ModifyData(string oldValue, string newValue)
        {
            Monitor.Enter(lockObject);

            while (buffer[modifyPos].Status != Status.New)
            {
                Monitor.Wait(lockObject);
            }

            if (!string.IsNullOrEmpty(oldValue))
            {
                string line = buffer[modifyPos].Line;
                List<int> indexes;

                // Find and filter all indexes found in text line.
                if (Notify)
                {
                    indexes = new List<int>();

                    foreach (int index in FindAllIndex(line, oldValue))
                    {
                        SelectSourceText(rtxSourcePos + index, oldValue.Length);                // Sum with rtxSourcePos since index is calculated from a line.
                        HighlightSelectedSourceText(Color.RoyalBlue, Color.White);

                        if (MessageBox.Show("Replace " + oldValue + " with " + newValue,
                                            "Replace",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            indexes.Add(index);
                            HighlightSelectedSourceText(Color.Green, Color.White);
                        }
                        else
                        {
                            HighlightSelectedSourceText(Color.White, Color.Black);              // Reset back to standard color.
                        }
                    }
                }
                else
                {
                    indexes = FindAllIndex(line, oldValue);
                }

                // Keep track of changes made in rtxDestination.
                for (int i = 0; i < indexes.Count; ++i)
                {
                    // Compensate the length difference between newValue and oldValue since the length can change the index.
                    yield return rtxDestinationPos + indexes[i] + (i * (newValue.Length - oldValue.Length));
                }

                indexes.Reverse();                                                              // Modify backwards to skip unnecessary code.

                // Replace the oldValue with newValue at the indexes.
                foreach (int index in indexes)
                {
                    SelectSourceText(rtxSourcePos + index, oldValue.Length);
                    HighlightSelectedSourceText(Color.Green, Color.White);
                    line = ReplaceAt(line, index, oldValue.Length, newValue);
                }

                rtxSourcePos += buffer[modifyPos].Line.Length + 1;                              // Prepare the rtxSourcePos to the next read line.
                buffer[modifyPos].Line = line;
                rtxDestinationPos += buffer[modifyPos].Line.Length + 1;
            }

            buffer[modifyPos].Status = Status.Checked;
            modifyPos = (modifyPos + 1) % buffer.Length;

            Monitor.PulseAll(lockObject);
            Monitor.Exit(lockObject);
        }

        /// <summary>
        /// Reads a string from the buffer.
        /// </summary>
        public string ReadData()
        {
            string data;

            Monitor.Enter(lockObject);

            while (buffer[readPos].Status != Status.Checked)
            {
                Monitor.Wait(lockObject);
            }

            data = buffer[readPos].Line;
            buffer[readPos].Status = Status.Empty;
            readPos = (readPos + 1) % buffer.Length;

            Monitor.PulseAll(lockObject);
            Monitor.Exit(lockObject);

            return data;
        }

        /// <summary>
        /// Writes a string to the buffer.
        /// </summary>
        public void WriteData(string data)
        {
            Monitor.Enter(lockObject);

            while (buffer[writePos].Status != Status.Empty)
            {
                Monitor.Wait(lockObject);
            }

            buffer[writePos].Line = data;
            buffer[writePos].Status = Status.New;
            writePos = (writePos + 1) % buffer.Length;

            Monitor.PulseAll(lockObject);
            Monitor.Exit(lockObject);
        }

        /// <summary>
        /// Clears all data.
        /// </summary>
        public void Clear()
        {
            rtxSourcePos = 0;
            rtxDestinationPos = 0;
        }

        #region HelperMethods
        /// <summary>
        /// Replaces a substring in the text with a replacement text.
        /// </summary>
        private string ReplaceAt(string text, int startIndex, int length, string replacement)
        {
            string s1 = text.Substring(0, startIndex);
            string s2 = text.Substring(startIndex + length, text.Length - (startIndex + length));
            return s1 + replacement + s2;
        }

        /// <summary>
        /// Selects a text in the <see cref="RichTextBox"/>.
        /// </summary>
        private void SelectSourceText(int startIndex, int length)
        {
            rtxSource.Invoke(new MethodInvoker(delegate
            {
                rtxSource.SelectionStart = startIndex;
                rtxSource.SelectionLength = length;
            }));
        }

        /// <summary>
        /// Highlights a text in the <see cref="RichTextBox"/>.
        /// </summary>
        private void HighlightSelectedSourceText(Color selectionBackColor, Color selectionColor)
        {
            rtxSource.Invoke(new MethodInvoker(delegate
            {
                rtxSource.SelectionBackColor = selectionBackColor;
                rtxSource.SelectionColor = selectionColor;
            }));
        }

        /// <summary>
        /// Find all occurrences of the specified search value in the text.
        /// </summary>
        private List<int> FindAllIndex(string text, string searchValue)
        {
            List<int> indexes = new List<int>();
            int startIndex = 0;

            while ((startIndex = text.IndexOf(searchValue, startIndex)) != -1)
            {
                indexes.Add(startIndex);
                startIndex += searchValue.Length;                                              // Update the startIndex to skip the found value.
            }

            return indexes;
        }
        #endregion
    }
}
