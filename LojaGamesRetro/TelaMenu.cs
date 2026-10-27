
using System;
using System.Windows.Forms;

namespace LojaGamesRetro
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            lblConteudo.Text = "Bem-vindo à Loja de Games Retro!";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblConteudo.Text = "Bem-vindo à Loja de Games Retro!";
        }

        private void btnCardsJogos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "A tela de Cards de Jogos será implementada em breve.",
                "Cards de Jogos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "A tela de Relatório de Vendas será implementada em breve.",
                "Relatório de Vendas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
