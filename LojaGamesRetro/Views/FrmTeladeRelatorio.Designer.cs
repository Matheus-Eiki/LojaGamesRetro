
namespace LojaGamesRetro.Views
{
    partial class FrmTeladeRelatorio
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel pnlFaturamento;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Panel pnlItens;
        private System.Windows.Forms.Panel pnlTicket;

        private System.Windows.Forms.Label lblTituloFaturamento;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.Label lblTituloVendas;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.Label lblTituloItens;
        private System.Windows.Forms.Label lblItensVendidos;
        private System.Windows.Forms.Label lblTituloTicket;
        private System.Windows.Forms.Label lblTicketMedio;

        private System.Windows.Forms.Label lblTituloJogos;
        private System.Windows.Forms.Label lblTituloHistorico;

        private System.Windows.Forms.DataGridView dgvJogos;
        private System.Windows.Forms.DataGridView dgvVendas;

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnVoltar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.pnlFaturamento = new System.Windows.Forms.Panel();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.pnlItens = new System.Windows.Forms.Panel();
            this.pnlTicket = new System.Windows.Forms.Panel();

            this.lblTituloFaturamento = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.lblTituloVendas = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.lblTituloItens = new System.Windows.Forms.Label();
            this.lblItensVendidos = new System.Windows.Forms.Label();
            this.lblTituloTicket = new System.Windows.Forms.Label();
            this.lblTicketMedio = new System.Windows.Forms.Label();

            this.lblTituloJogos = new System.Windows.Forms.Label();
            this.lblTituloHistorico = new System.Windows.Forms.Label();

            this.dgvJogos = new System.Windows.Forms.DataGridView();
            this.dgvVendas = new System.Windows.Forms.DataGridView();

            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            this.pnlFaturamento.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            this.pnlItens.SuspendLayout();
            this.pnlTicket.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();

            this.SuspendLayout();

            // Formulário
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(23, 20, 38);
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(900, 750);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaGamesRetro - Relatórios";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Título principal
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(182, 156, 255);
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "RELATÓRIOS";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 181, 207);
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 68);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Desempenho da loja e histórico de vendas";

            // Cartão de faturamento
            this.pnlFaturamento.BackColor = System.Drawing.Color.FromArgb(39, 32, 57);
            this.pnlFaturamento.Location = new System.Drawing.Point(25, 105);
            this.pnlFaturamento.Name = "pnlFaturamento";
            this.pnlFaturamento.Size = new System.Drawing.Size(230, 95);

            this.lblTituloFaturamento.AutoSize = true;
            this.lblTituloFaturamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloFaturamento.ForeColor = System.Drawing.Color.FromArgb(190, 181, 207);
            this.lblTituloFaturamento.Location = new System.Drawing.Point(12, 12);
            this.lblTituloFaturamento.Text = "FATURAMENTO TOTAL";

            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFaturamento.ForeColor = System.Drawing.Color.FromArgb(57, 230, 209);
            this.lblFaturamento.Location = new System.Drawing.Point(12, 40);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Text = "R$ 0,00";

            this.pnlFaturamento.Controls.Add(this.lblTituloFaturamento);
            this.pnlFaturamento.Controls.Add(this.lblFaturamento);

            // Cartão de vendas
            this.pnlVendas.BackColor = System.Drawing.Color.FromArgb(39, 32, 57);
            this.pnlVendas.Location = new System.Drawing.Point(265, 105);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(230, 95);

            this.lblTituloVendas.AutoSize = true;
            this.lblTituloVendas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloVendas.ForeColor = System.Drawing.Color.FromArgb(190, 181, 207);
            this.lblTituloVendas.Location = new System.Drawing.Point(12, 12);
            this.lblTituloVendas.Text = "VENDAS REALIZADAS";

            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeVendas.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(12, 40);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Text = "0";

            this.pnlVendas.Controls.Add(this.lblTituloVendas);
            this.pnlVendas.Controls.Add(this.lblQuantidadeVendas);

            // Cartão de itens vendidos
            this.pnlItens.BackColor = System.Drawing.Color.FromArgb(39, 32, 57);
            this.pnlItens.Location = new System.Drawing.Point(505, 105);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Size = new System.Drawing.Size(230, 95);

            this.lblTituloItens.AutoSize = true;
            this.lblTituloItens.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloItens.ForeColor = System.Drawing.Color.FromArgb(190, 181, 207);
            this.lblTituloItens.Location = new System.Drawing.Point(12, 12);
            this.lblTituloItens.Text = "JOGOS VENDIDOS";

            this.lblItensVendidos.AutoSize = true;
            this.lblItensVendidos.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblItensVendidos.ForeColor = System.Drawing.Color.FromArgb(246, 198, 103);
            this.lblItensVendidos.Location = new System.Drawing.Point(12, 40);
            this.lblItensVendidos.Name = "lblItensVendidos";
            this.lblItensVendidos.Text = "0";

            this.pnlItens.Controls.Add(this.lblTituloItens);
            this.pnlItens.Controls.Add(this.lblItensVendidos);

            // Cartão de ticket médio
            this.pnlTicket.BackColor = System.Drawing.Color.FromArgb(39, 32, 57);
            this.pnlTicket.Location = new System.Drawing.Point(745, 105);
            this.pnlTicket.Name = "pnlTicket";
            this.pnlTicket.Size = new System.Drawing.Size(230, 95);

            this.lblTituloTicket.AutoSize = true;
            this.lblTituloTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloTicket.ForeColor = System.Drawing.Color.FromArgb(190, 181, 207);
            this.lblTituloTicket.Location = new System.Drawing.Point(12, 12);
            this.lblTituloTicket.Text = "TICKET MÉDIO";

            this.lblTicketMedio.AutoSize = true;
            this.lblTicketMedio.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTicketMedio.ForeColor = System.Drawing.Color.FromArgb(255, 141, 161);
            this.lblTicketMedio.Location = new System.Drawing.Point(12, 40);
            this.lblTicketMedio.Name = "lblTicketMedio";
            this.lblTicketMedio.Text = "R$ 0,00";

            this.pnlTicket.Controls.Add(this.lblTituloTicket);
            this.pnlTicket.Controls.Add(this.lblTicketMedio);

            // Título da tabela de jogos
            this.lblTituloJogos.AutoSize = true;
            this.lblTituloJogos.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloJogos.ForeColor = System.Drawing.Color.White;
            this.lblTituloJogos.Location = new System.Drawing.Point(25, 215);
            this.lblTituloJogos.Name = "lblTituloJogos";
            this.lblTituloJogos.Text = "JOGOS E ESTOQUE";

            // Tabela de jogos
            ConfigurarTabela(this.dgvJogos);
            this.dgvJogos.Location = new System.Drawing.Point(25, 245);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.Size = new System.Drawing.Size(950, 160);

            // Título do histórico
            this.lblTituloHistorico.AutoSize = true;
            this.lblTituloHistorico.Font = new System.Drawing.Font(
                "Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloHistorico.ForeColor = System.Drawing.Color.White;
            this.lblTituloHistorico.Location = new System.Drawing.Point(25, 420);
            this.lblTituloHistorico.Name = "lblTituloHistorico";
            this.lblTituloHistorico.Text = "HISTÓRICO DE VENDAS";

            // Tabela de vendas
            ConfigurarTabela(this.dgvVendas);
            this.dgvVendas.Location = new System.Drawing.Point(25, 450);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(950, 230);

            // Botão atualizar
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(48, 40, 65);
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(85, 70, 110);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(25, 710);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(175, 38);
            this.btnAtualizar.Text = "Atualizar relatório";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // Botão voltar
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(48, 40, 65);
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(85, 70, 110);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(210, 710);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 38);
            this.btnVoltar.Text = "Voltar ao menu";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // Botão exportar
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(89, 62, 139);
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(800, 710);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(175, 38);
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);

            // Adicionar ao formulário
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);

            this.Controls.Add(this.pnlFaturamento);
            this.Controls.Add(this.pnlVendas);
            this.Controls.Add(this.pnlItens);
            this.Controls.Add(this.pnlTicket);

            this.Controls.Add(this.lblTituloJogos);
            this.Controls.Add(this.dgvJogos);

            this.Controls.Add(this.lblTituloHistorico);
            this.Controls.Add(this.dgvVendas);

            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExportar);

            this.pnlFaturamento.ResumeLayout(false);
            this.pnlFaturamento.PerformLayout();
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            this.pnlItens.ResumeLayout(false);
            this.pnlItens.PerformLayout();
            this.pnlTicket.ResumeLayout(false);
            this.pnlTicket.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarTabela(System.Windows.Forms.DataGridView tabela)
        {
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;
            tabela.AllowUserToResizeRows = false;
            tabela.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            tabela.BackgroundColor = System.Drawing.Color.FromArgb(30, 25, 45);
            tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tabela.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            tabela.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            tabela.EnableHeadersVisualStyles = false;
            tabela.GridColor = System.Drawing.Color.FromArgb(65, 53, 81);
            tabela.ReadOnly = true;
            tabela.RowHeadersVisible = false;
            tabela.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            tabela.MultiSelect = false;

            tabela.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(66, 48, 101);
            tabela.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            tabela.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            tabela.ColumnHeadersHeight = 35;

            tabela.DefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(30, 25, 45);
            tabela.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            tabela.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(83, 63, 120);
            tabela.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            tabela.RowTemplate.Height = 30;
        }
    }
}
