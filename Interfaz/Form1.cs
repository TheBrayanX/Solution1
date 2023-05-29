using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maquillaje mk = new maquillaje();
            this.Hide();
            mk.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfumes pfm = new perfumes();
            this.Hide();
            pfm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comprar comprar = new comprar();
            this.Hide();
            comprar.ShowDialog();
            this.Close();
        }
    }
}
