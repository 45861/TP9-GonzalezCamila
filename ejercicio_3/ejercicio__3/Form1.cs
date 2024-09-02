using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio__3
{
    public partial class Form1 : Form
    {
        //Crear un programa donde el usuario ingrese dos números (a y b), el mismo deberá mostrar el resultado
        //de las operaciones(a+b)*(a-b) y el resultado de la operación a2-b2
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
           
            double a, b;

            if (double.TryParse(textBoxA.Text, out a) && double.TryParse(textBoxB.Text, out b))
            {
                // operaciones
                double resultado1 = (a + b) * (a - b);
                double resultado2 = (a * a) - (b * b ); // a^2 - b^2

                // resultados
                labelResultado1.Text = $"Resultado 1: {(a + b)} * {(a - b)} = {resultado1}";
                labelResultado2.Text = $"Resultado 2: {a}^2 - {b}^2 = {resultado2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }
    }
}
