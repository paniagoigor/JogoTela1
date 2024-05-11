using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTela1
{
    public partial class Tela_5 : Form
    {
        Random random = new Random();
        public Tela_5()
        {
            InitializeComponent();
        }

        private void btnCerto_Click(object sender, EventArgs e)
        {
            //abre tela 6
            Tela6 tela6 = new Tela6();

            //esconde formulario atual
            this.Hide();

            //mostra tela6
            tela6.Show();

            tela6.Closed += (object s, EventArgs ev) => this.Hide();

        }



        private void btnErrado_MouseEnter_1(object sender, EventArgs e)
        {
            int largura_tela = this.ClientSize.Width; // Largura da tela
            int altura_tela = this.ClientSize.Height; // Altura da tela

            int x = random.Next(0, largura_tela - btnErrado.Width);
            int y = random.Next(0, altura_tela - btnErrado.Height);

            // Move o botão
            btnErrado.Location = new Point(x, y);

        }
    }
}
