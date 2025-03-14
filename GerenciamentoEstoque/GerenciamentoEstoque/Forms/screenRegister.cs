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
    public partial class screenRegister: Form
    {
        // Transições de tela Registre-se -> Login

        /* screenLogin formLogin = new screenLogin();
             this.Close();  
             formLogin.Show(); */

        public screenRegister()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            // Transições de tela Registre-se -> Login

            screenLogin formLogin = new screenLogin();
            this.Close();
            formLogin.Show();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
