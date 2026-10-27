
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Views
{
    public partial class FrmTeladeRelatorio : Form
    {
        private readonly ServicesJogos servicoJogos =
            new ServicesJogos();

        private readonly ServicesVendas servicoVendas =
            new ServicesVendas();

        private readonly CultureInfo cultura =
            new CultureInfo("pt-BR");

        private Label lblFaturamento;
        private Label lblQuantidadeVendas;
        private Label lblItensVendidos;
        private DataGridView dgvJogos;
        private DataGridView dgvVendas;
        private Button btnAtualizar;

        public FrmTeladeRelatorio()
        {
            InitializeComponent();
            MontarTela();
            AtualizarRelatorio();
        }

        private void MontarTela()
        {
            Text = "Relatório de Vendas - LojaGamesRetro";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1000, 700);
            MinimumSize = new Size(850, 600);

            Controls.Clear();

            Label titulo = new Label
            {
                Text = "RELATÓRIO DA LOJA",
                Font = new Font("Arial", 18, FontStyle.Bold),
                Location = new Point(20, 15),
                Size = new Size(500, 35)
            };
            Controls.Add(titulo);

            lblFaturamento = new Label
            {
                Location = new Point(20, 60),
                Size = new Size(280, 30),
                Font = new Font("Arial", 11, FontStyle.Bold)
            };

            lblQuantidadeVendas = new Label
            {
                Location = new Point(320, 60),
                Size = new Size(220, 30),
                Font = new Font("Arial", 11, FontStyle.Bold)
            };

            lblItensVendidos = new Label
            {
                Location = new Point(560, 60),
                Size = new Size(220, 30),
                Font = new Font("Arial", 11, FontStyle.Bold)
            };

            Controls.Add(lblFaturamento);
            Controls.Add(lblQuantidadeVendas);
            Controls.Add(lblItensVendidos);

            Label tituloJogos = new Label
            {
                Text = "Jogos e estoque",
                Location = new Point(20, 105),
                Size = new Size(300, 25),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            Controls.Add(tituloJogos);

            dgvJogos = new DataGridView
            {
                Location = new Point(20, 135),
                Size = new Size(940, 190),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };
            Controls.Add(dgvJogos);

            Label tituloVendas = new Label
            {
                Text = "Histórico de vendas",
                Location = new Point(20, 340),
                Size = new Size(300, 25),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            Controls.Add(tituloVendas);

            dgvVendas = new DataGridView
            {
                Location = new Point(20, 370),
                Size = new Size(940, 230),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };
            Controls.Add(dgvVendas);

            btnAtualizar = new Button
            {
                Text = "Atualizar relatório",
                Location = new Point(20, 615),
                Size = new Size(180, 35)
            };
            btnAtualizar.Click += (s, e) => AtualizarRelatorio();
            Controls.Add(btnAtualizar);
        }

        private void AtualizarRelatorio()
        {
            var jogos = servicoJogos.ListarTodos()
                .Select(jogo => new
                {
                    jogo.Id,
                    Jogo = jogo.Nome,
                    Preco = jogo.Preco.ToString("C", cultura),
                    jogo.Estoque
                })
                .ToList();

            dgvJogos.DataSource = null;
            dgvJogos.DataSource = jogos;

            var vendas = servicoVendas.ListarVendas()
                .OrderByDescending(venda => venda.Data)
                .Select(venda => new
                {
                    venda.Id,
                    Data = venda.Data.ToString("dd/MM/yyyy HH:mm:ss"),
                    Itens = venda.ResumoItens,
                    Total = venda.Total.ToString("C", cultura)
                })
                .ToList();

            dgvVendas.DataSource = null;
            dgvVendas.DataSource = vendas;

            lblFaturamento.Text =
                "Faturamento: " +
                servicoVendas.CalcularFaturamento().ToString("C", cultura);

            lblQuantidadeVendas.Text =
                "Vendas: " + servicoVendas.ContarVendas();

            lblItensVendidos.Text =
                "Itens vendidos: " + servicoVendas.ContarItensVendidos();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (dgvJogos != null && dgvVendas != null)
                AtualizarRelatorio();
        }
    }
}
