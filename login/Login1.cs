using System.Runtime.Intrinsics.X86;

namespace login
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btiniciar_MouseEnter(object sender, EventArgs e)
        {
            //cambiamos de color del boton al poner el cursor
            btiniciar.ForeColor = Color.White;
        }

        private void btiniciar_MouseLeave(object sender, EventArgs e)
        {
            //cambiamos de color del boton cuando sale el cursor
            btiniciar.ForeColor = Color.Black;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtcontrase�a.Text.Length == 8)
            {
                MessageBox.Show("solo se aceptan 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if ((e.KeyChar >= 58 && e.KeyChar <= 255))
                e.Handled = true;
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtcontrase�a.Text = "";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void olvidadocontra_MouseEnter(object sender, EventArgs e)
        {
            olvidadocontra.ForeColor = Color.Red;
        }

        private void olvidadocontra_MouseLeave(object sender, EventArgs e)
        {
            olvidadocontra.ForeColor = Color.Blue;
        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            //imagen ocultar la mandamos al frente 
            pbOcultar.BringToFront();
            //mostramos la contrase�a
            txtcontrase�a.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            //imagen mostrar la mandamos al frente
            pbmostrar.BringToFront();
            //ocultamos la contrase�a
            txtcontrase�a.PasswordChar = '*';
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {

            string contrase�a = txtcontrase�a.Text;
            string usuario = txtusuario.Text;

            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtcontrase�a.Text))
            {
                MessageBox.Show("Por favor! Ingrese usuario y contrase�a", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Los campos est�n vac�os, no se realizar� ninguna acci�n.
            }
            else
            {
                // Los campos no est�n vac�os, aqu� puedes realizar la acci�n que necesites.
                formulario2 frm = new formulario2();
                frm.Show();

            }



        }

    }
}