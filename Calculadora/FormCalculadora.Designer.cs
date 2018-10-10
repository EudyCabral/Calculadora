namespace Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUno = new System.Windows.Forms.Button();
            this.buttonDos = new System.Windows.Forms.Button();
            this.buttonnueve = new System.Windows.Forms.Button();
            this.buttonocho = new System.Windows.Forms.Button();
            this.buttonsiete = new System.Windows.Forms.Button();
            this.buttonseis = new System.Windows.Forms.Button();
            this.buttoncinco = new System.Windows.Forms.Button();
            this.buttoncuatro = new System.Windows.Forms.Button();
            this.buttontres = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.buttonsuma = new System.Windows.Forms.Button();
            this.buttonresta = new System.Windows.Forms.Button();
            this.buttonDivicion = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.textBoxPantalla = new System.Windows.Forms.TextBox();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonporcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUno
            // 
            this.buttonUno.Location = new System.Drawing.Point(9, 293);
            this.buttonUno.Name = "buttonUno";
            this.buttonUno.Size = new System.Drawing.Size(75, 49);
            this.buttonUno.TabIndex = 1;
            this.buttonUno.Text = "1";
            this.buttonUno.UseVisualStyleBackColor = true;
            this.buttonUno.Click += new System.EventHandler(this.buttonUno_Click);
         
            // 
            // buttonDos
            // 
            this.buttonDos.Location = new System.Drawing.Point(90, 293);
            this.buttonDos.Name = "buttonDos";
            this.buttonDos.Size = new System.Drawing.Size(75, 49);
            this.buttonDos.TabIndex = 2;
            this.buttonDos.Text = "2";
            this.buttonDos.UseVisualStyleBackColor = true;
            this.buttonDos.Click += new System.EventHandler(this.buttonDos_Click);
            this.buttonDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonnueve
            // 
            this.buttonnueve.Location = new System.Drawing.Point(173, 183);
            this.buttonnueve.Name = "buttonnueve";
            this.buttonnueve.Size = new System.Drawing.Size(75, 49);
            this.buttonnueve.TabIndex = 9;
            this.buttonnueve.Text = "9";
            this.buttonnueve.UseVisualStyleBackColor = true;
            this.buttonnueve.Click += new System.EventHandler(this.buttonnueve_Click);
            this.buttonnueve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonocho
            // 
            this.buttonocho.Location = new System.Drawing.Point(90, 183);
            this.buttonocho.Name = "buttonocho";
            this.buttonocho.Size = new System.Drawing.Size(75, 49);
            this.buttonocho.TabIndex = 8;
            this.buttonocho.Text = "8";
            this.buttonocho.UseVisualStyleBackColor = true;
            this.buttonocho.Click += new System.EventHandler(this.buttonocho_Click);
            this.buttonocho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonsiete
            // 
            this.buttonsiete.Location = new System.Drawing.Point(9, 183);
            this.buttonsiete.Name = "buttonsiete";
            this.buttonsiete.Size = new System.Drawing.Size(75, 49);
            this.buttonsiete.TabIndex = 7;
            this.buttonsiete.Text = "7";
            this.buttonsiete.UseVisualStyleBackColor = true;
            this.buttonsiete.Click += new System.EventHandler(this.buttonsiete_Click);
            this.buttonsiete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonseis
            // 
            this.buttonseis.Location = new System.Drawing.Point(173, 238);
            this.buttonseis.Name = "buttonseis";
            this.buttonseis.Size = new System.Drawing.Size(75, 49);
            this.buttonseis.TabIndex = 6;
            this.buttonseis.Text = "6";
            this.buttonseis.UseVisualStyleBackColor = true;
            this.buttonseis.Click += new System.EventHandler(this.buttonseis_Click);
            this.buttonseis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttoncinco
            // 
            this.buttoncinco.Location = new System.Drawing.Point(90, 238);
            this.buttoncinco.Name = "buttoncinco";
            this.buttoncinco.Size = new System.Drawing.Size(75, 49);
            this.buttoncinco.TabIndex = 5;
            this.buttoncinco.Text = "5";
            this.buttoncinco.UseVisualStyleBackColor = true;
            this.buttoncinco.Click += new System.EventHandler(this.buttoncinco_Click);
            this.buttoncinco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttoncuatro
            // 
            this.buttoncuatro.Location = new System.Drawing.Point(9, 238);
            this.buttoncuatro.Name = "buttoncuatro";
            this.buttoncuatro.Size = new System.Drawing.Size(75, 49);
            this.buttoncuatro.TabIndex = 4;
            this.buttoncuatro.Text = "4";
            this.buttoncuatro.UseVisualStyleBackColor = true;
            this.buttoncuatro.Click += new System.EventHandler(this.buttoncuatro_Click);
            this.buttoncuatro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttontres
            // 
            this.buttontres.Location = new System.Drawing.Point(173, 293);
            this.buttontres.Name = "buttontres";
            this.buttontres.Size = new System.Drawing.Size(75, 49);
            this.buttontres.TabIndex = 3;
            this.buttontres.Text = "3";
            this.buttontres.UseVisualStyleBackColor = true;
            this.buttontres.Click += new System.EventHandler(this.buttontres_Click);
            this.buttontres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonzero
            // 
            this.buttonzero.Location = new System.Drawing.Point(9, 348);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(239, 49);
            this.buttonzero.TabIndex = 10;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = true;
            this.buttonzero.Click += new System.EventHandler(this.buttonzero_Click);
            this.buttonzero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonsuma
            // 
            this.buttonsuma.Location = new System.Drawing.Point(254, 128);
            this.buttonsuma.Name = "buttonsuma";
            this.buttonsuma.Size = new System.Drawing.Size(75, 49);
            this.buttonsuma.TabIndex = 14;
            this.buttonsuma.Text = "+";
            this.buttonsuma.UseVisualStyleBackColor = true;
            this.buttonsuma.Click += new System.EventHandler(this.buttonsuma_Click);
            this.buttonsuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonresta
            // 
            this.buttonresta.Location = new System.Drawing.Point(254, 183);
            this.buttonresta.Name = "buttonresta";
            this.buttonresta.Size = new System.Drawing.Size(75, 49);
            this.buttonresta.TabIndex = 13;
            this.buttonresta.Text = "-";
            this.buttonresta.UseVisualStyleBackColor = true;
            this.buttonresta.Click += new System.EventHandler(this.buttonresta_Click);
            this.buttonresta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonDivicion
            // 
            this.buttonDivicion.Location = new System.Drawing.Point(254, 238);
            this.buttonDivicion.Name = "buttonDivicion";
            this.buttonDivicion.Size = new System.Drawing.Size(75, 49);
            this.buttonDivicion.TabIndex = 12;
            this.buttonDivicion.Text = "÷";
            this.buttonDivicion.UseVisualStyleBackColor = true;
            this.buttonDivicion.Click += new System.EventHandler(this.buttonDivicion_Click);
            this.buttonDivicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.Location = new System.Drawing.Point(254, 293);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(75, 49);
            this.buttonMultiplicacion.TabIndex = 11;
            this.buttonMultiplicacion.Text = "X";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            this.buttonMultiplicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Location = new System.Drawing.Point(254, 348);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(75, 49);
            this.buttonIgual.TabIndex = 16;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            this.buttonIgual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // textBoxPantalla
            // 
            this.textBoxPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPantalla.Location = new System.Drawing.Point(8, 12);
            this.textBoxPantalla.Multiline = true;
            this.textBoxPantalla.Name = "textBoxPantalla";
            this.textBoxPantalla.ReadOnly = true;
            this.textBoxPantalla.Size = new System.Drawing.Size(318, 102);
            this.textBoxPantalla.TabIndex = 0;
            this.textBoxPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
       
            this.textBoxPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Location = new System.Drawing.Point(8, 127);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(75, 49);
            this.buttonborrar.TabIndex = 18;
            this.buttonborrar.Text = "DELETE";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
            this.buttonborrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(90, 128);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 49);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "C";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // buttonporcentaje
            // 
            this.buttonporcentaje.Location = new System.Drawing.Point(173, 128);
            this.buttonporcentaje.Name = "buttonporcentaje";
            this.buttonporcentaje.Size = new System.Drawing.Size(75, 49);
            this.buttonporcentaje.TabIndex = 15;
            this.buttonporcentaje.Text = "x2";
            this.buttonporcentaje.UseVisualStyleBackColor = true;
            this.buttonporcentaje.Click += new System.EventHandler(this.buttonporcentaje_Click);
            this.buttonporcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teclado);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 408);
            this.Controls.Add(this.buttonporcentaje);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonborrar);
            this.Controls.Add(this.textBoxPantalla);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonDivicion);
            this.Controls.Add(this.buttonresta);
            this.Controls.Add(this.buttonsuma);
            this.Controls.Add(this.buttonzero);
            this.Controls.Add(this.buttontres);
            this.Controls.Add(this.buttoncuatro);
            this.Controls.Add(this.buttoncinco);
            this.Controls.Add(this.buttonseis);
            this.Controls.Add(this.buttonsiete);
            this.Controls.Add(this.buttonocho);
            this.Controls.Add(this.buttonnueve);
            this.Controls.Add(this.buttonDos);
            this.Controls.Add(this.buttonUno);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUno;
        private System.Windows.Forms.Button buttonDos;
        private System.Windows.Forms.Button buttonnueve;
        private System.Windows.Forms.Button buttonocho;
        private System.Windows.Forms.Button buttonsiete;
        private System.Windows.Forms.Button buttonseis;
        private System.Windows.Forms.Button buttoncinco;
        private System.Windows.Forms.Button buttoncuatro;
        private System.Windows.Forms.Button buttontres;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.Button buttonsuma;
        private System.Windows.Forms.Button buttonresta;
        private System.Windows.Forms.Button buttonDivicion;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.TextBox textBoxPantalla;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonporcentaje;
    }
}

