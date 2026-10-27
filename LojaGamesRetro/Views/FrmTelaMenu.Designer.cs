
namespace LojaGamesRetro
{
    partial class FrmTelaMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnJogos = new Button();
            btnRelatorioVendas = new Button();
            label1 = new Label();
            SuspendLayout();

            // btnJogos
            btnJogos.Location = new Point(177, 251);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(151, 58);
            btnJogos.TabIndex = 0;
            btnJogos.Text = "Jogos";
            btnJogos.UseVisualStyleBackColor = true;
            btnJogos.Click += btnJogos_Click;

            // btnRelatorioVendas
            btnRelatorioVendas.Location = new Point(440, 251);
            btnRelatorioVendas.Name = "btnRelatorioVendas";
            btnRelatorioVendas.Size = new Size(151, 58);
            btnRelatorioVendas.TabIndex = 1;
            btnRelatorioVendas.Text = "Relatório de Vendas";
            btnRelatorioVendas.UseVisualStyleBackColor = true;
            btnRelatorioVendas.Click += btnRelatorioVendas_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(277, 83);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(209, 89);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            label1.Click += label1_Click;

            // FrmTelaMenu
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(label1);
            Controls.Add(btnRelatorioVendas);
            Controls.Add(btnJogos);

            Name = "FrmTelaMenu";
            Text = "Loja Games Retro";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJogos;
        private Button btnRelatorioVendas;
        private Label label1;
    }
}
