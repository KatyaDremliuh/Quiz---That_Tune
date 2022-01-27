using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fParams : Form
    {
        public fParams()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide(); // закрывает форму fParams
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide(); // закрывает форму fParams
        }

        private void btbSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList =
                    Directory.GetFiles(fbd.SelectedPath, "*.mp3", 
                        cbAllDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(musicList);

                Quiz.list.Clear();
                Quiz.list.AddRange(musicList);
            }
        }
    }
}
