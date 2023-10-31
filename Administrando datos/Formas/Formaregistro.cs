using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrando_datos.Formas
{
    public partial class Formaregistro : Form
    {
        public Formaregistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtNombre.Text;
            string APELLIDO = txtApellido.Text;
            string contraseña = textBox2.Text;
            string GMAIL = textBox3.Text;
            string TELEFONO = textBox1.Text;
            string ESTADO = comboBox1.Text;
            string GENERO = checkBox1.Text;
            string GENERO2 = checkBox2.Text;

            string REGION = listBox1.Text;



            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(APELLIDO) || string.IsNullOrEmpty(GMAIL) || string.IsNullOrEmpty(GENERO) || string.IsNullOrEmpty(TELEFONO) || string.IsNullOrEmpty(ESTADO) || string.IsNullOrEmpty(REGION) || string.IsNullOrEmpty(GENERO2))
            {
                MessageBox.Show(" complete todos los campos.");
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.");

            }


            else
            {


                Administración_de_Estudiantes home = new Administración_de_Estudiantes();
                home.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();

        }

        private void Formaregistro_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

    }
}