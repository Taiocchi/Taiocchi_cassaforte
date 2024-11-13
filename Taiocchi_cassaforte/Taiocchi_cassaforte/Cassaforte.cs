namespace Taiocchi_cassaforte
{
    internal class Cassaforte
    {
        private int n = 0;
        private int j = 0;
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceSblocco12;
        private string codiceUtente5;
        private bool apertura = false; //Se true allora la cassaforte è aperta, altrimenti è chiusa
        private bool stato = true; //Se true allora la cassaforte è sbloccata, altrimenti è bloccata
        private string data;
        private bool statoProgrammato = true; //Se true allora la cassaforte è sbloccata, altrimenti è bloccata e
                                              //non si può più riaprire in nessun caso

        public string Matricola
        {
            get { return matricola; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public string CodiceUtente5
        {
            get { return codiceUtente5; }
        }
        public string CodiceSblocco12
        {
            get { return codiceSblocco12; }
        }
        public bool Apertura
        {
            get { return apertura; }
        }
        public bool Stato
        {
            get { return stato; }
        }

        public void ImpostaCodiceUtente(string codice)
        {
            if (codice == null)
                return;
            codiceUtente5 = codice;
        }

        public void Apri(string codice)
        {
            if (codice == null)
                return;

            n++;

            if (codice == codiceUtente5)
            {
                apertura = true;
                n = 0;
                return;
            }

            if (n == 5)
                stato = false;
        }

        public void Chiudi()
        {
            apertura = false;
        }

        public void Sblocca(string codice)
        {
            if (codice == null)
                return;

            if (codice == codiceSblocco12 && statoProgrammato == true)
                stato = true;

        }

        public void ImpostaData(string dataInserita)
        {
            if (dataInserita == null)
                return;

            data = dataInserita;
        }

        public void AperturaProgrammata(string codice, string dataInserita)
        {
            if (codice == null)
                return;

            j++;

            if (codice == codiceUtente5 && dataInserita == data)
            {
                apertura = true;
                j = 0;
                return;
            }

            if (j == 5)
            {
                stato = false;
                statoProgrammato = false;
            }
        }

        public Cassaforte(string matricola,  string produttore, string modello, string codiceSblocco12)
        {
            this.matricola = matricola;

            this.produttore = matricola;

            this.modello = modello;

            this.codiceSblocco12 = codiceSblocco12;
        }

    }
}
