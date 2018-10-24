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
    public partial class Metodo3 : Form
    {
        public Metodo3()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(constante.Text) || string.IsNullOrEmpty(iteracion.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }

            double[] Y;
            double[] X;
            double[] R;
            Y = new double[110];
            X = new double[110];
            R = new double[110];
            int fin = int.Parse(iteracion.Text);
            if (fin > 100)
            {
                MessageBox.Show("Máximo pedir 100 resultados");
                iteracion.Clear();
                return;
            }
            X[0] = double.Parse(semilla.Text);
            int constante1 =  int.Parse(constante.Text);

            for (int i = 0; i < fin; i++)
            {
                Y[i] = constante1 * X[i];
                string temp = Y[i].ToString();
                double largo = temp.Length;
                int ubi = Convert.ToInt32(Math.Floor(largo / 2) - 2);
                if (Y[i] == 0 || largo < 4)
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
            }
        }

        private void semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void constante_KeyPress(object sender, KeyPressEventArgs e)
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
