using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        //Crear un programa donde el usuario ingrese una letra y diga si es una vocal.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {        
            string letra = txtLetra.Text;

            if (letra.Length == 1)
            {
                char letraMinusc = char.ToLower(letra[0]);

                // Comprueba si la letra es una vocal
                if (letraMinusc == 'a' || letraMinusc == 'e' || letraMinusc == 'i' || letraMinusc == 'o' || letraMinusc == 'u')
                {
                    lblResultado.Text = $"{letra} es una vocal.";
                }
                else
                {
                    lblResultado.Text = $"{letra} no es una vocal.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese una sola letra.";
            }
        }
    }
}
