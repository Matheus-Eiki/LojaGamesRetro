namespace LojaGamesRetro
{
    partial class TelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(177, 251);
            button1.Name = "button1";
            button1.Size = new Size(151, 58);
            button1.TabIndex = 0;
            button1.Tag = "BtnJogos";
            button1.Text = "Jogos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(440, 251);
            button2.Name = "button2";
            button2.Size = new Size(151, 58);
            button2.TabIndex = 1;
            button2.Tag = "BtnRelatório";
            button2.Text = "Relatório de Vendas";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(277, 83);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(209, 89);
            label1.TabIndex = 2;
            label1.Tag = "lblMenu";
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TelaMenu";
            Text = "TelaMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}