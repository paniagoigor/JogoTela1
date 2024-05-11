namespace JogoTela1
{
    partial class Tela3
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
            txtResposta = new TextBox();
            label2 = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 166);
            label1.Name = "label1";
            label1.Size = new Size(724, 37);
            label1.TabIndex = 2;
            label1.Text = "O que tem em todos os meses menos em abril?";
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(322, 273);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(191, 31);
            txtResposta.TabIndex = 3;
            txtResposta.TextChanged += txtResposta_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 277);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 4;
            label2.Text = "Resposta:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Blue;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Location = new Point(593, 362);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // Tela3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(label2);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Name = "Tela3";
            Text = "Tela3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtResposta;
        private Label label2;
        private Button btnConfirmar;
    }
}