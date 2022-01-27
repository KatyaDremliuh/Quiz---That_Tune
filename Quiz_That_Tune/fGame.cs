using System;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void btbNext_Click(object sender, EventArgs e)
        {
            WMP.URL = Quiz.TrackList[0];
        }
    }
}
