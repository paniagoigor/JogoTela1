namespace JogoTela1
{
    partial class Tela_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_4));
            opcErrada1 = new PictureBox();
            opcErrada2 = new PictureBox();
            opcCerta = new PictureBox();
            opcerrada3 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)opcErrada1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opcErrada2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opcCerta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opcerrada3).BeginInit();
            SuspendLayout();
            // 
            // opcErrada1
            // 
            opcErrada1.Image = (Image)resources.GetObject("opcErrada1.Image");
            opcErrada1.Location = new Point(12, 12);
            opcErrada1.Name = "opcErrada1";
            opcErrada1.Size = new Size(150, 122);
            opcErrada1.SizeMode = PictureBoxSizeMode.StretchImage;
            opcErrada1.TabIndex = 0;
            opcErrada1.TabStop = false;
            opcErrada1.Click += opcErrada1_Click;
            // 
            // opcErrada2
            // 
            opcErrada2.Image = (Image)resources.GetObject("opcErrada2.Image");
            opcErrada2.Location = new Point(638, 12);
            opcErrada2.Name = "opcErrada2";
            opcErrada2.Size = new Size(150, 122);
            opcErrada2.SizeMode = PictureBoxSizeMode.StretchImage;
            opcErrada2.TabIndex = 1;
            opcErrada2.TabStop = false;
            opcErrada2.Click += opcErrada2_Click;
            // 
            // opcCerta
            // 
            opcCerta.Image = (Image)resources.GetObject("opcCerta.Image");
            opcCerta.Location = new Point(12, 311);
            opcCerta.Name = "opcCerta";
            opcCerta.Size = new Size(150, 127);
            opcCerta.SizeMode = PictureBoxSizeMode.StretchImage;
            opcCerta.TabIndex = 2;
            opcCerta.TabStop = false;
            opcCerta.Click += opcCerta_Click;
            // 
            // opcerrada3
            // 
            opcerrada3.Image = (Image)resources.GetObject("opcerrada3.Image");
            opcerrada3.Location = new Point(638, 311);
            opcerrada3.Name = "opcerrada3";
            opcerrada3.Size = new Size(150, 127);
            opcerrada3.SizeMode = PictureBoxSizeMode.StretchImage;
            opcerrada3.TabIndex = 3;
            opcerrada3.TabStop = false;
            opcerrada3.Click += opcerrada3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 189);
            label1.Name = "label1";
            label1.Size = new Size(397, 37);
            label1.TabIndex = 4;
            label1.Text = "Escolha o Alvo Correto";
            // 
            // Tela_4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(opcerrada3);
            Controls.Add(opcCerta);
            Controls.Add(opcErrada2);
            Controls.Add(opcErrada1);
            Name = "Tela_4";
            Text = "Tela_4";
            ((System.ComponentModel.ISupportInitialize)opcErrada1).EndInit();
            ((System.ComponentModel.ISupportInitialize)opcErrada2).EndInit();
            ((System.ComponentModel.ISupportInitialize)opcCerta).EndInit();
            ((System.ComponentModel.ISupportInitialize)opcerrada3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox opcErrada1;
        private PictureBox opcErrada2;
        private PictureBox opcCerta;
        private PictureBox opcerrada3;
        private Label label1;
    }
}