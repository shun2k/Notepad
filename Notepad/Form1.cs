namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool SaveCanfirmation()
        {
            if (NotepadTextBox.Modified == true)
            {
                DialogResult result = MessageBox.Show("���e���ύX����Ă��܂��B�ۑ����܂����H", "�t�@�C���̕ۑ��m�F", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    // �t�@�C���ɕۑ�
                    result = NotepadSaveFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        return true;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// �V�K�쐬�{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = SaveCanfirmation();
            if (result == true)
            {
                NotepadTextBox.Text = "";
                Text = "���� - Notepad";
                NotepadTextBox.Modified = false;
            }
        }

        /// <summary>
        /// �ǂݍ��݃{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = SaveCanfirmation();
            if (result == true)
            {
                NotepadOpenFileDialog.ShowDialog();
            }
        }

        /// <summary>
        /// �ۑ��{�^���̑I��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadSaveFileDialog.ShowDialog();

        }

        /// <summary>
        /// �t�@�C���̕ۑ��AOK�{�^������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(NotepadSaveFileDialog.FileName, false);
            sw.Write(NotepadTextBox.Text);
            sw.Close();

            string name = Path.GetFileName(NotepadSaveFileDialog.FileName);
            Text = name + " - Notepad";

            NotepadTextBox.Modified = false;
        }

        /// <summary>
        /// �t�@�C�����J���AOK�{�^������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(NotepadOpenFileDialog.FileName, false);
            NotepadTextBox.Text = sr.ReadToEnd();
            sr.Close();

            string name = Path.GetFileName(NotepadOpenFileDialog.FileName);
            Text = name + " - Notepad";

            NotepadTextBox.Modified = false;
        }

        private void NotepadTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            if ( NotepadTextBox.Modified == true )
            {
                Text = "*" + Text;
            }

        }
    }
}
