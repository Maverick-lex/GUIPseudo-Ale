using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIaleatorio.METODOS
{
    public partial class Metodo1 : Form
    {
        public Metodo1()
        {
            InitializeComponent();
        }
        encapsulamiento M1 = new encapsulamiento();
        private bool presionarboton = false;
        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            presionarboton = true;
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(iteracion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            var cadena = semilla.Text;
            if (cadena.Length < 4)
            {
                MessageBox.Show("El contenido del textbox debe de tener  4 caracteres", "Error");
                return;
            }
         

            double[] Y;
            double[] X;
            double[] R;
            Y = new double[1100];
            X = new double[1100];
            R = new double[1100];
            double promedio = 0;
            int fin = int.Parse(iteracion.Text);
            if (fin > 1000)
            {
                MessageBox.Show("Máximo pedir 1000 resultados");
                iteracion.Clear();
                return;
            }
            X[0] = double.Parse(semilla.Text);
            for (int i = 0; i < fin; i++)
            {
                Y[i] = Math.Pow(X[i], 2);
                string temp = Y[i].ToString();
                double largo = temp.Length;
                int ubi = Convert.ToInt32(Math.Floor(largo / 2) - 2);
                if(Y[i]==0||largo<4)
                {
                    X[i + 1] = Convert.ToDouble(temp);
                }
                else
                {
                    X[i + 1] = Convert.ToDouble(temp.Substring(ubi, 4));
                }
                
                R[i] = X[i + 1] / 10000;

                int n = pantallaF.Rows.Add();
                pantallaF.Rows[n].Cells[0].Value = n + 1;
                pantallaF.Rows[n].Cells[1].Value = Y[i];
                pantallaF.Rows[n].Cells[2].Value = X[i + 1];
                pantallaF.Rows[n].Cells[3].Value = R[i];
                promedio = promedio + R[i];
            }
            promedio = promedio / fin;
            M1.promedio = promedio;
            M1.limInfe = 0.5 - (1.96 * (1 / Math.Sqrt(12 * fin)));
            M1.limSupe = 0.5 + (1.96 * (1 / Math.Sqrt(12 * fin)));
            if(M1.limInfe < promedio && promedio < M1.limSupe)
            {
                M1.resp = "ACEPTA";
            }
            else
            {
                M1.resp = "RECHAZA";
            }
        }

        private void CuadradosMedios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void iteracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void semilla_TextChanged(object sender, EventArgs e)
        {

        }

        public void PruebaM_Click(object sender, EventArgs e)
        {
            if (presionarboton == true)
            {
                PruebaMedias PM1 = new PruebaMedias();
                PM1.prom.Text = Convert.ToString(M1.promedio);
                PM1.limInf.Text = Convert.ToString(M1.limInfe);
                PM1.limSup.Text = Convert.ToString(M1.limSupe);
                PM1.Respuesta.Text = M1.resp;
                PM1.metodo.Text = "(CUADRADOS MEDIOS)";
                PM1.Show();
            }
            else
            {
                MessageBox.Show("Presione primero el boton GENERAR");
            }
        }
    }
}
