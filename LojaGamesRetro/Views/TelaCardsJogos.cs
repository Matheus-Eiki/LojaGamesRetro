
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
    public partial class TelaJogos : Form
    {
        private readonly ServicesJogos jogoService = new ServicesJogos();

        // Guarda os jogos escolhidos e suas quantidades.
        private readonly Dictionary<Jogo, int> pedido =
            new Dictionary<Jogo, int>();

        private readonly CultureInfo cultura =
            new CultureInfo("pt-BR");

        public TelaJogos()
        {
            InitializeComponent();
            CarregarJogos();
            AtualizarPedido();
        }

        private void CarregarJogos()
        {
            flowJogos.SuspendLayout();
            flowJogos.Controls.Clear();

            foreach (Jogo jogo in jogoService.ListarTodos())
            {
                Panel card = new Panel
                {
                    Width = 245,
                    Height = 160,
                    Margin = new Padding(8),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                Label lblNome = new Label
                {
                    Text = jogo.Nome,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Size = new Size(220, 30),
                    AutoEllipsis = true
                };

                Label lblPreco = new Label
                {
                    Text = "Preço: " + jogo.Preco.ToString("C", cultura),
                    Location = new Point(10, 45),
                    Size = new Size(220, 22)
                };

                Label lblEstoque = new Label
                {
                    Text = "Estoque: " + jogo.Estoque,
                    Location = new Point(10, 70),
                    Size = new Size(220, 22)
                };

                NumericUpDown nudQuantidade = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = Math.Max(1, jogo.Estoque),
                    Value = 1,
                    Location = new Point(10, 112),
                    Size = new Size(65, 28),
                    Enabled = jogo.Estoque > 0
                };

                Button btnAdicionar = new Button
                {
                    Text = jogo.Estoque > 0
                        ? "Adicionar ao pedido"
                        : "Sem estoque",
                    Location = new Point(82, 110),
                    Size = new Size(148, 30),
                    Enabled = jogo.Estoque > 0
                };

                btnAdicionar.Click += (sender, e) =>
                {
                    AdicionarAoPedido(jogo, (int)nudQuantidade.Value);
                };

                card.Controls.Add(lblNome);
                card.Controls.Add(lblPreco);
                card.Controls.Add(lblEstoque);
                card.Controls.Add(nudQuantidade);
                card.Controls.Add(btnAdicionar);

                flowJogos.Controls.Add(card);
            }

            flowJogos.ResumeLayout();
        }

        private void AdicionarAoPedido(Jogo jogo, int quantidade)
        {
            int quantidadeAtual = pedido.ContainsKey(jogo)
                ? pedido[jogo]
                : 0;

            if (quantidade <= 0 ||
                quantidadeAtual + quantidade > jogo.Estoque)
            {
                MessageBox.Show(
                    "Estoque insuficiente para essa quantidade.",
                    "Estoque",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            pedido[jogo] = quantidadeAtual + quantidade;

            AtualizarPedido();
        }

        private void AtualizarPedido()
        {
            lstPedido.Items.Clear();

            foreach (KeyValuePair<Jogo, int> item in pedido)
            {
                decimal subtotal = item.Key.Preco * item.Value;

                lstPedido.Items.Add(
                    $"{item.Key.Nome} - {item.Value} un. - " +
                    subtotal.ToString("C", cultura));
            }

            decimal total = pedido.Sum(
                item => item.Key.Preco * item.Value);

            lblTotal.Text = "Total: " + total.ToString("C", cultura);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int indice = lstPedido.SelectedIndex;

            if (indice < 0 || indice >= pedido.Count)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            Jogo jogoSelecionado = pedido.Keys.ElementAt(indice);

            pedido.Remove(jogoSelecionado);

            AtualizarPedido();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (pedido.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um jogo ao pedido.");
                return;
            }

            foreach (KeyValuePair<Jogo, int> item in pedido)
            {
                Jogo atual = jogoService.BuscarPorId(item.Key.Id);

                if (atual == null || atual.Estoque < item.Value)
                {
                    MessageBox.Show(
                        $"Estoque insuficiente para {item.Key.Nome}.");

                    CarregarJogos();
                    return;
                }
            }

            decimal total = pedido.Sum(
                item => item.Key.Preco * item.Value);

            DialogResult resposta = MessageBox.Show(
                $"Deseja finalizar o pedido?\n\nTotal: {total.ToString("C", cultura)}",
                "Confirmar pedido",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            foreach (KeyValuePair<Jogo, int> item in pedido)
            {
                if (!jogoService.BaixarEstoque(
                    item.Key.Id, item.Value))
                {
                    MessageBox.Show(
                        $"Não foi possível atualizar o estoque de {item.Key.Nome}.");

                    CarregarJogos();
                    return;
                }
            }

            MessageBox.Show(
                $"Pedido finalizado!\nTotal: {total.ToString("C", cultura)}",
                "Venda concluída",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            pedido.Clear();
            AtualizarPedido();
            CarregarJogos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowJogos_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
