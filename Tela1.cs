namespace JogoTela1
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            //Abre tela 2
            Tela2 tela2 = new Tela2();

            //Esconde o formulário atual
            this.Hide();

            //Mostra a tela 2
            tela2.Show();

            tela2.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}