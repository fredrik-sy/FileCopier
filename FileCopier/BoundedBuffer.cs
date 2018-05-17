using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopier
{
    class BoundedBuffer
    {
        private string[] strArr;
        private BufferStatus status;

        private int max;
        private int writePos;
        private int readPos;
        private int findPos;
        private RichTextBox rtxBox;
        private string findString;
        private string replaceString;
        private int start;
        private int nbrReplacement;
        private bool notify;
        private object lockObject;

        public BoundedBuffer(int elements, RichTextBox rtxBox, bool notify, string find, string replace)
        {
            this.rtxBox = rtxBox;
        }

        private delegate void Marker();
        private delegate void Selector();

        public int GetNrReplace { get; }

        private void Mark()
        {
        }

        public void Modify()
        {
        }

        public string ReadData()
        {
            return null;
        }

        private string ReplaceAt(string strSource, string strReplace, int pos, int size)
        {
            return null;
        }

        private void Select()
        {
        }

        public void WriteData(string s)
        {
        }
    }
}
