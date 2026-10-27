
using System;
using System.Windows.Forms;

namespace LojaGamesRetro
{
    public partial class TelaSplash : Form
    {
        private int progresso = 0;

        // Evento para avisar que o carregamento terminou
        public event EventHandler? SplashConcluida;

        public TelaSplash()
        {
            InitializeComponent();
        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {
            progresso = 0;
            progressBarSplash.Value = 0;

            lblCarregamento.Text = "INICIANDO SISTEMA... 0%";

            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (progresso < 100)
            {
                progresso = Math.Min(progresso + 2, 100);

                progressBarSplash.Value = progresso;

                lblCarregamento.Text =
                    $"INICIANDO SISTEMA... {progresso}%";
            }
            else
            {
                timerSplash.Stop();

                lblCarregamento.Text = "CARREGAMENTO CONCLUÍDO!";

                SplashConcluida?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
