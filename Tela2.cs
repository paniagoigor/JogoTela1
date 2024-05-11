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
    public partial class Tela2 : Form
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            //Abre tela 7
            Tela_7 tela7 = new Tela_7();

            //Esconde formulario atual
            this.Hide();

            //Mostra tela 7
            tela7.Show();


        }

        private void btnProxFase_Click(object sender, EventArgs e)
        {
            //Abre tela 3
            Tela3 tela3 = new Tela3();

            //Esconde formulario atual
            this.Hide();

            //Mostra tela 3
            tela3.Show();

            tela3.Closed += (object s, EventArgs ev) => this.Hide();

        }

        private void btnVoltaInicio_Click(object sender, EventArgs e)
        {
            //Abre tela 1
            Tela1 tela1 = new Tela1();

            //Esconde formulario atual
            this.Hide();

            //Mostra tela 1
            tela1.Show();

        }
    }
}
