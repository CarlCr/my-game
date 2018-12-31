using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvadeTLP
{
    public partial class Escolher : Form
    {
        public Escolher()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            inicio chama = new inicio();
            chama.Show();
            this.Visible = false;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Text = txtNome.Text + " " + "escolha o nível de dificuldade :";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form1 chama = new Form1();
            chama.Show();
            this.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form2 chama = new Form2();
            chama.Show();
            this.Visible = false;
        }
    }
}
