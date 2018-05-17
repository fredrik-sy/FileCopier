using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopier
{
    public partial class Form1 : Form
    {
        private BoundedBuffer buffer;
        private Reader reader;
        private Thread readerThread;

        public Form1()
        {
            InitializeComponent();
            InitializeBoundedBuffer();
            InitializeReader();
        }

        public void InitializeBoundedBuffer()
        {
            buffer = new BoundedBuffer(0, null, false, null, null);
        }

        public void InitializeReader()
        {
            reader = new Reader(buffer, 0)
        }
    }
}
