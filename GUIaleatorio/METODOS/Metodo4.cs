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
    public partial class Metodo4 : Form
    {
        public Metodo4()
        {
            InitializeComponent();
        }
        encapsulamiento M4 = new encapsulamiento();
        private bool presionarboton = false;
        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            presionarboton = true;
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(a.Text) || string.IsNullOrEmpty(c.Text) || string.IsNullOrEmpty(m.Text) || string.IsNullOrEmpty(iteracion.Text))
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
            decimal[] X;
            decimal[] R;
            X = new decimal[1100];
            R = new decimal[1100];
            decimal promedio = 0;
            int fin = int.Parse(iteracion.Text);
            if (fin > 100)
            {
                MessageBox.Show("Máximo pedir 100 resultados");
                iteracion.Clear();
                return;
            }
            X[0] = decimal.Parse(semilla.Text);
            int a1 = int.Parse(a.Text);
            int c1 = int.Parse(c.Text);
            int m1 = int.Parse(m.Text);

            for (int i = 0; i < fin; i++)
            {
                X[i + 1] = (a1 * X[i] + c1) % m1;
                R[i] = soporte.NumericExtensions.Truncate((X[i + 1] / (m1 - 1)), 4);
                int n = pantallaF.Rows.Add();
                pantallaF.Rows[n].Cells[0].Value = n + 1;
                pantallaF.Rows[n].Cells[1].Value = X[i + 1];
                pantallaF.Rows[n].Cells[2].Value = R[i];
                promedio = promedio + R[i];
            }
            promedio = promedio / fin;
            M4.promedio = Convert.ToDouble(promedio);
            M4.limInfe = 0.5 - (1.96 * (1 / Math.Sqrt(12 * fin)));
            M4.limSupe = 0.5 + (1.96 * (1 / Math.Sqrt(12 * fin)));
            if (M4.limInfe < M4.promedio && M4.promedio < M4.limSupe)
            {
                M4.resp = "ACEPTA";
            }
            else
            {
                M4.resp = "RECHAZA";
            }

        }

        private void semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void m_KeyPress(object sender, KeyPressEventArgs e)
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
                PruebaMedias PM4 = new PruebaMedias();
                PM4.prom.Text = Convert.ToString(M4.promedio);
                PM4.limInf.Text = Convert.ToString(M4.limInfe);
                PM4.limSup.Text = Convert.ToString(M4.limSupe);
                PM4.Respuesta.Text = M4.resp;
                PM4.metodo.Text = "(ALGORITMO LINEAL)";
                PM4.Show();
            }
            else
            {
                MessageBox.Show("Presione primero el boton GENERAR");
            }
        }
    }
}

namespace soporte
{
    public static class NumericExtensions 
    {
        public static decimal Truncate(this decimal value, int decimalPlaces)
        {
            decimal integralValue = Math.Truncate(value);
            decimal fraction = value - integralValue;
            int factor = (int)Math.Pow(10, decimalPlaces);
            decimal truncatedFraction = Math.Truncate(fraction * factor) / factor;
            decimal result = integralValue + truncatedFraction;
            return result;
        }
    }
}
