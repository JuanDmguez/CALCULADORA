namespace UNACHCalculadoraWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnpromedio = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(294, 34);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(159, 41);
            this.btnsumar.TabIndex = 0;
            this.btnsumar.Text = "SUMAR";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Location = new System.Drawing.Point(294, 81);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(159, 40);
            this.btnrestar.TabIndex = 1;
            this.btnrestar.Text = "RESTAR";
            this.btnrestar.UseVisualStyleBackColor = true;
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(294, 127);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(159, 34);
            this.btnmulti.TabIndex = 2;
            this.btnmulti.Text = "MULTIPLICAR";
            this.btnmulti.UseVisualStyleBackColor = true;
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(294, 167);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(159, 34);
            this.btndividir.TabIndex = 3;
            this.btndividir.Text = "DIVIDIR";
            this.btndividir.UseVisualStyleBackColor = true;
            // 
            // btnpromedio
            // 
            this.btnpromedio.Location = new System.Drawing.Point(294, 207);
            this.btnpromedio.Name = "btnpromedio";
            this.btnpromedio.Size = new System.Drawing.Size(159, 33);
            this.btnpromedio.TabIndex = 4;
            this.btnpromedio.Text = "PROMEDIO";
            this.btnpromedio.UseVisualStyleBackColor = true;
            this.btnpromedio.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(82, 45);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(55, 38);
            this.txt1.TabIndex = 5;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(143, 45);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(51, 38);
            this.txt2.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(57, 135);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(161, 32);
            this.txt3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 370);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnpromedio);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnsumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnpromedio;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
    }
}

