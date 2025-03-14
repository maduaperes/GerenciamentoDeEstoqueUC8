using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEstoque.Forms
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            screenVendedor formVendedor = new screenVendedor();
            formVendedor.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            screenHomeADM formAdm = new screenHomeADM();
            formAdm.Show();
            this.Hide();
        }
    }
}
