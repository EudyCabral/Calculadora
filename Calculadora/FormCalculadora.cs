using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        bool secuencia = false;
        decimal resultado, num1, num2;
        string operador,borrar;

        private void buttontres_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "3";
            }
        }

        private void buttoncuatro_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "4";
            }
        }

        private void buttoncinco_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "5";
            }
        }

        private void buttonseis_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "6";
            }
        }

        private void buttonsiete_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "7";
            }
        }

        private void buttonocho_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "8";
            }
        }

        private void buttonnueve_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "9";
            }
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "0";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "0";
            }
        }

        private void buttonsuma_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                operador = "+";
                num1 = decimal.Parse(textBoxPantalla.Text);
                secuencia = true; }
        }

        private void buttonresta_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                operador = "-";
                num1 = decimal.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        private void buttonDivicion_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                operador = "/";
                num1 = decimal.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                operador = "x";
                num1 = decimal.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(textBoxPantalla.Text);
            if (operador == "+")
            {
                resultado = num1 + num2;
                textBoxPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operador == "-")
            {
                resultado = num1 - num2;
                textBoxPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operador == "x")
            {
                resultado = num1 * num2;
                textBoxPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            //÷
            if (operador == "/")
            {
                resultado = num1 / num2;
                textBoxPantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrar = textBoxPantalla.Text;
            x = borrar.Length - 1;
            borrar = borrar.Substring(0, x);
            textBoxPantalla.Text = borrar;

            if (textBoxPantalla.Text == "")
            {
                textBoxPantalla.Text = "0";
                secuencia = true;
            }
            if (textBoxPantalla.Text == "-")
            {
                textBoxPantalla.Text = "0";
                secuencia = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            secuencia = true;
        }

 

        private void buttonDos_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "2";
            }
        }

        private void buttonUno_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBoxPantalla.Text = "";
                textBoxPantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + "1";
            }
        }





    }
}
