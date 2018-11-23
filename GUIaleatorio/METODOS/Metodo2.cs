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
    public partial class Metodo2 : Form
    {
        public Metodo2()
        {
            InitializeComponent();
        }

        private void Metodo2_Load(object sender, EventArgs e)
        {

        }

        private void semilla2_TextChanged(object sender, EventArgs e)
        {

        }
        encapsulamiento M2 = new encapsulamiento();
        private bool presionarboton = false;
        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            presionarboton = true;
            if (string.IsNullOrEmpty(semilla1.Text) || string.IsNullOrEmpty(semilla2.Text) || string.IsNullOrEmpty(iteracion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            var cadena = semilla1.Text;
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
            if (fin > 100)
            {
                MessageBox.Show("Máximo pedir 100 resultados");
                iteracion.Clear();
                return;
            }
            X[0] = double.Parse(semilla1.Text);
            X[1] = double.Parse(semilla2.Text);

            for (int i = 0; i < fin; i++)
            {
                Y[i] = X[i] * X[i + 1];
                string temp = Y[i].ToString();
                double largo = temp.Length;
                int ubi = Convert.ToInt32(Math.Floor(largo / 2) - 2);
                if (Y[i] == 0 || largo < 4)
                {
                    X[i + 2] = Convert.ToDouble(temp);
                }
                else
                {
                    X[i + 2] = Convert.ToDouble(temp.Substring(ubi, 4));
                }

                R[i] = X[i + 2] / 10000;

                int n = pantallaF.Rows.Add();
                pantallaF.Rows[n].Cells[0].Value = n + 1;
                pantallaF.Rows[n].Cells[1].Value = Y[i];
                pantallaF.Rows[n].Cells[2].Value = X[i + 2];
                pantallaF.Rows[n].Cells[3].Value = R[i];
                promedio = promedio + R[i];
            }
            promedio = promedio / fin;
            M2.promedio = promedio;
            M2.limInfe = 0.5 - (1.96 * (1 / Math.Sqrt(12 * fin)));
            M2.limSupe = 0.5 + (1.96 * (1 / Math.Sqrt(12 * fin)));
            if (M2.limInfe < promedio && promedio < M2.limSupe)
            {
                M2.resp = "ACEPTA";
            }
            else
            {
                M2.resp = "RECHAZA";
            }
        }

        private void semilla1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void semilla2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PruebaM_Click(object sender, EventArgs e)
        {
            if(presionarboton == true)
            {
                PruebaMedias PM2 = new PruebaMedias();
                PM2.prom.Text = Convert.ToString(M2.promedio);
                PM2.limInf.Text = Convert.ToString(M2.limInfe);
                PM2.limSup.Text = Convert.ToString(M2.limSupe);
                PM2.Respuesta.Text = M2.resp;
                PM2.metodo.Text = "(PRODUCTOS MEDIOS)";
                PM2.Show();
            }
            else
            {
                MessageBox.Show("Presione primero el boton GENERAR");
            }
        }
    }
}
