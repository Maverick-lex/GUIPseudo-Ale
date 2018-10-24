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
    public partial class Metodo6 : Form
    {
        public Metodo6()
        {
            InitializeComponent();
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(semilla.Text))
            {
                MessageBox.Show("Invalido");
                return;
            }
            int n = VectSeed.Rows.Add();
            VectSeed.Rows[n].Cells[0].Value = semilla.Text;
            semilla.Clear();*/
        }

        private void semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
                if (string.IsNullOrEmpty(semilla.Text))
                {
                    MessageBox.Show("Invalido");
                    return;
                }
                int n = VectSeed.Rows.Add();
                VectSeed.Rows[n].Cells[0].Value = semilla.Text;
                semilla.Clear();
                
                VectSeed.CurrentCell = VectSeed[0, n];
                e.Handled = true;
            }
        }

        private void VectSeed_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
 
        }

        private void VectSeed_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void generar_Click(object sender, EventArgs e)
        {

            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            if (string.IsNullOrEmpty(m.Text) || string.IsNullOrEmpty(iteracion.Text) || VectSeed.Rows.Count == 0)
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            int cont = 0;
            decimal[] X;
            decimal[] R;
            X = new decimal[110];
            R = new decimal[110];

                //Recorre las filas..
                foreach (DataGridViewRow fila in VectSeed.Rows)
            {
                String valor = fila.Cells[0].Value.ToString();
                X[cont] = Convert.ToInt32(valor);
                cont++;
            }
            //MessageBox.Show(X[cont-1].ToString());

            int fin = int.Parse(iteracion.Text);
            if (fin > 100)
            {
                MessageBox.Show("Máximo pedir 100 resultados");
                iteracion.Clear();
                return;
            }
            int m1 = int.Parse(m.Text);
            for (int i = cont; i < (fin + cont); i++)
            {
                X[i] = (X[i-1] + X[i - cont]) % m1;
                R[i] = soporte.NumericExtensions.Truncate((X[i] / (m1 - 1)), 4);
                int n = pantallaF.Rows.Add();
                pantallaF.Rows[n].Cells[0].Value = n + 1;
                pantallaF.Rows[n].Cells[1].Value = X[i];
                pantallaF.Rows[n].Cells[2].Value = R[i];
            }
        }

        private void Xiclear_Click(object sender, EventArgs e)
        {
            VectSeed.Rows.Clear();
            VectSeed.Refresh();
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

        private void VectSeed_KeyDown(object sender, KeyEventArgs e)
        {
    
        }
    }
}
