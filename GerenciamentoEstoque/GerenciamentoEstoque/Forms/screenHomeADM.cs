using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GerenciamentoEstoque.Forms;

namespace GerenciamentoEstoque
{
    public partial class screenHomeADM: Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Construtor
        public screenHomeADM()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        //Estrutura de cores RGB

        private struct RGBColors
        {
            // cores baseadas na paleta de cores do tema (LOGO)

            public static Color color1 = Color.FromArgb(5, 166, 136);  // Cor do botão
            public static Color color2 = Color.FromArgb(7, 217, 178); // Cor do botão
            public static Color color3 = Color.FromArgb(133, 242, 231);  // Cor do botão
            public static Color color4 = Color.FromArgb(242, 145, 145);  // Cor do botão
            public static Color color5 = Color.FromArgb(56, 86, 96); // Cor do botão
            public static Color color6 = Color.FromArgb(33, 53, 59); // Cor do botão
        }

        //Métodos
        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();

                //button

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(161, 175, 185); // Quando o botão é ativado, a cor de fundo é alterada para cinza
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Esquerda da borda do botão

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(13, 13, 13); // Quando o botão é desativado, a cor de fundo é alterada para preto
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Ativação da aba Dashboard
             dashboard1.Visible = true;
             clientes1.Visible = false;
             produtos1.Visible = false;
             estoque1.Visible = false;
             pedidos1.Visible = false;
             usuarios1.Visible = false; 

            activateButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Ativação da aba Pedidos
             dashboard1.Visible = false;
             clientes1.Visible = false;
             produtos1.Visible = false;
             estoque1.Visible = false;
             pedidos1.Visible = true; ;
             usuarios1.Visible = false; 

            activateButton(sender, RGBColors.color2);
         }

         private void iconButton3_Click(object sender, EventArgs e)
         {
            // Ativação da aba Produtos

            dashboard1.Visible = false;
            clientes1.Visible = false;
            produtos1.Visible = true;
            estoque1.Visible = false;
            pedidos1.Visible = false;
            usuarios1.Visible = false; 

            activateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Ativação da aba Estoque

            dashboard1.Visible = false;
            clientes1.Visible = false;
            produtos1.Visible = false;
            estoque1.Visible = true;
            pedidos1.Visible = false;
            usuarios1.Visible = false; 

            activateButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            // Ativação da aba Clientes
             dashboard1.Visible = false;
             clientes1.Visible = true;
             produtos1.Visible = false;
             estoque1.Visible = false;
             pedidos1.Visible = false;
             usuarios1.Visible = false; 

            activateButton(sender, RGBColors.color5);
         }

         private void iconButton6_Click(object sender, EventArgs e)
         {
            // Ativação da aba Usuários

             dashboard1.Visible = false;
             clientes1.Visible = false;
             produtos1.Visible = false;
             estoque1.Visible = false;
             pedidos1.Visible = false;
             usuarios1.Visible = true; 

            activateButton(sender, RGBColors.color6);
         }

         private void iconButton7_Click(object sender, EventArgs e)
         {
             //teste sem banco de dados
             Form1 formtest = new Form1();
             formtest.Show();
             this.Hide();

             /* screenLogin formLogin = new screenLogin();
             formLogin.Show();
             this.Close(); */
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
        }

    }
    
}
