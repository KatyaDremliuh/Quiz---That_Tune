using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_That_Tune
{
    public partial class fMain : Form
    {
        fParams _fp = new fParams();

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
            _fp.ShowDialog(); // показать форму с параметрами
        }
    }
}
