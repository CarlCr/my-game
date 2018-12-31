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
    public partial class Form2 : Form
    {
        int time;
        int cont=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende reiniciar ?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnBaralhar_Click(object sender, EventArgs e)
        {

            timer1.Start();
            txtNaoEnable();
            todastexbox();
        }
        string[] valores = new string[16] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "", };
        string[] numeros = new string[16];
        Random aleatorios = new Random();
        int index = 0;
        public void baralhar()
        {
            numeros = new string[16];

            for (int i = 0; i < 16; i++)
            {
                index = aleatorios.Next(0, 16);
                if (i == 0)
                {
                    numeros[i] = valores[index].ToString();
                }
                else
                {
                    if (numeros.Contains(valores[index]))
                    {
                        i--;
                    }
                    else
                    {
                        numeros[i] = valores[index].ToString();
                    }
                }
            }
        }
        public void todastexbox()
        {
            baralhar();
            TextBox[] todastxt = new TextBox[16] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16 };
            for (int i = 0; i < 16; i++)
            {
                todastxt[i].Text = numeros[i];
            }
        }
        public void mover(TextBox t1, TextBox t)
        {
            if (t.Text == "")
            {
                t.Text = t1.Text;
                t1.Text = "";
            }
            lbcont.Text = cont.ToString();
        }

        private void txt1_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt1, txt2);
            mover(txt1, txt5);
            cont++;
        }

        private void txt2_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt2, txt1);
            mover(txt2, txt6);
            mover(txt2, txt3);
            cont++;
        }

        private void txt3_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt3, txt2);
            mover(txt3, txt4);
            mover(txt3, txt7);
            cont++;
        }

        private void txt4_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt4, txt3);
            mover(txt4, txt8);
            cont++;
        }

        private void txt5_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt5, txt6);
            mover(txt5, txt9);
            mover(txt5, txt1);
            cont++;
        }

        private void txt6_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt6, txt2);
            mover(txt6, txt5);
            mover(txt6, txt7);
            mover(txt6, txt10);
            cont++;
        }

        private void txt7_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt7, txt3);
            mover(txt7, txt6);
            mover(txt7, txt8);
            mover(txt7, txt11);
            cont++;
        }

        private void txt8_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt8, txt4);
            mover(txt8, txt7);
            mover(txt8, txt12);
            cont++;
        }

        private void txt9_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt9, txt5);
            mover(txt9, txt10);
            mover(txt9, txt13);
            cont++;
        }

        private void txt10_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt10, txt6);
            mover(txt10, txt9);
            mover(txt10, txt11);
            mover(txt10, txt14);
            cont++;
        }

        private void txt11_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt11, txt10);
            mover(txt11, txt12);
            mover(txt11, txt7);
            mover(txt11, txt15);
            cont++;
        }

        private void txt12_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt12, txt8);
            mover(txt12, txt11);
            mover(txt12, txt16);
            cont++;
        }

        private void txt13_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt13, txt9);
            mover(txt13, txt14);
            cont++;
        }

        private void txt14_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt14, txt13);
            mover(txt14, txt15);
            mover(txt14, txt10);
            cont++;
        }

        private void txt15_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt15, txt11);
            mover(txt15, txt16);
            mover(txt15, txt14);
            cont++;
        }

        private void txt16_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt16, txt12);
            mover(txt16, txt15);
            cont++;
        }

        private void classificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        public void txtEnable()
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
            txt7.Enabled = false;
            txt8.Enabled = false;
            txt9.Enabled = false;
            txt10.Enabled = false;
            txt11.Enabled = false;
            txt12.Enabled = false;
            txt13.Enabled = false;
            txt14.Enabled = false;
            txt15.Enabled = false;
        }
        public void txtNaoEnable()
        {
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            txt7.Enabled = true;
            txt8.Enabled = true;
            txt9.Enabled = true;
            txt10.Enabled = true;
            txt11.Enabled = true;
            txt12.Enabled = true;
            txt13.Enabled = true;
            txt14.Enabled = true;
            txt15.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtEnable();
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time < 0)
            {
                lblTempo.Text = time.ToString();
            }
        }
    }
}
