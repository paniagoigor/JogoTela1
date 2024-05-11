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
    public partial class Tela_4 : Form
    {
        public Tela_4()
        {
            InitializeComponent();
        }

        private void opcErrada1_Click(object sender, EventArgs e)
        {
            //Abre tela 7
            Tela_7 tela7 = new Tela_7();

            //esconde formulario atual
            this.Hide();

            //Mostra tela7
            tela7.Show();

        }

        private void opcErrada2_Click(object sender, EventArgs e)
        {
            //Abre tela 7
            Tela_7 tela7 = new Tela_7();

            //esconde formulario atual
            this.Hide();

            //Mostra tela7
            tela7.Show();
        }


        private void opcCerta_Click(object sender, EventArgs e)
        {
            //Abre tela5
            Tela_5 tela5 = new Tela_5();

            //esconde formulario atual
            this.Hide();

            //mostra tela 5
            tela5.Show();

            tela5.Closed += (object s, EventArgs ev) => this.Hide();
        }

        private void opcerrada3_Click(object sender, EventArgs e)
        {
            //Abre tela 7
            Tela_7 tela7 = new Tela_7();

            //esconde formulario atual
            this.Hide();

            //Mostra tela7
            tela7.Show();
        }
    }
}
