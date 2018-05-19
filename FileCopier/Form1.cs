using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Modifier modifier;
        private Reader reader;
        private Writer writer;
        private List<string> text;

        public Form1()
        {
            InitializeComponent();
            InitializeClass();
            InitializeBindings();
        }

        /// <summary>
        /// Creates all required classes.
        /// </summary>
        private void InitializeClass()
        {
            buffer = new BoundedBuffer(10, rtxSource);
            modifier = new Modifier(buffer);
            reader = new Reader(buffer);
            writer = new Writer(buffer);
            text = new List<string>();
        }

        /// <summary>
        /// Creates data bindings between controls and classes.
        /// </summary>
        private void InitializeBindings()
        {
            chkNotify.CheckStateChanged += (object sender, EventArgs e) => { buffer.Notify = chkNotify.Checked; };
        }

        #region ClickEvents
        /// <summary>
        /// Occurs when the btnReplaceAll is clicked.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            // Prevent modification of textbox when modifying the source text.
            txtFind.ReadOnly = true;
            txtReplace.ReadOnly = true;

            Clear_Click(sender, e);

            reader.ReadText(text.Count);
            modifier.ModifyText(txtFind.Text, txtReplace.Text, text.Count);
            writer.WriteText(text);

            while (reader.IsWorking || modifier.IsWorking || writer.IsWorking)
            {
                Application.DoEvents();
            }

            lblNumberOfReplacements.Text = "Number of replacements: " + modifier.IndexesModified.Count;
            
            // Adds the read line from reader to rtxDestination.
            foreach (string line in reader.Text)
            {
                rtxDestination.AppendText(line + '\n');
            }

            // Highlights the modified value in text.
            foreach (int startIndex in modifier.IndexesModified)
            {
                rtxDestination.SelectionStart = startIndex;
                rtxDestination.SelectionLength = txtReplace.Text.Length;
                rtxDestination.SelectionBackColor = Color.Green;
                rtxDestination.SelectionColor = Color.White;
            }
            
            txtFind.ReadOnly = false;
            txtReplace.ReadOnly = false;
            
            CreateDestinationFile();
        }

        /// <summary>
        /// Occurs when the tsmiOpenFile is clicked.
        /// </summary>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = ofdSelectFile.FileName;

                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            rtxSource.AppendText(line + '\n');
                            text.Add(line);
                        }
                    }

                    pnlTools.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not read the text file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Clears all highlights and destination text.
        /// </summary>
        private void Clear_Click(object sender, EventArgs e)
        {
            rtxSource.SelectAll();
            rtxSource.SelectionBackColor = Color.White;
            rtxSource.SelectionColor = Color.Black;
            rtxDestination.Clear();
            lblNumberOfReplacements.Text = "Number of replacements:";
        }
        #endregion

        /// <summary>
        /// Creates a file with the modified text.
        /// </summary>
        private void CreateDestinationFile()
        {
            // Writes the text to file.
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = sfdSaveFile.FileName;

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        foreach (string line in reader.Text)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not save the text file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
