using System;
using System.Media;
using System.Windows.Forms;
using TagLib;

namespace Quiz_That_Tune
{
    public partial class fMessage : Form
    {
        private int _timeToGiveAnAnswer = 10;

        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            _timeToGiveAnAnswer = 10;
            timerForGiveAnAnswer.Start();
        }

        private void timerForGiveAnAnswer_Tick(object sender, EventArgs e)
        {
            _timeToGiveAnAnswer--; // время тикает вниз
            lblTimerToGiveAnAnswer.Text = _timeToGiveAnAnswer.ToString(); // выводим это время

            if (_timeToGiveAnAnswer == 0)
            {
                timerForGiveAnAnswer.Stop(); // таймер останавливается

                SoundPlayer soundPlayer = new SoundPlayer("Resources\\TimeIsOver.wav"); // звуковой сигнал
                soundPlayer.Play();

                this.Close(); // закрывается форма fMessage, если не успел дать ответ
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerForGiveAnAnswer.Stop();
        }

        private void lblShowTheCorrectAnswer_Click(object sender, EventArgs e)
        {
            File mp3File = TagLib.File.Create(Quiz.CorrectAnswer);
            lblShowTheCorrectAnswer.Text = $"{mp3File.Tag.FirstPerformer} {mp3File.Tag.Title}";
            
            //lblShowTheCorrectAnswer.Text = Quiz.CorrectAnswer;
        }
    }
}
