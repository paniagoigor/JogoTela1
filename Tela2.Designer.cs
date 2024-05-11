namespace JogoTela1
{
    partial class Tela2
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
            btnVoltaInicio = new Button();
            btnProxFase = new Button();
            btnGameOver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(590, 50);
            label1.TabIndex = 1;
            label1.Text = "Escolha A Direção Correta";
            // 
            // btnVoltaInicio
            // 
            btnVoltaInicio.BackColor = Color.Fuchsia;
            btnVoltaInicio.FlatStyle = FlatStyle.Popup;
            btnVoltaInicio.Location = new Point(300, 390);
            btnVoltaInicio.Name = "btnVoltaInicio";
            btnVoltaInicio.Size = new Size(149, 48);
            btnVoltaInicio.TabIndex = 2;
            btnVoltaInicio.Text = "↓";
            btnVoltaInicio.UseVisualStyleBackColor = false;
            btnVoltaInicio.Click += btnVoltaInicio_Click;
            // 
            // btnProxFase
            // 
            btnProxFase.BackColor = Color.Fuchsia;
            btnProxFase.FlatStyle = FlatStyle.Popup;
            btnProxFase.ForeColor = Color.Black;
            btnProxFase.Location = new Point(639, 183);
            btnProxFase.Name = "btnProxFase";
            btnProxFase.Size = new Size(149, 52);
            btnProxFase.TabIndex = 3;
            btnProxFase.Text = "→";
            btnProxFase.UseVisualStyleBackColor = false;
            btnProxFase.Click += btnProxFase_Click;
            // 
            // btnGameOver
            // 
            btnGameOver.BackColor = Color.Fuchsia;
            btnGameOver.FlatAppearance.BorderColor = SystemColors.Control;
            btnGameOver.FlatAppearance.BorderSize = 0;
            btnGameOver.FlatStyle = FlatStyle.Popup;
            btnGameOver.ForeColor = Color.Black;
            btnGameOver.Location = new Point(300, 12);
            btnGameOver.Name = "btnGameOver";
            btnGameOver.Size = new Size(149, 48);
            btnGameOver.TabIndex = 4;
            btnGameOver.Text = "↑";
            btnGameOver.UseVisualStyleBackColor = false;
            btnGameOver.Click += btnGameOver_Click;
            // 
            // Tela2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGameOver);
            Controls.Add(btnProxFase);
            Controls.Add(btnVoltaInicio);
            Controls.Add(label1);
            Name = "Tela2";
            Text = "Tela2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltaInicio;
        private Button btnProxFase;
        private Button btnGameOver;
    }
}