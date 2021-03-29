using carrito.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrito
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        clsClass1 carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1crear_Click(object sender, EventArgs e)
        {
            // Crear el carrito
            carrito = new clsClass1("Mazda", 150);

            carrito.color = "Verde";




        }
        private void From1_Load(object sender, EventArgs e)
        {

        }
        private void buttonEncender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.Encendermotor();
            labelDatos.Text = respuesta;


        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.estaencendido())
            {
                labelVelocidad.Text = carrito.acelerar();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca} esta apagado");
            }


        }
       

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito.estaencendido())
            { 
                labelFrenar.Text = carrito.frenare();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca}esta apagado");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            labelApagar.Text = carrito.Apagarmotor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         //Reproductor
        private void buttoncargar_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;


            }
           
        }

        private void buttonreproducir_Click(object sender, EventArgs e)
        {
            
            if (carrito.estaencendido())
            {
                axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca}esta apagado");
            }
        }

        private void buttonparar_Click(object sender, EventArgs e)
        {
            
            if (carrito.estaencendido())
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca} esta apagado");
            }
        }

        private void buttonpausar_Click(object sender, EventArgs e)
        {
            
            if (carrito.estaencendido())
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                
            }
           
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca} esta apagado");
            }
        }

        //Luces de Emergencia
        private void buttonviaizquierda_Click(object sender, EventArgs e)
        {
            if (carrito.estaencendido())
            {
                labelizquierda.Text = carrito.direizqui();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca} esta apagado");
            }

        }

        private void labelderecha_Click(object sender, EventArgs e)
        {

        }

        private void buttonviaderecha_Click(object sender, EventArgs e)
        {
            if (carrito.estaencendido())
            {
                labelderecha.Text = carrito.diredere();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.marca} esta apagado");
            }
        }
    }
}
