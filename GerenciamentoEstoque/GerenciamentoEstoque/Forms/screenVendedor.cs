using FontAwesome.Sharp;
using GerenciamentoEstoque.Pages;
using GerenciamentoEstoque.Pages.Seller;
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
    public partial class screenVendedor: Form
    {
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Construtor
        public screenVendedor()
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Ativação da aba Pedidos
            pedidosVendedor1.Visible = true;
            estoqueVendedor1.Visible = false;
            produtosVendedor1.Visible = false; 

            activateButton(sender, RGBColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Ativação da aba Produtos
            pedidosVendedor1.Visible = false;
            estoqueVendedor1.Visible = false;
            produtosVendedor1.Visible = true; 

            activateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Ativação da aba Estoque
             pedidosVendedor1.Visible = false;
            estoqueVendedor1.Visible = true;
            produtosVendedor1.Visible = false; 

            activateButton(sender, RGBColors.color4);
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
