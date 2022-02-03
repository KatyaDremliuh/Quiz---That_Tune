using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fGame : Form
    {
        private readonly Random _random = new Random();
        private int _musicDuration = Quiz.MusicDuration;
        private readonly bool[] _players = new bool[2];

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

                int songNumber = _random.Next(0, Quiz.TrackList.Count);
                WMP.URL = Quiz.TrackList[songNumber];

                Quiz.CorrectAnswer = Path.GetFileNameWithoutExtension(WMP.URL);

                // WMP.Ctlcontrols.play();

                Quiz.TrackList.RemoveAt(songNumber); // убираем песню, кот. уже была

                lblSongsCounter.Text = Quiz.TrackList.Count.ToString(); // показать, сколько осталось песен в списке

                _players[0] = false;
                _players[1] = false;
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

            if (!timer.Enabled) // запретить нажатие клавиш, пока игра не началась
            {
                return;
            }

            if (!_players[0] && keyEventArgs.KeyData == Keys.Q)
            {
                PlayerWantsToGiveHisAnswer("Player № 1", lblScorePlayer1);
            }

            if (!_players[1] && keyEventArgs.KeyData == Keys.P)
            {
                PlayerWantsToGiveHisAnswer("Player № 2", lblScorePlayer2);
            }
        }

        private void PlayerWantsToGiveHisAnswer(string player, Label labelPlayerScore)
        {
            GamePause();

            fMessage fMessage = new fMessage();
            fMessage.lblMessage.Text = player;

            if (player == "Player № 1")
            {
                SoundPlayer soundPlayer = new SoundPlayer("Resources\\Player1.wav");
                soundPlayer.PlaySync();

                _players[0] = true;
            }
            if (player == "Player № 2")
            {
                SoundPlayer soundPlayer = new SoundPlayer("Resources\\Player2.wav");
                soundPlayer.PlaySync();

                _players[1] = true;
            }


            if (fMessage.ShowDialog() == DialogResult.Yes) // если правильно ответил, добавить ему очки
            {
                labelPlayerScore.Text = Convert.ToString(Convert.ToInt32(labelPlayerScore.Text) + 1);

                MakeSong(); // и запустить след. песню
            }

            GamePlay();
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.RandomStart)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    // со случайного места вкл песню
                    WMP.Ctlcontrols.currentPosition = _random.Next(0, (int)WMP.currentMedia.duration / 2);
                }
            }
        }

        private void lblScorePlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((Label)sender).Text = Convert.ToString(Convert.ToInt32(((Label)sender).Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                ((Label)sender).Text = Convert.ToString(Convert.ToInt32(((Label)sender).Text) - 1);
            }
        }
    }
}
