namespace calculadora_basica
{
    partial class Form1
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
            btnsuma = new Button();
            textBox1 = new TextBox();
            btnresta = new Button();
            btndos = new Button();
            btnuno = new Button();
            btncinco = new Button();
            btncuatro = new Button();
            btnocho = new Button();
            btnsiete = new Button();
            btncero = new Button();
            btnCE = new Button();
            btnseis = new Button();
            btnC = new Button();
            btntres = new Button();
            btndivision = new Button();
            btnmultiplicacion = new Button();
            btnpunto = new Button();
            btnnueve = new Button();
            btnigual = new Button();
            SuspendLayout();
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.CornflowerBlue;
            btnsuma.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnsuma.ForeColor = Color.FromArgb(255, 192, 192);
            btnsuma.Location = new Point(12, 118);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(68, 60);
            btnsuma.TabIndex = 0;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 71);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.CornflowerBlue;
            btnresta.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnresta.ForeColor = Color.FromArgb(255, 192, 192);
            btnresta.Location = new Point(99, 118);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(68, 60);
            btnresta.TabIndex = 2;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btndos
            // 
            btndos.BackColor = Color.FromArgb(192, 255, 192);
            btndos.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btndos.ForeColor = Color.FromArgb(192, 192, 255);
            btndos.Location = new Point(99, 196);
            btndos.Name = "btndos";
            btndos.Size = new Size(68, 60);
            btndos.TabIndex = 4;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = false;
            btndos.Click += btndos_Click;
            // 
            // btnuno
            // 
            btnuno.BackColor = Color.FromArgb(192, 255, 192);
            btnuno.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnuno.ForeColor = Color.FromArgb(192, 192, 255);
            btnuno.Location = new Point(12, 196);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(68, 60);
            btnuno.TabIndex = 3;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = false;
            btnuno.Click += btnuno_Click;
            // 
            // btncinco
            // 
            btncinco.BackColor = Color.FromArgb(192, 255, 192);
            btncinco.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btncinco.ForeColor = Color.FromArgb(192, 192, 255);
            btncinco.Location = new Point(99, 262);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(68, 60);
            btncinco.TabIndex = 6;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = false;
            btncinco.Click += btncinco_Click;
            // 
            // btncuatro
            // 
            btncuatro.BackColor = Color.FromArgb(192, 255, 192);
            btncuatro.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btncuatro.ForeColor = Color.FromArgb(192, 192, 255);
            btncuatro.Location = new Point(12, 262);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(68, 60);
            btncuatro.TabIndex = 5;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = false;
            btncuatro.Click += btncuatro_Click;
            // 
            // btnocho
            // 
            btnocho.BackColor = Color.FromArgb(192, 255, 192);
            btnocho.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnocho.ForeColor = Color.FromArgb(192, 192, 255);
            btnocho.Location = new Point(99, 328);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(68, 60);
            btnocho.TabIndex = 8;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = false;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.BackColor = Color.FromArgb(192, 255, 192);
            btnsiete.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnsiete.ForeColor = Color.FromArgb(192, 192, 255);
            btnsiete.Location = new Point(12, 328);
            btnsiete.Name = "btnsiete";
            btnsiete.Size = new Size(68, 60);
            btnsiete.TabIndex = 7;
            btnsiete.Text = "7";
            btnsiete.UseVisualStyleBackColor = false;
            btnsiete.Click += btnsiete_Click;
            // 
            // btncero
            // 
            btncero.BackColor = Color.FromArgb(192, 255, 192);
            btncero.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btncero.ForeColor = Color.FromArgb(192, 192, 255);
            btncero.Location = new Point(12, 394);
            btncero.Name = "btncero";
            btncero.Size = new Size(155, 60);
            btncero.TabIndex = 9;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = false;
            btncero.Click += btncero_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.CornflowerBlue;
            btnCE.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.ForeColor = Color.FromArgb(255, 192, 192);
            btnCE.Location = new Point(277, 262);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(68, 60);
            btnCE.TabIndex = 15;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnseis
            // 
            btnseis.BackColor = Color.FromArgb(192, 255, 192);
            btnseis.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnseis.ForeColor = Color.FromArgb(192, 192, 255);
            btnseis.Location = new Point(187, 262);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(68, 60);
            btnseis.TabIndex = 14;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = false;
            btnseis.Click += btnseis_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.CornflowerBlue;
            btnC.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.ForeColor = Color.FromArgb(255, 192, 192);
            btnC.Location = new Point(277, 196);
            btnC.Name = "btnC";
            btnC.Size = new Size(68, 60);
            btnC.TabIndex = 13;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btntres
            // 
            btntres.BackColor = Color.FromArgb(192, 255, 192);
            btntres.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btntres.ForeColor = Color.FromArgb(192, 192, 255);
            btntres.Location = new Point(187, 196);
            btntres.Name = "btntres";
            btntres.Size = new Size(68, 60);
            btntres.TabIndex = 12;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = false;
            btntres.Click += btntres_Click;
            // 
            // btndivision
            // 
            btndivision.BackColor = Color.CornflowerBlue;
            btndivision.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btndivision.ForeColor = Color.FromArgb(255, 192, 192);
            btndivision.Location = new Point(277, 118);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(68, 60);
            btndivision.TabIndex = 11;
            btndivision.Text = "/";
            btndivision.UseVisualStyleBackColor = false;
            btndivision.Click += btndivision_Click;
            // 
            // btnmultiplicacion
            // 
            btnmultiplicacion.BackColor = Color.CornflowerBlue;
            btnmultiplicacion.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnmultiplicacion.ForeColor = Color.FromArgb(255, 192, 192);
            btnmultiplicacion.Location = new Point(187, 118);
            btnmultiplicacion.Name = "btnmultiplicacion";
            btnmultiplicacion.Size = new Size(68, 60);
            btnmultiplicacion.TabIndex = 10;
            btnmultiplicacion.Text = "*";
            btnmultiplicacion.UseVisualStyleBackColor = false;
            btnmultiplicacion.Click += btnmultiplicacion_Click;
            // 
            // btnpunto
            // 
            btnpunto.BackColor = Color.FromArgb(192, 255, 192);
            btnpunto.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnpunto.ForeColor = Color.FromArgb(192, 192, 255);
            btnpunto.Location = new Point(187, 394);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(68, 60);
            btnpunto.TabIndex = 17;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = false;
            btnpunto.Click += btnpunto_Click;
            // 
            // btnnueve
            // 
            btnnueve.BackColor = Color.FromArgb(192, 255, 192);
            btnnueve.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnnueve.ForeColor = Color.FromArgb(192, 192, 255);
            btnnueve.Location = new Point(187, 328);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(68, 60);
            btnnueve.TabIndex = 16;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = false;
            btnnueve.Click += btnnueve_Click;
            // 
            // btnigual
            // 
            btnigual.BackColor = Color.CornflowerBlue;
            btnigual.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnigual.ForeColor = Color.FromArgb(255, 192, 192);
            btnigual.Location = new Point(277, 325);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(68, 126);
            btnigual.TabIndex = 18;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = false;
            btnigual.Click += btnigual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 463);
            Controls.Add(btnigual);
            Controls.Add(btnpunto);
            Controls.Add(btnnueve);
            Controls.Add(btnCE);
            Controls.Add(btnseis);
            Controls.Add(btnC);
            Controls.Add(btntres);
            Controls.Add(btndivision);
            Controls.Add(btnmultiplicacion);
            Controls.Add(btncero);
            Controls.Add(btnocho);
            Controls.Add(btnsiete);
            Controls.Add(btncinco);
            Controls.Add(btncuatro);
            Controls.Add(btndos);
            Controls.Add(btnuno);
            Controls.Add(btnresta);
            Controls.Add(textBox1);
            Controls.Add(btnsuma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsuma;
        private TextBox textBox1;
        private Button btnresta;
        private Button btndos;
        private Button btnuno;
        private Button btncinco;
        private Button btncuatro;
        private Button btnocho;
        private Button btnsiete;
        private Button btncero;
        private Button btnCE;
        private Button btnseis;
        private Button btnC;
        private Button btntres;
        private Button btndivision;
        private Button btnmultiplicacion;
        private Button btnpunto;
        private Button btnnueve;
        private Button btnigual;
    }
}