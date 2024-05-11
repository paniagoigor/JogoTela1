namespace JogoTela1
{
    partial class Tela1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFechar = new Button();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 67);
            label1.Name = "label1";
            label1.Size = new Size(629, 37);
            label1.TabIndex = 0;
            label1.Text = "Bem Vindo ao Labirinto das Perguntas";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Location = new Point(112, 306);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(112, 34);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 192, 0);
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Location = new Point(567, 306);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // Tela1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Name = "Tela1";
            Text = "Labirinto das Perguntas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFechar;
        private Button btnIniciar;
    }
}