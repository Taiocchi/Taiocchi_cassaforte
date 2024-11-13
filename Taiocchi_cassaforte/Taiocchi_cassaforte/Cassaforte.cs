namespace Taiocchi_cassaforte
{
    internal class Cassaforte
    {
        private string matricola;
        private string produttore;
        private string modello;
        private string codiceSblocco12;
        private string codiceUtente5;
        private bool apertura = false; //Se true allora la cassaforte è aperta, altrimenti è chiusa
        private bool stato = true; //Se true allora la cassaforte è sbloccata, altrimenti è bloccata

        public void impostaCodiceUtente(string codice)
        {
            if (codice == null)
                return;
            codiceUtente5 = codice;
        }

        public void apri(string codice)
        {
            int n = 0;

            while (n < 5)
            {
                if (codice == null)
                    return;

                n++;

                if (codice == codiceUtente5)
                {
                    apertura = true;
                    return;
                }
            }

            stato = false;
        }

        public void chiudi()
        {
            apertura = false;
        }

        public void sblocca(string codice)
        {
            if (codice == null)
                return;

            if (codice == codiceSblocco12 && stato == false)
                stato = true;

        }

        Cassaforte(string matricola,  string produttore, string modello, string codiceSblocco12)
        {
            if(this.matricola != null)
                this.matricola = matricola;

            if (this.produttore != null)
                this.produttore = matricola;

            if (this.modello != null)
                this.modello = matricola;

            if (this.codiceSblocco12 != null)
                this.codiceSblocco12 = matricola;
        }

    }
}
