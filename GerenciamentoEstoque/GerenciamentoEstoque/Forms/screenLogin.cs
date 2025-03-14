using GerenciamentoEstoque.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEstoque
{
    public partial class screenLogin: Form
    {
         // transições de tela Login -> Registre-se

         /* screenRegister formRegister = new screenRegister();
            this.Hide();
            formRegister.Show(); */

        public screenLogin()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

            // transições de tela Login -> Registre-se

             screenRegister formRegister = new screenRegister();
             this.Hide();
             formRegister.Show(); 

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //teste sem banco de dados
            Form1 formtest = new Form1();
            formtest.Show();
            this.Hide();


            /* screenHomeADM formHome = new screenHomeADM();
            this.Hide();
            formHome.Show(); */
        }
    }
}
