namespace JogoTela1
{
    partial class Tela_7
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
            btnFechar = new Button();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Showcard Gothic", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 72);
            label1.Name = "label1";
            label1.Size = new Size(599, 124);
            label1.TabIndex = 7;
            label1.Text = "GAME OVER";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Location = new Point(143, 292);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(112, 34);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "SAIR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Yellow;
            btnReiniciar.FlatStyle = FlatStyle.Popup;
            btnReiniciar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReiniciar.Location = new Point(449, 292);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(245, 34);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "TENTAR NOVAMENTE";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // Tela_7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReiniciar);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Name = "Tela_7";
            Text = "Tela_7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button btnFechar;
        private Button btnReiniciar;
    }
}