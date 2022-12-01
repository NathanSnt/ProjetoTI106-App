using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraApp
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
        }
    }
}
