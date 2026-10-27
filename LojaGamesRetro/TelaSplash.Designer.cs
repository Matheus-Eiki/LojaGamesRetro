
namespace LojaGamesRetro
{
    partial class TelaSplash
    {
        private System.ComponentModel.IContainer? components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCarregamento;
        private System.Windows.Forms.ProgressBar progressBarSplash;
        private System.Windows.Forms.Timer timerSplash;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblDescricao = new Label();
            lblCarregamento = new Label();
            progressBarSplash = new ProgressBar();
            timerSplash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(214, 124);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 47);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "LOJA DE GAMES";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Consolas", 20F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(255, 64, 180);
            lblSubtitulo.Location = new Point(286, 171);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(149, 32);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "R E T R O";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 11F);
            lblDescricao.ForeColor = Color.FromArgb(190, 197, 220);
            lblDescricao.Location = new Point(230, 225);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(245, 20);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Sua próxima aventura começa aqui.";
            // 
            // lblCarregamento
            // 
            lblCarregamento.AutoSize = true;
            lblCarregamento.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblCarregamento.ForeColor = Color.FromArgb(0, 230, 255);
            lblCarregamento.Location = new Point(285, 326);
            lblCarregamento.Name = "lblCarregamento";
            lblCarregamento.Size = new Size(168, 14);
            lblCarregamento.TabIndex = 5;
            lblCarregamento.Text = "INICIANDO SISTEMA... 0%";
            // 
            // progressBarSplash
            // 
            progressBarSplash.Location = new Point(200, 295);
            progressBarSplash.Name = "progressBarSplash";
            progressBarSplash.Size = new Size(360, 18);
            progressBarSplash.Style = ProgressBarStyle.Continuous;
            progressBarSplash.TabIndex = 4;
            // 
            // timerSplash
            // 
            timerSplash.Interval = 50;
            timerSplash.Tick += timerSplash_Tick;
            // 
            // TelaSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 16, 38);
            ClientSize = new Size(760, 430);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblDescricao);
            Controls.Add(progressBarSplash);
            Controls.Add(lblCarregamento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loja de Games Retro";
            Load += TelaSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
