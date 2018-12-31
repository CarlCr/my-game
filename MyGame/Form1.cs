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
    public partial class Form1 : Form
    {
        int time2;
        int time;
        Random baralha = new Random();
        public int cont = 1;
        

        public Form1()
        {
            InitializeComponent();
        }
 
        public void mover (TextBox t1 , TextBox t2)
        {
            if (t2.Text == "")
            {
                t2.Text = t1.Text;
                t1.Text = "";
            }
            vencer();
            lbcont.Text = cont.ToString();
        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 0)
            {
                lblTempo.Text =time2.ToString()+":"+ time.ToString();
            }
            if (time == 60)
            {
                time = 0;
                time2++;
            }
            if (time2 == 1)
            {
                timer1.Stop();
                txtEnable();
                
            }
        }
 
        public string[] caracteres = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "" };
        public string[] numeros = new string[9];
        public Random baralho = new Random();
        int index = 0;
        public void ordenar()
        {
            numeros = new string[9];

            for(int i = 0; i < 9; i++)
            {
               index = baralho.Next(0, 9);
                if (i == 0)
                {
                    numeros[i] = caracteres[index].ToString();
                }
                else
                {
                    
                    if (numeros.Contains(caracteres[index]))
                    {
                        i--;
                    }
                    else
                    {
                        numeros[i] = caracteres[index].ToString();
                    }
                }

            }
           

        }
        public void todasTextBox()
        {
            ordenar();
            TextBox[] test = new TextBox[9] { txt1, txt2, txt3, txt4, txt5, txt6, txt7,txt8,txt9 };
            for(int i = 0; i < 9; i++)
            {

                test[i].Text = numeros[i];
            }
            
        }

        private void btnBaralhar_Click(object sender, EventArgs e)
        {
            txtNaoEnable();
           timer1.Start();
            todasTextBox();
        }

        private void txt1_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt1, txt2);
            mover(txt1, txt4);
            cont++;
        }
 
 
        private void txt2_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt2, txt1);
            mover(txt2, txt3);
            mover(txt2, txt5);
            cont++;
        }

        private void txt3_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt3, txt2);
            mover(txt3, txt6);
            cont++;
        }

        private void txt4_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt4, txt1);
            mover(txt4, txt5);
            mover(txt4, txt7);
            cont++;
        }

        private void txt5_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt5, txt2);
            mover(txt5, txt6);
            mover(txt5, txt4);
            mover(txt5, txt8);
            cont++;
        }

        private void txt6_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt6, txt3);
            mover(txt6, txt5);
            mover(txt6, txt9);
            cont++;
            //mover(txt3, txt6);
        }

        private void txt7_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt7, txt4);
            mover(txt7, txt8);
            cont++;

        }

        private void txt8_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt8, txt5);
            mover(txt8, txt7);
            mover(txt8, txt9);
            cont++;
        }

        private void txt9_MouseClick(object sender, MouseEventArgs e)
        {
            mover(txt9, txt6);
            mover(txt9, txt8);
            cont++;

        }
        public void vencer()
        {
            if(txt1.Text=="1" && txt2.Text == "2"&& txt3.Text == "3"&& txt4.Text == "4"&& txt5.Text == "5"&& txt6.Text == "6"&& txt7.Text == "7"&& txt8.Text == "8"&& txt9.Text == "")
            {
                MessageBox.Show("Venceu");
                timer1.Stop();
                cont = 0;
                time = 0;
            }
            
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

        private void classificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEnable();
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
        }
    }
}
