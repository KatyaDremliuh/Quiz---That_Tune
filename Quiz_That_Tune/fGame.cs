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

        void MakeSong()
        {
            int songNumber = random.Next(0, Quiz.TrackList.Count);
            WMP.URL = Quiz.TrackList[songNumber];
            // WMP.Ctlcontrols.play();

            Quiz.TrackList.RemoveAt(songNumber);
        }

        private void btbNext_Click(object sender, EventArgs e)
        {
            MakeSong();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop(); // останавливать проигрывание музыки при закрытие формы
        }
    }
}
