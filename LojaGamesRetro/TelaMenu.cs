using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojaGamesRetro
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            TelaCardsJogos telaJogos = new TelaCardsJogos();

            telaJogos.FormClosed += (s, args) => this.Show();

            this.Hide();
            telaJogos.Show();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            TelaRelatorioVendas telaRelatorio = new TelaRelatorioVendas();

            telaRelatorio.FormClosed += (s, args) => this.Show();

            this.Hide();
            telaRelatorio.Show();
        }
    }
}