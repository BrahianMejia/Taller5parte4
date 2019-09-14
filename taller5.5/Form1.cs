using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller5._5
{
    public partial class Form1 : Form
    {

        int x = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btniniciar_Click_1(object sender, EventArgs e)
        {
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            lbltemporizador.Text = x.ToString();
            x--;

            if (x < 0) {
                tiempo.Stop();
            }
        }

    }
}
