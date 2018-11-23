﻿using System;
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

        encapsulamiento M3 = new encapsulamiento();
        private bool presionarboton = false;
        private void generar_Click(object sender, EventArgs e)
        {
            pantallaF.Rows.Clear();
            pantallaF.Refresh();
            presionarboton = true;
            if (string.IsNullOrEmpty(semilla.Text) || string.IsNullOrEmpty(constante.Text) || string.IsNullOrEmpty(iteracion.Text))
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
                promedio = promedio + R[i];
            }
            promedio = promedio / fin;
            M3.promedio = promedio;
            M3.limInfe = 0.5 - (1.96 * (1 / Math.Sqrt(12 * fin)));
            M3.limSupe = 0.5 + (1.96 * (1 / Math.Sqrt(12 * fin)));
            if (M3.limInfe < promedio && promedio < M3.limSupe)
            {
                M3.resp = "ACEPTA";
            }
            else
            {
                M3.resp = "RECHAZA";
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

        private void PruebaM_Click(object sender, EventArgs e)
        {
            if (presionarboton == true)
            {
                PruebaMedias PM3 = new PruebaMedias();
                PM3.prom.Text = Convert.ToString(M3.promedio);
                PM3.limInf.Text = Convert.ToString(M3.limInfe);
                PM3.limSup.Text = Convert.ToString(M3.limSupe);
                PM3.Respuesta.Text = M3.resp;
                PM3.metodo.Text = "(MULTIPLICADOR CONSTANTE)";
                PM3.Show();
            }
            else
            {
                MessageBox.Show("Presione primero el boton GENERAR");
            }
        }
    }
}
