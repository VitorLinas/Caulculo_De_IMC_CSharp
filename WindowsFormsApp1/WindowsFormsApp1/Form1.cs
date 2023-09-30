using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Este código será executado quando o botão button1 for clicado
            //MessageBox.Show("Botão clicado!");

            // Obtenha o peso do TextBox
            double peso;
            if (double.TryParse(numericUpDown1.Text, out peso))
            {
                // Obtenha a altura do TextBox
                double altura;
                if (double.TryParse(numericUpDown2.Text, out altura))
                {
                    // Calcule o IMC
                    double imc = peso / (altura * altura);

                    //CONDICIONAL DE PESO

                    if (imc < 18.5)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Abaixo do peso";
                    }
                    else if (imc >= 18.5 && imc < 24.9)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Peso saudável";
                    }
                    else if (imc >= 25 && imc < 29.9)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Sobrepesol";
                    }
                    else if (imc >= 30 && imc < 34.9)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Obesidade grau 1";
                    }
                    else if (imc >= 35 && imc < 39.9)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Obesidade grau 2";
                    }
                    else if (imc >= 40)
                    {
                        textBox1.Text = "Seu IMC é " + imc.ToString("F2") + ": Obesidade grau 3 (obesidade mórbida)";
                    }

                    textBox1.Height = 100;
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma altura válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um peso válido.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  



    }
}
