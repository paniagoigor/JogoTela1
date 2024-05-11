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
    public partial class Tela_7 : Form
    {
        public Tela_7()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Abbre tela 1
            Tela1 tela1 = new Tela1();

            //Esconde o formulario atual
            this.Hide();

            //Mostra a tela 1
            tela1.Show();
        }
    }
}
