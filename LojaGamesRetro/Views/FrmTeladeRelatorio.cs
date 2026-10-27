
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Views
{
    public partial class FrmTeladeRelatorio : Form
    {
        private readonly ServicesJogos servicoJogos = new ServicesJogos();
        private readonly ServicesVendas servicoVendas = new ServicesVendas();

        private readonly CultureInfo cultura = new CultureInfo("pt-BR");

        public FrmTeladeRelatorio()
        {
            InitializeComponent();
            AtualizarRelatorio();
        }

        private void AtualizarRelatorio()
        {
            // Atualiza a tabela de jogos e estoque.
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

            // Atualiza o histórico de vendas.
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

            // Atualiza os indicadores.
            decimal faturamento = servicoVendas.CalcularFaturamento();
            int quantidadeVendas = servicoVendas.ContarVendas();
            int itensVendidos = servicoVendas.ContarItensVendidos();

            decimal ticketMedio = quantidadeVendas > 0
                ? faturamento / quantidadeVendas
                : 0m;

            lblFaturamento.Text = faturamento.ToString("C", cultura);
            lblQuantidadeVendas.Text = quantidadeVendas.ToString();
            lblItensVendidos.Text = itensVendidos.ToString();
            lblTicketMedio.Text = ticketMedio.ToString("C", cultura);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarRelatorio();

            MessageBox.Show(
                "Relatório atualizado com sucesso!",
                "Relatórios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var vendas = servicoVendas.ListarVendas()
                .OrderByDescending(venda => venda.Data)
                .ToList();

            if (vendas.Count == 0)
            {
                MessageBox.Show(
                    "Não existem vendas para exportar.",
                    "Relatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Title = "Exportar relatório de vendas";
                dialogo.Filter = "Arquivo CSV (*.csv)|*.csv";
                dialogo.FileName = "RelatorioVendas.csv";
                dialogo.DefaultExt = "csv";
                dialogo.AddExtension = true;

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter escritor = new StreamWriter(
                        dialogo.FileName,
                        false,
                        new UTF8Encoding(true)))
                    {
                        escritor.WriteLine(
                            "ID;Data;Itens vendidos;Total");

                        foreach (var venda in vendas)
                        {
                            string resumo = EscaparCsv(venda.ResumoItens);
                            string data = venda.Data.ToString(
                                "dd/MM/yyyy HH:mm:ss");

                            string total = venda.Total.ToString(
                                "0.00", CultureInfo.InvariantCulture);

                            escritor.WriteLine(
                                venda.Id + ";" +
                                EscaparCsv(data) + ";" +
                                resumo + ";" +
                                total);
                        }

                        escritor.WriteLine();
                        escritor.WriteLine(
                            "Faturamento total;;;" +
                            servicoVendas.CalcularFaturamento()
                                .ToString("0.00", CultureInfo.InvariantCulture));

                        escritor.WriteLine(
                            "Quantidade de vendas;;;" +
                            servicoVendas.ContarVendas());

                        escritor.WriteLine(
                            "Itens vendidos;;;" +
                            servicoVendas.ContarItensVendidos());
                    }

                    MessageBox.Show(
                        "Relatório exportado com sucesso!",
                        "Exportação concluída",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Não foi possível exportar o relatório.\n\n" +
                        ex.Message,
                        "Erro na exportação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string EscaparCsv(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return "\"\"";

            return "\"" + valor.Replace("\"", "\"\"") + "\"";
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (IsHandleCreated)
                AtualizarRelatorio();
        }
    }
}
