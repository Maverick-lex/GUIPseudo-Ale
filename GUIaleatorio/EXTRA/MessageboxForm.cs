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
    public partial class MessageboxForm : Form
    {
        public MessageboxForm()
        {
            InitializeComponent();
        }

        private void MessageboxForm_Load(object sender, EventArgs e)
        {
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void OK_Click(object sender, EventArgs e)
        {
           /* this.Close();*/
        }
    }
}
