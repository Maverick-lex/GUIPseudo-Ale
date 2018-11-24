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
    public partial class Metodo5 : Form
    {
        public Metodo5()
        {
            InitializeComponent();
        }
        encapsulamiento M5 = new encapsulamiento();
        private bool presionarboton = false;
        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            presionarboton = true;
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(k.Text) || string.IsNullOrEmpty(g.Text) || string.IsNullOrEmpty(iteracion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            var cadena = semilla.Text;
            
            decimal[] X;
            decimal[] R;
            X = new decimal[1100];
            R = new decimal[1100];
            decimal promedio = 0;
            int fin = int.Parse(iteracion.Text);
            if (fin > 1000)
            {
                MessageBox.Show("Máximo pedir 1000 resultados");
                iteracion.Clear();
                return;
            }
            X[0] = decimal.Parse(semilla.Text);
            int k1 = int.Parse(k.Text);
            double g1 = double.Parse(g.Text);

            int a = 5 + 8 * k1;
            int m = Convert.ToInt32(Math.Pow(2, g1));
            abox.Text = a.ToString();
            mbox.Text = m.ToString();

            for (int i = 0; i < fin; i++)
            {
                X[i + 1] = (a * X[i]) % m;
                R[i] = soporte.NumericExtensions.Truncate((X[i + 1] / (m - 1)), 4);
                int n = pantallaF.Rows.Add();
                pantallaF.Rows[n].Cells[0].Value = n + 1;
                pantallaF.Rows[n].Cells[1].Value = X[i + 1];
                pantallaF.Rows[n].Cells[2].Value = R[i];
                promedio = promedio + R[i];
            }
            promedio = promedio / fin;
            M5.promedio = Convert.ToDouble(promedio);
            M5.limInfe = 0.5 - (1.96 * (1 / Math.Sqrt(12 * fin)));
            M5.limSupe = 0.5 + (1.96 * (1 / Math.Sqrt(12 * fin)));
            if (M5.limInfe < M5.promedio && M5.promedio < M5.limSupe)
            {
                M5.resp = "ACEPTA";
            }
            else
            {
                M5.resp = "RECHAZA";
            }
        }

        private void semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void k_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void g_KeyPress(object sender, KeyPressEventArgs e)
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
            if (presionarboton == true)
            {
                PruebaMedias PM5 = new PruebaMedias();
                PM5.prom.Text = Convert.ToString(M5.promedio);
                PM5.limInf.Text = Convert.ToString(M5.limInfe);
                PM5.limSup.Text = Convert.ToString(M5.limSupe);
                PM5.Respuesta.Text = M5.resp;
                PM5.metodo.Text = "(CONGRUENCIAL MULTIPLICATIVO)";
                PM5.Show();
            }
            else
            {
                MessageBox.Show("Presione primero el boton GENERAR");
            }
        }
    }
}
