namespace FileCopier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNotify = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxSource = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxDestination = new System.Windows.Forms.RichTextBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.lblNumberOfReplacements = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 22);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 19);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(133, 22);
            this.tsmiOpenFile.Text = "Open File...";
            this.tsmiOpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNotify);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReplace);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(230, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // chkNotify
            // 
            this.chkNotify.AutoSize = true;
            this.chkNotify.Location = new System.Drawing.Point(68, 88);
            this.chkNotify.Name = "chkNotify";
            this.chkNotify.Size = new System.Drawing.Size(152, 17);
            this.chkNotify.TabIndex = 6;
            this.chkNotify.Text = "Notify user on every match";
            this.chkNotify.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find:";
            // 
            // txtReplace
            // 
            this.txtReplace.BackColor = System.Drawing.Color.White;
            this.txtReplace.Location = new System.Drawing.Point(68, 59);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(2);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(151, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.White;
            this.txtFind.Location = new System.Drawing.Point(68, 30);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(151, 20);
            this.txtFind.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 163);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 275);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxSource);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(554, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxSource
            // 
            this.rtxSource.BackColor = System.Drawing.Color.White;
            this.rtxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxSource.Location = new System.Drawing.Point(2, 2);
            this.rtxSource.Margin = new System.Windows.Forms.Padding(2);
            this.rtxSource.Name = "rtxSource";
            this.rtxSource.ReadOnly = true;
            this.rtxSource.Size = new System.Drawing.Size(550, 245);
            this.rtxSource.TabIndex = 0;
            this.rtxSource.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxDestination);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(554, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Destination";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxDestination
            // 
            this.rtxDestination.BackColor = System.Drawing.Color.White;
            this.rtxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDestination.Location = new System.Drawing.Point(2, 2);
            this.rtxDestination.Margin = new System.Windows.Forms.Padding(2);
            this.rtxDestination.Name = "rtxDestination";
            this.rtxDestination.ReadOnly = true;
            this.rtxDestination.Size = new System.Drawing.Size(550, 245);
            this.rtxDestination.TabIndex = 0;
            this.rtxDestination.Text = "";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.AutoSize = true;
            this.btnReplaceAll.Location = new System.Drawing.Point(260, 25);
            this.btnReplaceAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(107, 24);
            this.btnReplaceAll.TabIndex = 3;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblNumberOfReplacements
            // 
            this.lblNumberOfReplacements.AutoSize = true;
            this.lblNumberOfReplacements.Location = new System.Drawing.Point(392, 30);
            this.lblNumberOfReplacements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfReplacements.Name = "lblNumberOfReplacements";
            this.lblNumberOfReplacements.Size = new System.Drawing.Size(125, 13);
            this.lblNumberOfReplacements.TabIndex = 5;
            this.lblNumberOfReplacements.Text = "Number of replacements:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(260, 70);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.Filter = "Text Files (*.txt) |*.txt";
            this.ofdSelectFile.Title = "Select Text File";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.CheckPathExists = false;
            this.sfdSaveFile.Filter = "Text Files (*.txt)|*.txt";
            this.sfdSaveFile.Title = "Save Destination File";
            // 
            // pnlTools
            // 
            this.pnlTools.AutoSize = true;
            this.pnlTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTools.Controls.Add(this.lblNumberOfReplacements);
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Controls.Add(this.groupBox1);
            this.pnlTools.Controls.Add(this.btnReplaceAll);
            this.pnlTools.Enabled = false;
            this.pnlTools.Location = new System.Drawing.Point(12, 32);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(519, 120);
            this.pnlTools.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlTools);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Label lblNumberOfReplacements;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxSource;
        private System.Windows.Forms.RichTextBox rtxDestination;
        private System.Windows.Forms.CheckBox chkNotify;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Panel pnlTools;
    }
}

