using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGitHub._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            string[] palabras = textoTelegrama.Split(' ');
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (palabras.Length <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * palabras.Length;
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (palabras.Length <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (palabras.Length - 10);
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
