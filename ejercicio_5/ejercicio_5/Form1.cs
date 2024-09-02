using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        //- Crear un programa que calcule el número de CDs necesarios para hacer una copia de seguridad de la
        //información almacenada en un disco rígido cuya capacidad se conoce.Considerar que el disco duro está
        //lleno de información, además expresado en Gigabytes. Un CD virgen tiene 700 Megabytes de capacidad y
        //un Gigabyte es igual a 1024 Megabytes.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double capacidadGB = double.Parse(txtCapacidad.Text);
                const double capacidadCDMB = 700;
                const double conversionGBtoMB = 1024;
                double capacidadMB = capacidadGB * conversionGBtoMB;
                double numeroCDs = Math.Ceiling(capacidadMB / capacidadCDMB);

                lblResultado.Text = $"Número de CDs necesarios: {numeroCDs}";
            }
            catch (FormatException)
            {
 
                lblResultado.Text = "Por favor, ingrese un número válido.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
