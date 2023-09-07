namespace login
{
    partial class Login1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            pbmostrar = new PictureBox();
            pbOcultar = new PictureBox();
            pbuser = new PictureBox();
            pbpass = new PictureBox();
            btiniciar = new Button();
            olvidadocontra = new LinkLabel();
            pbborrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbmostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbborrar).BeginInit();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(178, 73);
            txtusuario.Multiline = true;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(362, 45);
            txtusuario.TabIndex = 0;
            txtusuario.KeyPress += textBox1_KeyPress;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(178, 147);
            txtcontraseña.Multiline = true;
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(362, 45);
            txtcontraseña.TabIndex = 1;
            txtcontraseña.KeyPress += textBox2_KeyPress;
            // 
            // pbmostrar
            // 
            pbmostrar.Image = Properties.Resources._141947;
            pbmostrar.Location = new Point(546, 147);
            pbmostrar.Name = "pbmostrar";
            pbmostrar.Size = new Size(54, 45);
            pbmostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbmostrar.TabIndex = 2;
            pbmostrar.TabStop = false;
            pbmostrar.Click += pbMostrar_Click;
            // 
            // pbOcultar
            // 
            pbOcultar.Image = Properties.Resources.images1;
            pbOcultar.Location = new Point(546, 147);
            pbOcultar.Name = "pbOcultar";
            pbOcultar.Size = new Size(54, 45);
            pbOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultar.TabIndex = 3;
            pbOcultar.TabStop = false;
            pbOcultar.Click += pbOcultar_Click;
            // 
            // pbuser
            // 
            pbuser.Image = Properties.Resources.user_icon_150670;
            pbuser.Location = new Point(118, 73);
            pbuser.Name = "pbuser";
            pbuser.Size = new Size(54, 45);
            pbuser.SizeMode = PictureBoxSizeMode.Zoom;
            pbuser.TabIndex = 4;
            pbuser.TabStop = false;
            // 
            // pbpass
            // 
            pbpass.Image = Properties.Resources.passs1;
            pbpass.Location = new Point(118, 147);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(54, 45);
            pbpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbpass.TabIndex = 5;
            pbpass.TabStop = false;
            // 
            // btiniciar
            // 
            btiniciar.BackColor = Color.DodgerBlue;
            btiniciar.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btiniciar.ForeColor = SystemColors.ActiveCaptionText;
            btiniciar.Location = new Point(178, 253);
            btiniciar.Name = "btiniciar";
            btiniciar.Size = new Size(362, 50);
            btiniciar.TabIndex = 6;
            btiniciar.Text = "Iniciar Sesión";
            btiniciar.UseVisualStyleBackColor = false;
            btiniciar.Click += btiniciar_Click;
            btiniciar.MouseEnter += btiniciar_MouseEnter;
            btiniciar.MouseLeave += btiniciar_MouseLeave;
            // 
            // olvidadocontra
            // 
            olvidadocontra.AutoSize = true;
            olvidadocontra.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            olvidadocontra.Location = new Point(220, 327);
            olvidadocontra.Name = "olvidadocontra";
            olvidadocontra.Size = new Size(275, 24);
            olvidadocontra.TabIndex = 7;
            olvidadocontra.TabStop = true;
            olvidadocontra.Text = "¿Has olvidado la contraseña?";
            olvidadocontra.MouseEnter += olvidadocontra_MouseEnter;
            olvidadocontra.MouseLeave += olvidadocontra_MouseLeave;
            // 
            // pbborrar
            // 
            pbborrar.Image = Properties.Resources.eraser;
            pbborrar.Location = new Point(546, 73);
            pbborrar.Name = "pbborrar";
            pbborrar.Size = new Size(54, 45);
            pbborrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbborrar.TabIndex = 8;
            pbborrar.TabStop = false;
            pbborrar.Click += pictureBox1_Click;
            pbborrar.MouseEnter += pictureBox1_MouseEnter;
            // 
            // Login1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pbborrar);
            Controls.Add(olvidadocontra);
            Controls.Add(btiniciar);
            Controls.Add(pbmostrar);
            Controls.Add(pbpass);
            Controls.Add(pbuser);
            Controls.Add(pbOcultar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Name = "Login1";
            Text = "Login1";
            ((System.ComponentModel.ISupportInitialize)pbmostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbborrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private PictureBox pbmostrar;
        private PictureBox pbOcultar;
        private PictureBox pbuser;
        private PictureBox pbpass;
        private Button btiniciar;
        private LinkLabel olvidadocontra;
        private PictureBox pbborrar;
    }
}