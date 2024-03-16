namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NotepadTextBox = new TextBox();
            NotepadMenuStrip = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            ReadToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            NotepadSaveFileDialog = new SaveFileDialog();
            NotepadOpenFileDialog = new OpenFileDialog();
            NotepadMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // NotepadTextBox
            // 
            NotepadTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotepadTextBox.Location = new Point(0, 27);
            NotepadTextBox.Multiline = true;
            NotepadTextBox.Name = "NotepadTextBox";
            NotepadTextBox.ScrollBars = ScrollBars.Both;
            NotepadTextBox.Size = new Size(800, 424);
            NotepadTextBox.TabIndex = 0;
            NotepadTextBox.WordWrap = false;
            NotepadTextBox.ModifiedChanged += NotepadTextBox_ModifiedChanged;
            // 
            // NotepadMenuStrip
            // 
            NotepadMenuStrip.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem });
            NotepadMenuStrip.Location = new Point(0, 0);
            NotepadMenuStrip.Name = "NotepadMenuStrip";
            NotepadMenuStrip.Size = new Size(800, 24);
            NotepadMenuStrip.TabIndex = 1;
            NotepadMenuStrip.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, ReadToolStripMenuItem, SaveToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(53, 20);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(122, 22);
            NewToolStripMenuItem.Text = "新規作成";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // ReadToolStripMenuItem
            // 
            ReadToolStripMenuItem.Name = "ReadToolStripMenuItem";
            ReadToolStripMenuItem.Size = new Size(122, 22);
            ReadToolStripMenuItem.Text = "読み込み";
            ReadToolStripMenuItem.Click += ReadToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(122, 22);
            SaveToolStripMenuItem.Text = "保存";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // NotepadSaveFileDialog
            // 
            NotepadSaveFileDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            NotepadSaveFileDialog.FileOk += NotepadSaveFileDialog_FileOk;
            // 
            // NotepadOpenFileDialog
            // 
            NotepadOpenFileDialog.FileName = "openFileDialog1";
            NotepadOpenFileDialog.Filter = "テキストファイル|*.txt|すべてのファイル|*.*";
            NotepadOpenFileDialog.FileOk += NotepadOpenFileDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotepadTextBox);
            Controls.Add(NotepadMenuStrip);
            MainMenuStrip = NotepadMenuStrip;
            Name = "Form1";
            Text = "無題 - Notepad";
            FormClosing += Form1_FormClosing;
            NotepadMenuStrip.ResumeLayout(false);
            NotepadMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NotepadTextBox;
        private MenuStrip NotepadMenuStrip;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem ReadToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private SaveFileDialog NotepadSaveFileDialog;
        private OpenFileDialog NotepadOpenFileDialog;
    }
}
