namespace login
{
    partial class abonar
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
            lbcantidad = new Label();
            SuspendLayout();
            // 
            // lbcantidad
            // 
            lbcantidad.AutoSize = true;
            lbcantidad.Location = new Point(67, 49);
            lbcantidad.Name = "lbcantidad";
            lbcantidad.Size = new Size(72, 20);
            lbcantidad.TabIndex = 0;
            lbcantidad.Text = "Cantidad:";
            // 
            // abonar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbcantidad);
            Name = "abonar";
            Text = "abonar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbcantidad;
    }
}