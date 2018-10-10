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
        double resultado, num1, num2;
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
           //     textBoxPantalla.Text = "+";
                operador = "+";
                num1 = double.Parse(textBoxPantalla.Text);
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
                num1 = double.Parse(textBoxPantalla.Text);
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
                num1 = double.Parse(textBoxPantalla.Text);
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
                num1 = double.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBoxPantalla.Text);
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

            if (operador == "x2")
            {
                resultado = Math.Pow(num1,2);
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

        private void buttonporcentaje_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                operador = "x2";
                num1 = double.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        private void textBoxPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void buttonUno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                buttonUno.PerformClick();
            }

        }

        private void buttonDos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                buttonDos.PerformClick();
            }
        }

        private void buttontres_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                buttontres.PerformClick();
            }
        }

        private void buttoncuatro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                buttoncuatro.PerformClick();
            }
        }

        private void buttoncinco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                buttoncinco.PerformClick();
            }
        }

        private void buttonseis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                buttonseis.PerformClick();
            }
        }

        private void buttonsiete_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                buttonsiete.PerformClick();
            }
        }

        private void buttonocho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                buttonocho.PerformClick();
            }
        }

        private void buttonnueve_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                buttonnueve.PerformClick();
            }
        }

        private void buttonzero_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                buttonzero.PerformClick();

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
