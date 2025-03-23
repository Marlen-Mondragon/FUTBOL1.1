using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Futbol
{
    public partial class Datos : Form
    {   
        public Datos()
        {            
            InitializeComponent();
            MostarDatos();        
        }
        private void MostarDatos()
        {
            if (Form1.listaDatos.Count > 0 && Form1.listbImagenes.Count > 0)
            {
                label4.Text = Form1.listaDatos[0].ToString();
                label5.Text = Form1.listaDatos[1].ToString();
                label11.Text = Form1.listaDatos[2].ToString();
                label12.Text = Form1.listaDatos[3].ToString();
                label13.Text = Form1.listaDatos[4].ToString();
                label14.Text = Form1.listaDatos[5].ToString();
                label15.Text = Form1.listaDatos[6].ToString();

                pictureBox1.Image = (Image)Form1.listbImagenes[0];
                pictureBox2.Image = (Image)Form1.listbImagenes[1];
            }
        }
        private void Datos_Load(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
