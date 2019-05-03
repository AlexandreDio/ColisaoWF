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
        private int pontos = 0;
        private bool temColisao = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPontos.Text = "Pontos: " + pontos;

            if (paraEsquerda)
            {
                pbHeroi.Left -= velocidade;
            }

            if (paraDireita)
            {
                pbHeroi.Left += velocidade;
            }

            if (paraCima)
            {
                pbHeroi.Top -= velocidade;
            }

            if (paraBaixo)
            {
                pbHeroi.Top += velocidade;
            }

            foreach (Control item in this.Controls)
            {
                //Verifica colisões entre o herói e demais itens no formulário
                if (item is PictureBox && VerificaColisao(item, pbHeroi))
                {
                    switch (item.Tag)
                    {
                        case "muro":
                            FinalizaJogo();
                            break;
                        case "coletaveis":
                            pontos++;
                            this.Controls.Remove(item);
                            break;
                    }
                    
                }
            }
        }

        private bool VerificaColisao(Control it, PictureBox pb)
        {
            if (((PictureBox)it).Bounds.IntersectsWith(pb.Bounds))
                return true;
            return false;
        }

        private void ColetaItens()
        {
            pbMoeda.Visible = false;
            lblPontos.Text += pontos;
        }

        private void FinalizaJogo()
        {
            timer1.Stop();
            pbHeroi.Visible = false;
            lblMsgGameOver.Visible = true;
            lblMsgGameOver.Text = "GAME OVER";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
