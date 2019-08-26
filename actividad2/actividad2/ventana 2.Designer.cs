namespace actividad2
{
    partial class ventana_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visualc = new System.Windows.Forms.CheckBox();
            this.visualb = new System.Windows.Forms.CheckBox();
            this.tarjeta = new System.Windows.Forms.RadioButton();
            this.paypal = new System.Windows.Forms.RadioButton();
            this.btncomprar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso en venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago";
            // 
            // visualc
            // 
            this.visualc.AutoSize = true;
            this.visualc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.visualc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualc.Location = new System.Drawing.Point(19, 123);
            this.visualc.Name = "visualc";
            this.visualc.Size = new System.Drawing.Size(83, 20);
            this.visualc.TabIndex = 2;
            this.visualc.Text = "Visual C#";
            this.visualc.UseVisualStyleBackColor = false;
            // 
            // visualb
            // 
            this.visualb.AutoSize = true;
            this.visualb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.visualb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualb.Location = new System.Drawing.Point(19, 189);
            this.visualb.Name = "visualb";
            this.visualb.Size = new System.Drawing.Size(101, 20);
            this.visualb.TabIndex = 3;
            this.visualb.Text = "Visual Basic";
            this.visualb.UseVisualStyleBackColor = false;
            this.visualb.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // tarjeta
            // 
            this.tarjeta.AutoSize = true;
            this.tarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjeta.Location = new System.Drawing.Point(414, 122);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(134, 20);
            this.tarjeta.TabIndex = 6;
            this.tarjeta.TabStop = true;
            this.tarjeta.Text = "Tarjeta de Credito";
            this.tarjeta.UseVisualStyleBackColor = false;
            // 
            // paypal
            // 
            this.paypal.AutoSize = true;
            this.paypal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.paypal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypal.Location = new System.Drawing.Point(414, 188);
            this.paypal.Name = "paypal";
            this.paypal.Size = new System.Drawing.Size(70, 20);
            this.paypal.TabIndex = 7;
            this.paypal.TabStop = true;
            this.paypal.Text = "PayPal";
            this.paypal.UseVisualStyleBackColor = false;
            // 
            // btncomprar
            // 
            this.btncomprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncomprar.Location = new System.Drawing.Point(19, 313);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(131, 100);
            this.btncomprar.TabIndex = 8;
            this.btncomprar.Text = "comprar";
            this.btncomprar.UseVisualStyleBackColor = false;
            this.btncomprar.Click += new System.EventHandler(this.Btncomprar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncerrar.Location = new System.Drawing.Point(400, 313);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(131, 100);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // ventana_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.paypal);
            this.Controls.Add(this.tarjeta);
            this.Controls.Add(this.visualb);
            this.Controls.Add(this.visualc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ventana_2";
            this.Text = "ventana_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox visualc;
        private System.Windows.Forms.CheckBox visualb;
        private System.Windows.Forms.RadioButton tarjeta;
        private System.Windows.Forms.RadioButton paypal;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.Button btncerrar;
    }
}