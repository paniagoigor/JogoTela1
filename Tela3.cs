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
    public partial class Tela3 : Form
    {
        public Tela3()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string chave = "O";
            if (txtResposta.Text.ToUpper() == chave)
            {
                //Abre tela4
                Tela_4 tela4 = new Tela_4();

                //Esconde formulario atual
                this.Hide();

                //Mostra tela 4
                tela4.Show();

                tela4.Closed += (object s, EventArgs ev) => this.Hide();

            }
            else
            {
                //abre tela7
                Tela_7 tela7 = new Tela_7();

                //esconde formulario atual
                this.Hide();

                //Mostra tela7
                tela7.Show();
            }
        }

        private void txtResposta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
