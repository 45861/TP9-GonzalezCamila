namespace ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelsuma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelresta = new System.Windows.Forms.Label();
            this.labelmultiplicacion = new System.Windows.Forms.Label();
            this.labeldivision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un numero en cada casilla";
            // 
            // labelsuma
            // 
            this.labelsuma.AutoSize = true;
            this.labelsuma.Location = new System.Drawing.Point(376, 68);
            this.labelsuma.Name = "labelsuma";
            this.labelsuma.Size = new System.Drawing.Size(34, 13);
            this.labelsuma.TabIndex = 1;
            this.labelsuma.Text = "Suma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cacular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelresta
            // 
            this.labelresta.AutoSize = true;
            this.labelresta.Location = new System.Drawing.Point(376, 101);
            this.labelresta.Name = "labelresta";
            this.labelresta.Size = new System.Drawing.Size(35, 13);
            this.labelresta.TabIndex = 5;
            this.labelresta.Text = "Resta";
            // 
            // labelmultiplicacion
            // 
            this.labelmultiplicacion.AutoSize = true;
            this.labelmultiplicacion.Location = new System.Drawing.Point(457, 68);
            this.labelmultiplicacion.Name = "labelmultiplicacion";
            this.labelmultiplicacion.Size = new System.Drawing.Size(71, 13);
            this.labelmultiplicacion.TabIndex = 6;
            this.labelmultiplicacion.Text = "Multiplicacion";
            // 
            // labeldivision
            // 
            this.labeldivision.AutoSize = true;
            this.labeldivision.Location = new System.Drawing.Point(457, 101);
            this.labeldivision.Name = "labeldivision";
            this.labeldivision.Size = new System.Drawing.Size(44, 13);
            this.labeldivision.TabIndex = 7;
            this.labeldivision.Text = "Division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeldivision);
            this.Controls.Add(this.labelmultiplicacion);
            this.Controls.Add(this.labelresta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelsuma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelsuma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelresta;
        private System.Windows.Forms.Label labelmultiplicacion;
        private System.Windows.Forms.Label labeldivision;
    }
}

