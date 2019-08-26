namespace actividad2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.TextBox();
            this.inicio = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Super Secreto";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(267, 142);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(346, 20);
            this.usuario.TabIndex = 3;
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(267, 207);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(345, 20);
            this.clave.TabIndex = 4;
            this.clave.TextChanged += new System.EventHandler(this.Clave_TextChanged);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(107, 308);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(144, 123);
            this.inicio.TabIndex = 5;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.Button1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(596, 308);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(140, 123);
            this.salir.TabIndex = 6;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button salir;
    }
}

