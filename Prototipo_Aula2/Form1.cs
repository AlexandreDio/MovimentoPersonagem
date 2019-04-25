using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Aula2
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
                pictureBox1.Left -= velocidade;
            }

            if (paraDireita)
            {
                pictureBox1.Left += velocidade;
            }

            if (paraCima)
            {
                pictureBox1.Top -= velocidade;
            }

            if (paraBaixo)
            {
                pictureBox1.Top += velocidade;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
