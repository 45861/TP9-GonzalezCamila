using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        //Crear un programa donde se muestre la suma, resta división y multiplicación entre dos números que
        //deberá ingresar el usuario.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(textBox1.Text, out numero1) && double.TryParse(textBox2.Text, out numero2))
            {
                // operaciones
                double suma = numero1 + numero2;
                double resta = numero1 - numero2;
                double multiplicacion = numero1 * numero2;
                double division = numero2 != 0 ? numero1 / numero2 : double.NaN;

                // resultados
                labelsuma.Text = $"Suma: {suma}";
                labelresta.Text = $"Resta: {resta}";
                labelmultiplicacion.Text = $"Multiplicación: {multiplicacion}";
                labeldivision.Text = numero2 != 0 ? $"División: {division}" : "División: Error (división por cero)";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        
    }
}
