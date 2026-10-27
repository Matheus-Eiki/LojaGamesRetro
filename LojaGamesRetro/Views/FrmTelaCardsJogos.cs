
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LojaGamesRetro.Models;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Views
{
    public partial class FrmTelaCardsJogos : Form
    {
        private readonly ServicesJogos jogoService =
            new ServicesJogos();

        private readonly ServicesVendas servicoVendas =
            new ServicesVendas();

        private readonly Dictionary<Jogo, int> pedido =
            new Dictionary<Jogo, int>();

        private readonly CultureInfo cultura =
            new CultureInfo("pt-BR");

        public FrmTelaCardsJogos()
        {
            InitializeComponent();
            CarregarJogos();
            AtualizarPedido();

        }

        private void CarregarJogos()
        {
            flowJogos.Controls.Clear();

            foreach (Jogo jogo in jogoService.ListarTodos())
            {
                Panel card = new Panel
                {
                    Width = 245,
                    Height = 155,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                Label lblNome = new Label
                {
                    Text = jogo.Nome,
                    Location = new Point(10, 10),
                    Size = new Size(220, 25),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                Label lblPreco = new Label
                {
                    Text = "Preço: " + jogo.Preco.ToString("C", cultura),
                    Location = new Point(10, 42),
                    Size = new Size(220, 22)
                };

                Label lblEstoque = new Label
                {
                    Text = "Estoque: " + jogo.Estoque,
                    Location = new Point(10, 66),
                    Size = new Size(220, 22)
                };

                NumericUpDown nudQuantidade = new NumericUpDown
                {
                    Location = new Point(10, 95),
                    Size = new Size(65, 25),
                    Minimum = 1,
                    Maximum = Math.Max(1, jogo.Estoque),
                    Value = 1,
                    Enabled = jogo.Estoque > 0
                };

                Button btnAdicionar = new Button
                {
                    Text = jogo.Estoque > 0
                        ? "Adicionar"
                        : "Sem estoque",
                    Location = new Point(85, 92),
                    Size = new Size(135, 30),
                    Enabled = jogo.Estoque > 0
                };

                btnAdicionar.Click += (sender, e) =>
                {
                    AdicionarAoPedido(
                        jogo,
                        (int)nudQuantidade.Value
                    );
                };

                card.Controls.Add(lblNome);
                card.Controls.Add(lblPreco);
                card.Controls.Add(lblEstoque);
                card.Controls.Add(nudQuantidade);
                card.Controls.Add(btnAdicionar);

                flowJogos.Controls.Add(card);
            }
        }

        private void AdicionarAoPedido(Jogo jogo, int quantidade)
        {
            int quantidadeAtual = pedido.ContainsKey(jogo)
                ? pedido[jogo]
                : 0;

            if (quantidadeAtual + quantidade > jogo.Estoque)
            {
                MessageBox.Show(
                    "Quantidade maior que o estoque disponível.",
                    "Estoque insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            pedido[jogo] = quantidadeAtual + quantidade;
            AtualizarPedido();
        }

        private void AtualizarPedido()
        {
            lstPedido.Items.Clear();

            decimal total = 0;

            foreach (var item in pedido)
            {
                decimal subtotal = item.Key.Preco * item.Value;
                total += subtotal;

                lstPedido.Items.Add(
                    $"{item.Key.Nome} x{item.Value} - " +
                    subtotal.ToString("C", cultura)
                );
            }

            lblTotal.Text = "Total: " + total.ToString("C", cultura);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int indice = lstPedido.SelectedIndex;

            if (indice < 0)
            {
                MessageBox.Show(
                    "Selecione um item para remover.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Jogo jogo = pedido.Keys.ElementAt(indice);
            pedido.Remove(jogo);

            AtualizarPedido();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (pedido.Count == 0)
            {
                MessageBox.Show(
                    "Adicione pelo menos um jogo ao pedido.",
                    "Pedido vazio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Verifica o estoque de todos os jogos antes da baixa.
            foreach (var item in pedido)
            {
                Jogo jogoAtual =
                    jogoService.BuscarPorId(item.Key.Id);

                if (jogoAtual == null ||
                    jogoAtual.Estoque < item.Value)
                {
                    MessageBox.Show(
                        "Estoque insuficiente para " + item.Key.Nome + ".",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    CarregarJogos();
                    return;
                }
            }

            // Registra a venda antes de baixar o estoque.
            if (!servicoVendas.RegistrarVenda(pedido))
            {
                MessageBox.Show(
                    "Não foi possível registrar a venda.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Baixa o estoque após registrar a venda.
            foreach (var item in pedido)
            {
                if (!jogoService.BaixarEstoque(
                    item.Key.Id, item.Value))
                {
                    MessageBox.Show(
                        "Não foi possível atualizar o estoque.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }
            }

            MessageBox.Show(
                "Venda finalizada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            pedido.Clear();

            CarregarJogos();
            AtualizarPedido();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowJogos_Paint(object sender, PaintEventArgs e)
        {
            // Os cards são carregados pelo método CarregarJogos().
        }
    }
}
