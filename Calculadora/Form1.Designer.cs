namespace Calculadora
{
    partial class Form1
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
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonParentesisAbre = new System.Windows.Forms.Button();
            this.buttonParentesisCierra = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.textBoxExpresion = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(98, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 40);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(184, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 40);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 204);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(166, 40);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.Black;
            this.buttonIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.ForeColor = System.Drawing.Color.White;
            this.buttonIgual.Location = new System.Drawing.Point(270, 203);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(166, 40);
            this.buttonIgual.TabIndex = 11;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivision.Location = new System.Drawing.Point(270, 112);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(80, 40);
            this.buttonDivision.TabIndex = 12;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonOperador_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplicacion.Location = new System.Drawing.Point(356, 112);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(80, 40);
            this.buttonMultiplicacion.TabIndex = 13;
            this.buttonMultiplicacion.Text = "*";
            this.buttonMultiplicacion.UseVisualStyleBackColor = false;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonOperador_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResta.Location = new System.Drawing.Point(356, 158);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(80, 40);
            this.buttonResta.TabIndex = 14;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = false;
            this.buttonResta.Click += new System.EventHandler(this.buttonOperador_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuma.Location = new System.Drawing.Point(270, 158);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(80, 40);
            this.buttonSuma.TabIndex = 15;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = false;
            this.buttonSuma.Click += new System.EventHandler(this.buttonOperador_Click);
            // 
            // buttonParentesisAbre
            // 
            this.buttonParentesisAbre.Location = new System.Drawing.Point(270, 66);
            this.buttonParentesisAbre.Name = "buttonParentesisAbre";
            this.buttonParentesisAbre.Size = new System.Drawing.Size(80, 40);
            this.buttonParentesisAbre.TabIndex = 16;
            this.buttonParentesisAbre.Text = "(";
            this.buttonParentesisAbre.UseVisualStyleBackColor = true;
            this.buttonParentesisAbre.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonParentesisCierra
            // 
            this.buttonParentesisCierra.Location = new System.Drawing.Point(356, 66);
            this.buttonParentesisCierra.Name = "buttonParentesisCierra";
            this.buttonParentesisCierra.Size = new System.Drawing.Size(80, 40);
            this.buttonParentesisCierra.TabIndex = 17;
            this.buttonParentesisCierra.Text = ")";
            this.buttonParentesisCierra.UseVisualStyleBackColor = true;
            this.buttonParentesisCierra.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // buttonPunto
            // 
            this.buttonPunto.Location = new System.Drawing.Point(184, 203);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(80, 40);
            this.buttonPunto.TabIndex = 18;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = true;
            this.buttonPunto.Click += new System.EventHandler(this.buttonNumero_Click);
            // 
            // textBoxExpresion
            // 
            this.textBoxExpresion.Location = new System.Drawing.Point(12, 12);
            this.textBoxExpresion.Name = "textBoxExpresion";
            this.textBoxExpresion.Size = new System.Drawing.Size(423, 20);
            this.textBoxExpresion.TabIndex = 19;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(12, 38);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(423, 20);
            this.textBoxResultado.TabIndex = 20;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.Silver;
            this.buttonBorrar.Location = new System.Drawing.Point(270, 249);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(165, 40);
            this.buttonBorrar.TabIndex = 21;
            this.buttonBorrar.Text = "<-";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.DarkRed;
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 249);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(252, 40);
            this.buttonLimpiar.TabIndex = 22;
            this.buttonLimpiar.Text = "LIMPIAR";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 303);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxExpresion);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.buttonParentesisCierra);
            this.Controls.Add(this.buttonParentesisAbre);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonParentesisAbre;
        private System.Windows.Forms.Button buttonParentesisCierra;
        private System.Windows.Forms.Button buttonPunto;
        private System.Windows.Forms.TextBox textBoxExpresion;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

