using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDelegate1
{
    public partial class Form1 : Form
    {
        Ball ball;

        public Form1()
        {
            InitializeComponent();

            ball = new Ball();
            PersonA a = new PersonA(ball);
            PersonB b = new PersonB(ball);
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            ball.BallInPlayFast();
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            ball.BallInPlaySlow();
        }
    }
}
