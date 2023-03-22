using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class RestoDivisao : Form
    {
        public RestoDivisao()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txBxDividendo.Text);
            int divisor = Convert.ToInt32(txBxDivisor.Text);
            int resto = dividendo % divisor;
            txtRestoDaDivisao.Text = resto.ToString();

        }

        private void txtRestoDaDivisao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxDivisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBxDividendo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
