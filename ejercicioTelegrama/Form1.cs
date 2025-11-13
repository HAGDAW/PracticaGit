using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; // ERROR 1: Inicializamos a 'o' para que por defecto sea ordinario
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // ¿Telegrama urgente?
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }


            string[] palabras = textoTelegrama.Split(' ');
            numPalabras = palabras.Length;

            // Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {

                    // Coste base (2.5) + 0.5 por cada palabra extra
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            // Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }

            txtPrecio.Text = coste.ToString() + " euros";
        }
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
        }
        private void lblCoste_Click(object sender, EventArgs e)
        {

        }
    }
    }

