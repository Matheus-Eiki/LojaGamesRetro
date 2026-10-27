
namespace LojaGamesRetro.Views
{
    partial class FrmTelaCardsJogos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowJogos;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFinalizar;
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
            lblTitulo = new Label();
            flowJogos = new FlowLayoutPanel();
            grpPedido = new GroupBox();
            lstPedido = new ListBox();
            lblTotal = new Label();
            btnRemover = new Button();
            btnFinalizar = new Button();
            btnVoltar = new Button();
            grpPedido.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(820, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LOJA DE GAMES RETRO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowJogos
            flowJogos.AutoScroll = true;
            flowJogos.BackColor = Color.WhiteSmoke;
            flowJogos.FlowDirection = FlowDirection.LeftToRight;
            flowJogos.WrapContents = true;
            flowJogos.Location = new Point(20, 75);
            flowJogos.Name = "flowJogos";
            flowJogos.Padding = new Padding(5);
            flowJogos.Size = new Size(550, 440);
            flowJogos.TabIndex = 1;
            flowJogos.Paint += flowJogos_Paint;

            // 
            // grpPedido
            // 
            grpPedido.Controls.Add(lstPedido);
            grpPedido.Controls.Add(lblTotal);
            grpPedido.Controls.Add(btnRemover);
            grpPedido.Controls.Add(btnFinalizar);
            grpPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPedido.Location = new Point(590, 75);
            grpPedido.Name = "grpPedido";
            grpPedido.Size = new Size(250, 440);
            grpPedido.TabIndex = 2;
            grpPedido.TabStop = false;
            grpPedido.Text = "Seu pedido";
            // 
            // lstPedido
            // 
            lstPedido.Font = new Font("Segoe UI", 9F);
            lstPedido.FormattingEnabled = true;
            lstPedido.HorizontalScrollbar = true;
            lstPedido.Location = new Point(12, 35);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(226, 214);
            lstPedido.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(12, 265);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(226, 35);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(12, 315);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(226, 38);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover item";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(12, 365);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(226, 38);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar pedido";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(20, 530);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 35);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaJogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 585);
            Controls.Add(lblTitulo);
            Controls.Add(flowJogos);
            Controls.Add(grpPedido);
            Controls.Add(btnVoltar);
            Name = "TelaJogos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loja de Games Retro";
            grpPedido.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
