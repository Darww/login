namespace calculadora_basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DECLARANDO VARIABLES
        string operador = "";
        double num1 = 0;
        double num2 = 0;

        //Programamos el boton para borrar todo, reseateamos los varoles que tienen esas variables cuando se le da el boton de limpiar
        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //programamos el boton para borrar un caracter de uno en uno
        // si hay un caracter en mi texbox entonces qeuiero que ese caracter sea cero
        
        private void btnC_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        //al cero que esta en el texbox se le sumara uno
        //si en mi texbox hay un caracter que es igual a cero, quiero que se ponga en espacion en blanco
        //entonces en mi texbox sera igual a lo que ya tiene mas el numero uno
        private void btnuno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
        }

        //si texbox ya tiene un cero, solo que retorne
        // pero si fuera un numero diferente de cero que se le sumen mas ceros
        private void btncero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        //quiero que mi variable operador tenga un valor y sera suma
        //num1 sera igual a una conversion de tipo decimal de texbox
        // y quiero que se limpie la pantalla despues que se le de a sumar y aparezca el numero cero
        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        //num2 sera igual a una conversion de tipo decimal de mi texbox
        //switch para identificar el valor de mi variable operador
        //cuando el operador sea de tipo suma: en mi texbox aparecera el resultado de lo siguiente num1 + num2
        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{num1 + num2}";
                    break;

                case "-":
                    textBox1.Text = $"{num1 - num2}";
                    break;

                case "*":
                    textBox1.Text = $"{num1 * num2}";
                    break;

                case "/":
                    textBox1.Text = $"{num1 / num2}";
                    break;
            }
        }
    }

}