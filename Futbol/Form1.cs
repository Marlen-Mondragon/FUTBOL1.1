using System.Collections;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Futbol
{
    public partial class Form1 : Form
    {
        public static ArrayList listaDatos = new ArrayList();
        public static ArrayList listbImagenes = new ArrayList();
        EquipoFutbol miEquipo = null;
        Guardameta gm = null;

        // imagenes 
        OpenFileDialog archivo1 = new OpenFileDialog();
        OpenFileDialog archivo2 = new OpenFileDialog();
        internal EquipoFutbol MiEquipo { get => miEquipo; set => miEquipo = value; }
        internal Guardameta Gm { get => gm; set => gm = value; }

        public Form1()
        {
            
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            archivo1.Filter = "(*.png; *.jpg) | *.png; *.jpg";
            if (archivo1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(archivo1.FileName);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
          
            archivo2.Filter = "(*.png; *.jpg) | *.png; *.jpg";
            if (archivo2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(archivo2.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Datos datos = new Datos();
            datos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miEquipo = new EquipoFutbol();
            gm = new Guardameta();

            miEquipo.NombreEquipo = textBox1.Text;
            miEquipo.Puntos = int.Parse(textBox3.Text);
            miEquipo.Escudo = pictureBox1.Image;

            gm.Nombre = textBox7.Text;
            gm.Edad = int.Parse(textBox5.Text);
            gm.Numero = int.Parse(textBox2.Text);
            gm.Posicion = textBox6.Text;
            gm.Estatura = int.Parse(textBox4.Text);
            gm.Foto = pictureBox2.Image;

            miEquipo.Guardameta = gm;

            listaDatos.Clear();
            listaDatos.Add(miEquipo.NombreEquipo);
            listaDatos.Add(miEquipo.Puntos);
            listaDatos.Add(gm.Nombre);
            listaDatos.Add(gm.Edad);
            listaDatos.Add(gm.Numero);
            listaDatos.Add(gm.Posicion);
            listaDatos.Add(gm.Estatura);

            listbImagenes.Clear();
            listbImagenes.Add(miEquipo.Escudo);
            listbImagenes.Add(gm.Foto);

            MessageBox.Show("Datos guardados correctamente. ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
