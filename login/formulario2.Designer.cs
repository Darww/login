namespace login
{
    partial class formulario2
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txttarjeta = new TextBox();
            pictureBox1 = new PictureBox();
            btnabonar = new Button();
            btnretirar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 43);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 97);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero de tarjeta:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(234, 29);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(365, 34);
            txtnombre.TabIndex = 2;
            txtnombre.TextChanged += textBox1_TextChanged;
            txtnombre.KeyPress += textBox1_KeyPress;
            // 
            // txttarjeta
            // 
            txttarjeta.Location = new Point(234, 83);
            txttarjeta.Multiline = true;
            txttarjeta.Name = "txttarjeta";
            txttarjeta.Size = new Size(365, 34);
            txttarjeta.TabIndex = 3;
            txttarjeta.KeyPress += textBox2_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eraser;
            pictureBox1.Location = new Point(616, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnabonar
            // 
            btnabonar.Location = new Point(234, 200);
            btnabonar.Name = "btnabonar";
            btnabonar.Size = new Size(94, 29);
            btnabonar.TabIndex = 5;
            btnabonar.Text = "Abonar";
            btnabonar.UseVisualStyleBackColor = true;
            btnabonar.Click += btnabonar_Click;
            // 
            // btnretirar
            // 
            btnretirar.Location = new Point(505, 200);
            btnretirar.Name = "btnretirar";
            btnretirar.Size = new Size(94, 29);
            btnretirar.TabIndex = 6;
            btnretirar.Text = "Retirar";
            btnretirar.UseVisualStyleBackColor = true;
            btnretirar.Click += btnretirar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 147);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 7;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 147);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(234, 140);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 9;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 147);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 10;
            label5.Text = "Total:";
            // 
            // txtotal
            // 
            txtotal.Location = new Point(474, 140);
            txtotal.Name = "txtotal";
            txtotal.Size = new Size(125, 27);
            txtotal.TabIndex = 11;
            txtotal.TextChanged += txtotal_TextChanged;
            // 
            // formulario2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtotal);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnretirar);
            Controls.Add(btnabonar);
            Controls.Add(pictureBox1);
            Controls.Add(txttarjeta);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formulario2";
            Text = "formulario2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txttarjeta;
        private PictureBox pictureBox1;
        private Button btnabonar;
        private Button btnretirar;
        private Label label3;
        private Label label4;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtotal;
    }
}