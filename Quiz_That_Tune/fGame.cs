using System;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fGame : Form
    {
        private Random random = new Random();

        public fGame()
        {
            InitializeComponent();
        }

        void MakeSong() // загадываем песню
        {
            int songNumber = random.Next(0, Quiz.TrackList.Count);
            WMP.URL = Quiz.TrackList[songNumber];
            // WMP.Ctlcontrols.play();

            Quiz.TrackList.RemoveAt(songNumber); // убираем песню, кот. уже была

            lblSongsCounter.Text = Quiz.TrackList.Count.ToString(); // показать, сколько осталось песен в списке
        }

        private void btbNext_Click(object sender, EventArgs e)
        {
            timer.Start();
            MakeSong();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.stop(); // останавливать проигрывание музыки при закрытие формы
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblSongsCounter.Text = Quiz.TrackList.Count.ToString(); // показать, сколько осталось песен
                                                                    // есть в списке при загрузке формы
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = Quiz.GameDuration;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;

            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
            }
        }

        private void btbPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer.Start();
            WMP.Ctlcontrols.play();
        }
    }
}
