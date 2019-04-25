using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colisao
{
    public partial class Form1 : Form
    {
        private bool paraEsquerda;
        private bool paraDireita;
        private bool paraCima;
        private bool paraBaixo;
        private int velocidade = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (paraEsquerda)
            {
                personagem.Left -= velocidade;
            }

            if (paraDireita)
            {
                personagem.Left += velocidade;
            }

            if (paraCima)
            {
                personagem.Top -= velocidade;
            }

            if (paraBaixo)
            {
                personagem.Top += velocidade;
            }

            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string) item.Tag == "muro")
                {

                    if (((PictureBox)item).Bounds.IntersectsWith(personagem.Bounds))
                    {
                        timer1.Stop();
                        personagem.Visible = false;
                        pnlMsgGameOver.Visible = true;
                        lblMsgGameOver.Visible = true;
                        lblMsgGameOver.Text = "GAME OVER";
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                paraDireita = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                paraCima = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                paraDireita = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                paraCima = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = false;
            }
        }
    }
}
