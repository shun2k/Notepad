namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新規作成ボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotepadTextBox.Text = "";
        }

        /// <summary>
        /// 読み込みボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 保存ボタンの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter( "text.txt", false );
            sw.Write( NotepadTextBox.Text );
            sw.Close();
        }

        /// <summary>
        /// ファイルの保存、OKボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        /// <summary>
        /// ファイルを開く、OKボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
