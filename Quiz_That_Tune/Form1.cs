using System;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fMain : Form
    {
        fParams _formParams = new fParams();
        private fGame _formGame = new fGame();

        public fMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // обращаемся к форме через this. Закрыть форму
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _formParams.ShowDialog(); // показать форму с параметрами
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _formGame.ShowDialog();  // показать форму "игра"
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Quiz.ReadParams();
            Quiz.ReadMusic();
        }
    }
}
