//Programa hecho para esis-unjbg codigo de estudiante: 2015-119046
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GUIaleatorio
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }


        private void bbnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
         * botones borrados minimzar y maximizar no funcionan bien
         * boton maximimzar su animacion no s eve bien
        private void bbnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bbnMaximizar.Visible = false;
            bbnRestaurar.Visible = true;
        }
        boton de restaurar oculto
        private void bbnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bbnRestaurar.Visible = false;
            bbnMaximizar.Visible = true;
        }*/

        private void bbnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btn1Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo1());
            btn1Met.BackColor = Color.FromArgb(0, 102, 204);
            btn2Met.BackColor = Color.FromArgb(26, 32, 40);
            btn3Met.BackColor = Color.FromArgb(26, 32, 40);
            btn4Met.BackColor = Color.FromArgb(26, 32, 40);
            btn5Met.BackColor = Color.FromArgb(26, 32, 40);
            btn6Met.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btn2Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo2());
            btn1Met.BackColor = Color.FromArgb(26, 32, 40);
            btn2Met.BackColor = Color.FromArgb(0, 102, 204);
            btn3Met.BackColor = Color.FromArgb(26, 32, 40);
            btn4Met.BackColor = Color.FromArgb(26, 32, 40);
            btn5Met.BackColor = Color.FromArgb(26, 32, 40);
            btn6Met.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btn3Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo3());
            btn1Met.BackColor = Color.FromArgb(26, 32, 40);
            btn2Met.BackColor = Color.FromArgb(26, 32, 40);
            btn3Met.BackColor = Color.FromArgb(0, 102, 204);
            btn4Met.BackColor = Color.FromArgb(26, 32, 40);
            btn5Met.BackColor = Color.FromArgb(26, 32, 40);
            btn6Met.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btn4Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo4());
            btn1Met.BackColor = Color.FromArgb(26, 32, 40);
            btn2Met.BackColor = Color.FromArgb(26, 32, 40);
            btn3Met.BackColor = Color.FromArgb(26, 32, 40);
            btn4Met.BackColor = Color.FromArgb(0, 102, 204);
            btn5Met.BackColor = Color.FromArgb(26, 32, 40);
            btn6Met.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btn5Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo5());
            btn1Met.BackColor = Color.FromArgb(26, 32, 40);
            btn2Met.BackColor = Color.FromArgb(26, 32, 40);
            btn3Met.BackColor = Color.FromArgb(26, 32, 40);
            btn4Met.BackColor = Color.FromArgb(26, 32, 40);
            btn5Met.BackColor = Color.FromArgb(0, 102, 204);
            btn6Met.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btn6Met_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new METODOS.Metodo6());
            btn1Met.BackColor = Color.FromArgb(26, 32, 40);
            btn2Met.BackColor = Color.FromArgb(26, 32, 40);
            btn3Met.BackColor = Color.FromArgb(26, 32, 40);
            btn4Met.BackColor = Color.FromArgb(26, 32, 40);
            btn5Met.BackColor = Color.FromArgb(26, 32, 40);
            btn6Met.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new EXTRA.Inicio());
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }
    }
}
