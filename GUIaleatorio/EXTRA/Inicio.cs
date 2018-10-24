using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIaleatorio.EXTRA
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            MessageboxForm test = new MessageboxForm();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            { }
        }
    }
}
