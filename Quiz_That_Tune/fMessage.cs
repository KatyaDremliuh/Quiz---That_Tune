using System;
using System.Media;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fMessage : Form
    {
        private int timeToGiveAnAnswer = 10;

        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeToGiveAnAnswer = 10;
            timerForGiveAnAnswer.Start();
        }

        private void timerForGiveAnAnswer_Tick(object sender, EventArgs e)
        {
            timeToGiveAnAnswer--; // время тикает вниз
            lblTimerToGiveAnAnswer.Text = timeToGiveAnAnswer.ToString(); // выводим это время

            if (timeToGiveAnAnswer == 0)
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
            lblShowTheCorrectAnswer.Text = Quiz.CorrectAnswer;
        }
    }
}
