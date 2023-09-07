using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{

    public partial class formulario2 : Form
    {
        public formulario2()
        {
            InitializeComponent();
        }

        private void mene2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            return;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txttarjeta.Text.Length == 12)
            {
                MessageBox.Show("solo se aceptan 12 caracteres de su tarjeta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if ((e.KeyChar >= 58 && e.KeyChar <= 255))
                e.Handled = true;
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txttarjeta.Text = "";
        }

        private void btnabonar_Click(object sender, EventArgs e)
        {
            string numerotarjeta = txttarjeta.Text;
            string nombre = txtnombre.Text;


            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txttarjeta.Text))
            {
                MessageBox.Show("Por favor! Ingrese nombre completo y numero de tarjeta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Los campos están vacíos, no se realizará ninguna acción.
            }
            else
            {


                //// Los campos no están vacíos, aquí puedes realizar la acción que necesites.
                //abonar frm = new abonar();
                //frm.Show();

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            double tarjeta = 100;
            double cantidadaretirar;

            if (double.TryParse(txtCantidad.Text, out cantidadaretirar))
            {
                if (cantidadaretirar <= 0)
                {
                    MessageBox.Show("La cantidad a retirar debe ser mayor que cero.");
                }
                else if (cantidadaretirar > tarjeta)
                {
                    MessageBox.Show("Fondos insuficientes para el retiro.");
                }
                else
                {
                    tarjeta = Convert.ToDouble(txtotal.Text);
                    cantidadaretirar = Convert.ToDouble(txtotal.Text);
                    tarjeta -= cantidadaretirar;
                    MessageBox.Show("Retiro exitoso");                   
                    txtotal = $"{tarjeta - cantidadaretirar}";
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad valida.");
            }
        }
    }
}

