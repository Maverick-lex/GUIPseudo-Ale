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

        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(k.Text) || string.IsNullOrEmpty(g.Text) || string.IsNullOrEmpty(iteracion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            decimal[] X;
            decimal[] R;
            X = new decimal[110];
            R = new decimal[110];
            int fin = int.Parse(iteracion.Text);
            if (fin > 100)
            {
                MessageBox.Show("Máximo pedir 100 resultados");
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
    }
}
