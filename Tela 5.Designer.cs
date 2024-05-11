namespace JogoTela1
{
    partial class Tela_5
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
            label1 = new Label();
            btnCerto = new Button();
            btnErrado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 151);
            label1.Name = "label1";
            label1.Size = new Size(391, 37);
            label1.TabIndex = 5;
            label1.Text = "Tente Clicar no GANHAR";
            // 
            // btnCerto
            // 
            btnCerto.BackColor = Color.Black;
            btnCerto.FlatStyle = FlatStyle.Popup;
            btnCerto.ForeColor = Color.Yellow;
            btnCerto.Location = new Point(169, 304);
            btnCerto.Name = "btnCerto";
            btnCerto.Size = new Size(118, 35);
            btnCerto.TabIndex = 6;
            btnCerto.Text = "PERDER";
            btnCerto.UseVisualStyleBackColor = false;
            btnCerto.Click += btnCerto_Click;
            // 
            // btnErrado
            // 
            btnErrado.BackColor = Color.Black;
            btnErrado.FlatStyle = FlatStyle.Popup;
            btnErrado.ForeColor = Color.Yellow;
            btnErrado.Location = new Point(521, 304);
            btnErrado.Name = "btnErrado";
            btnErrado.Size = new Size(118, 35);
            btnErrado.TabIndex = 7;
            btnErrado.Text = "GANHAR";
            btnErrado.UseVisualStyleBackColor = false;
            btnErrado.MouseEnter += btnErrado_MouseEnter_1;
            // 
            // Tela_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnErrado);
            Controls.Add(btnCerto);
            Controls.Add(label1);
            Name = "Tela_5";
            Text = "Tela_5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerto;
        private Button btnErrado;
    }
}