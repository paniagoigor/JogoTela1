namespace JogoTela1
{
    partial class Tela6
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
            BtnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Showcard Gothic", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 142);
            label1.Name = "label1";
            label1.Size = new Size(464, 124);
            label1.TabIndex = 6;
            label1.Text = "GANHOU";
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.Lime;
            BtnFechar.FlatStyle = FlatStyle.Popup;
            BtnFechar.Location = new Point(341, 345);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(112, 34);
            BtnFechar.TabIndex = 7;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // Tela6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFechar);
            Controls.Add(label1);
            Name = "Tela6";
            Text = "Tela6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnFechar;
    }
}