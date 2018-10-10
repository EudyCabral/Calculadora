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

        /// <summary>
        /// Programacion de los Numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
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

        /// <summary>
        /// Programacion de los Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonsuma_Click(object sender, EventArgs e)
        {
            if (textBoxPantalla.Text == string.Empty)
            {
                MessageBox.Show("Debe Introducir un Numero", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
      
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
                operador = "*";
                num1 = double.Parse(textBoxPantalla.Text);
                secuencia = true;
            }
        }

        /// <summary>
        /// Programacion de El boton Igual (Resultado)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (operador == "*")
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


    



        /// <summary>
        /// Boton de Reseteo  y Borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
           
            textBoxPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            secuencia = true;

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
        /// <summary>
        /// Teclas Programadas para Operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     
        public void Teclado(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.D1) || e.KeyChar == Convert.ToChar(Keys.NumPad1))
            {
                buttonUno.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D2) || e.KeyChar == Convert.ToChar(Keys.NumPad2))
            {
                buttonDos.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D3) || e.KeyChar == Convert.ToChar(Keys.NumPad3))
            {
                buttontres.PerformClick();
            }


            if (e.KeyChar == Convert.ToChar(Keys.D4) || e.KeyChar == Convert.ToChar(Keys.NumPad4))
            {
                buttoncuatro.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D5) || e.KeyChar == Convert.ToChar(Keys.NumPad5))
            {
                buttoncinco.PerformClick();
            }
            if (e.KeyChar == Convert.ToChar(Keys.D6) || e.KeyChar == Convert.ToChar(Keys.NumPad6))
            {
                buttonseis.PerformClick();
            }
            if (e.KeyChar == Convert.ToChar(Keys.D7) || e.KeyChar == Convert.ToChar(Keys.NumPad7))
            {
                buttonsiete.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D8) || e.KeyChar == Convert.ToChar(Keys.NumPad8))
            {
                buttonocho.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D9) || e.KeyChar == Convert.ToChar(Keys.NumPad9))
            {
                buttonnueve.PerformClick();
            }

            if (e.KeyChar == Convert.ToChar(Keys.D0) || e.KeyChar == Convert.ToChar(Keys.NumPad0))
            {
                buttonzero.PerformClick();
            }


            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                buttonborrar.PerformClick();
            }
        }


    }
}
