
using System;
using System.Windows.Forms;
using LojaGamesRetro.Views;

namespace LojaGamesRetro
{
    public partial class FrmTelaMenu : Form
    {
        private FrmTelaCardsJogos? telaJogos;
        private FrmTeladeRelatorio? telaRelatorio;

        public FrmTelaMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Nenhuma ação necessária.
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            // Evita abrir outra tela de jogos se ela já estiver aberta.
            if (telaJogos != null && !telaJogos.IsDisposed)
            {
                telaJogos.Activate();
                return;
            }

            telaJogos = new FrmTelaCardsJogos();

            telaJogos.FormClosed += (s, args) =>
            {
                telaJogos = null;
                this.Show();
                this.Activate();
            };

            this.Hide();
            telaJogos.Show();
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            // Evita abrir outra tela de relatório se ela já estiver aberta.
            if (telaRelatorio != null && !telaRelatorio.IsDisposed)
            {
                telaRelatorio.Activate();
                return;
            }

            telaRelatorio = new FrmTeladeRelatorio();

            telaRelatorio.FormClosed += (s, args) =>
            {
                telaRelatorio = null;
                this.Show();
                this.Activate();
            };

            this.Hide();
            telaRelatorio.Show();
        }
    }
}
