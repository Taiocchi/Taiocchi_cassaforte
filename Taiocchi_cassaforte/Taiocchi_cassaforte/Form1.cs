namespace Taiocchi_cassaforte
{
    public partial class Form1 : Form
    {
        private Cassaforte C1;
        public Form1()
        {
            InitializeComponent();

            C1 = new Cassaforte("1234", "SecureCassaforte", "BV324E", "12Caratteri");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void impostaCodice_Click(object sender, EventArgs e)
        {
            C1.ImpostaCodiceUtente(codiceUtente5.Text);
        }

        private void Sblocca_Click(object sender, EventArgs e)
        {
            C1.Sblocca(CodiceSblocco.Text);

            if (Label_data.Text != null)
                C1.AperturaProgrammata(Pin.Text, Label_data.Text);

            aggiornaInterfaccia();
        }

        private void Apri_Click(object sender, EventArgs e)
        {
            C1.Apri(Pin.Text);
            aggiornaInterfaccia();
        }

        private void Chiudi_Click(object sender, EventArgs e)
        {
            C1.Chiudi();
            aggiornaInterfaccia();
        }

        private void aggiornaInterfaccia()
        {
            if (C1.Apertura == false)
                Apertura.Text = "Apertura: chiusa";
            else
                Apertura.Text = "Apertura: aperta";

            if (C1.Stato == false)
                Stato.Text = "Stato: bloccata";
            else
                Stato.Text = "Stato: sbloccata";
        }

    }
}
