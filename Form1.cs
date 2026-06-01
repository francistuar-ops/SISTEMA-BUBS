using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistemapubs
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(
        @"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=Sistemapubs;
        Integrated Security=True");

        int intentos = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string clave = textBox2.Text;

            if (usuario == "admin" && clave == "123")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                intentos--;

                MessageBox.Show("Usuario o contraseña incorrectos\nIntentos restantes: " + intentos);

                if (intentos <= 0)
                {
                    MessageBox.Show("Se acabaron los intentos permitidos");
                    Application.Exit();
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" &&
    txtClave.Text == "123")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                intentos++;

                MessageBox.Show(
                    "Usuario o contraseña incorrectos\nIntento "
                    + intentos + " de 3");

                if (intentos >= 3)
                {
                    MessageBox.Show(
                        "Ha superado los 3 intentos permitidos");

                    Application.Exit();
                }
            }
        }
    }
}