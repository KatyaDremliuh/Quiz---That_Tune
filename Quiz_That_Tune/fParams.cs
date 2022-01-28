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
            Quiz.AllDirectories = cbAllDirectories.Checked;
            Quiz.GameDuration = Convert.ToInt32(cbGameDuration.Text);
            Quiz.MusicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Quiz.RandomStart = cbRandomStart.Checked;

            Quiz.WriteParams(); // записываем эти параметры в реестр

            this.Hide(); // закрывает форму fParams
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetDefaultParams();
            this.Hide(); // закрывает форму fParams
        }

        private void btbSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] musicList =
                    Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.mp3", 
                        cbAllDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                Quiz.LastFolder = folderBrowserDialog.SelectedPath;

                //lbMusicList.Items.Clear();
                //lbMusicList.Items.AddRange(musicList);

                Quiz.TrackList.Clear();
                Quiz.TrackList.AddRange(musicList);
            }
        }

        void SetDefaultParams()
        {
            // скинуть на параметры "по умолчанию", если нажали "отмена" (НЕ РАБОТАЕТ? 5)
            cbAllDirectories.Checked = Quiz.AllDirectories;
            cbGameDuration.Text = Quiz.GameDuration.ToString();
            cbMusicDuration.Text = Quiz.MusicDuration.ToString();
            cbRandomStart.Checked = Quiz.RandomStart;
        }

        private void fParams_Load(object sender, EventArgs e)
        {
            SetDefaultParams();
            lbMusicList.Items.Clear();
            lbMusicList.Items.AddRange(Quiz.TrackList.ToArray());
        }
    }
}
