using System;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fGame : Form
    {
        private Random random = new Random();
        private int _musicDuration = Quiz.MusicDuration;

        public fGame()
        {
            InitializeComponent();
        }

        void MakeSong() // загадываем песню
        {
            if (Quiz.TrackList.Count == 0)
            {
                FinishGame();
            }
            else
            {
                _musicDuration = Quiz.MusicDuration;

                int songNumber = random.Next(0, Quiz.TrackList.Count);
                WMP.URL = Quiz.TrackList[songNumber];
                // WMP.Ctlcontrols.play();

                Quiz.TrackList.RemoveAt(songNumber); // убираем песню, кот. уже была

                lblSongsCounter.Text = Quiz.TrackList.Count.ToString(); // показать, сколько осталось песен в списке
            }
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

            lblMusicDuration.Text = _musicDuration.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            _musicDuration--;
            lblMusicDuration.Text = _musicDuration.ToString();

            if (progressBar.Value == progressBar.Maximum)
            {
                FinishGame();
                return;
            }

            if (_musicDuration == 0) // если песня закончилась, включить следующую
            {
                MakeSong();
            }
        }

        private void FinishGame() // закончить игру
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void btbPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        // поставить игру на паузу
        private void GamePause()
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        // продолжить игру
        private void GamePlay()
        {
            timer.Start();
            WMP.Ctlcontrols.pause();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            // P.S. игрок 1 жмёт кнопку Q. Игрок 2 - P

            if (keyEventArgs.KeyData == Keys.Q)
            {
                PlayerWantsToGiveHisAnswer("Игрок № 1", lblScorePlayer1);
            }

            if (keyEventArgs.KeyData == Keys.P)
            {
                PlayerWantsToGiveHisAnswer("Игрок № 2", lblScorePlayer2);
            }
        }

        private void PlayerWantsToGiveHisAnswer(string player, Label labelPlayerScore)
        {
            GamePause();

            if (MessageBox.Show(@"Правильный ответ?", player, MessageBoxButtons.YesNo) == DialogResult.Yes) // если правильно ответил, добавить ему очки
            {
                labelPlayerScore.Text = Convert.ToString(Convert.ToInt32(labelPlayerScore.Text) + 1);

                MakeSong(); // и запустить след. песню
            }

            GamePlay();
        }
    }
}
