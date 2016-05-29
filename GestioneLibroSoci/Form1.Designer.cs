namespace GestioneLibroSoci
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciNuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaAnagraficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaIscrizioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciCertificatoMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rinnovaIscrizioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaIscrittiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genericaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaFatturaErrataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaFatturePerAnnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominativoClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingressiDanzantiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaNuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenotazioneTavoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prenotaTavoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaPrenotazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaIngressiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perMeseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abbonamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definisciNuovaTipologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaTipologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definisciInizioFineStagioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampanteFattureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiNuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountClickatellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiNuovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbStagioni = new System.Windows.Forms.TabControl();
            this.StampaPDFIscritti = new System.ComponentModel.BackgroundWorker();
            this.Stampa_moduli = new System.Drawing.Printing.PrintDocument();
            this.timerStampaModuli = new System.Windows.Forms.Timer(this.components);
            this.notifica = new System.Windows.Forms.NotifyIcon(this.components);
            this.SceltaRapida = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.esci = new System.Windows.Forms.ToolStripMenuItem();
            this.StampaCertificati = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SceltaRapida.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicazioneToolStripMenuItem,
            this.socioToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.ingressiDanzantiToolStripMenuItem,
            this.serviziToolStripMenuItem,
            this.cddToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicazioneToolStripMenuItem
            // 
            this.applicazioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem});
            this.applicazioneToolStripMenuItem.Name = "applicazioneToolStripMenuItem";
            this.applicazioneToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.applicazioneToolStripMenuItem.Text = "Applicazione";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.door24;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.chiudiToolStripMenuItem.Text = "Esci";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciNuovoToolStripMenuItem,
            this.modificaAnagraficaToolStripMenuItem,
            this.cancellaIscrizioneToolStripMenuItem,
            this.inserisciCertificatoMedicoToolStripMenuItem,
            this.rinnovaIscrizioneToolStripMenuItem,
            this.stampaIscrittiToolStripMenuItem,
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem});
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.socioToolStripMenuItem.Text = "Socio";
            // 
            // inserisciNuovoToolStripMenuItem
            // 
            this.inserisciNuovoToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.round75;
            this.inserisciNuovoToolStripMenuItem.Name = "inserisciNuovoToolStripMenuItem";
            this.inserisciNuovoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.inserisciNuovoToolStripMenuItem.Text = "Inserisci nuovo";
            this.inserisciNuovoToolStripMenuItem.Click += new System.EventHandler(this.inserisciNuovoToolStripMenuItem_Click);
            // 
            // modificaAnagraficaToolStripMenuItem
            // 
            this.modificaAnagraficaToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.clasic;
            this.modificaAnagraficaToolStripMenuItem.Name = "modificaAnagraficaToolStripMenuItem";
            this.modificaAnagraficaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.modificaAnagraficaToolStripMenuItem.Text = "Modifica anagrafica";
            this.modificaAnagraficaToolStripMenuItem.Click += new System.EventHandler(this.modificaAnagraficaToolStripMenuItem_Click);
            // 
            // cancellaIscrizioneToolStripMenuItem
            // 
            this.cancellaIscrizioneToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.delete85;
            this.cancellaIscrizioneToolStripMenuItem.Name = "cancellaIscrizioneToolStripMenuItem";
            this.cancellaIscrizioneToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cancellaIscrizioneToolStripMenuItem.Text = "Cancella iscrizione";
            this.cancellaIscrizioneToolStripMenuItem.Click += new System.EventHandler(this.cancellaIscrizioneToolStripMenuItem_Click);
            // 
            // inserisciCertificatoMedicoToolStripMenuItem
            // 
            this.inserisciCertificatoMedicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciToolStripMenuItem,
            this.stampaToolStripMenuItem});
            this.inserisciCertificatoMedicoToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.warning39;
            this.inserisciCertificatoMedicoToolStripMenuItem.Name = "inserisciCertificatoMedicoToolStripMenuItem";
            this.inserisciCertificatoMedicoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.inserisciCertificatoMedicoToolStripMenuItem.Text = "Certificato medico";
            // 
            // inserisciToolStripMenuItem
            // 
            this.inserisciToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.round75;
            this.inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            this.inserisciToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.inserisciToolStripMenuItem.Text = "Inserisci";
            this.inserisciToolStripMenuItem.Click += new System.EventHandler(this.inserisciToolStripMenuItem_Click);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.print45;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stampaToolStripMenuItem.Text = "Stampa";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // rinnovaIscrizioneToolStripMenuItem
            // 
            this.rinnovaIscrizioneToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.refresh62;
            this.rinnovaIscrizioneToolStripMenuItem.Name = "rinnovaIscrizioneToolStripMenuItem";
            this.rinnovaIscrizioneToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.rinnovaIscrizioneToolStripMenuItem.Text = "Rinnova iscrizione";
            this.rinnovaIscrizioneToolStripMenuItem.Click += new System.EventHandler(this.rinnovaIscrizioneToolStripMenuItem_Click);
            // 
            // stampaIscrittiToolStripMenuItem
            // 
            this.stampaIscrittiToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.print45;
            this.stampaIscrittiToolStripMenuItem.Name = "stampaIscrittiToolStripMenuItem";
            this.stampaIscrittiToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.stampaIscrittiToolStripMenuItem.Text = "Stampa iscritti";
            // 
            // inviaComunicazioneAgliIscrittiToolStripMenuItem
            // 
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.sMSToolStripMenuItem});
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.center13;
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem.Name = "inviaComunicazioneAgliIscrittiToolStripMenuItem";
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.inviaComunicazioneAgliIscrittiToolStripMenuItem.Text = "Invia comunicazione agli iscritti";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sMSToolStripMenuItem.Text = "SMS";
            this.sMSToolStripMenuItem.Click += new System.EventHandler(this.sMSToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fatturaToolStripMenuItem,
            this.stampaFatturePerAnnoToolStripMenuItem,
            this.nominativoClientiToolStripMenuItem});
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            // 
            // fatturaToolStripMenuItem
            // 
            this.fatturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaToolStripMenuItem,
            this.cancellaFatturaErrataToolStripMenuItem});
            this.fatturaToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.dollar178;
            this.fatturaToolStripMenuItem.Name = "fatturaToolStripMenuItem";
            this.fatturaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.fatturaToolStripMenuItem.Text = "Fattura";
            // 
            // nuovaToolStripMenuItem
            // 
            this.nuovaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perSocioToolStripMenuItem,
            this.genericaToolStripMenuItem});
            this.nuovaToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.round75;
            this.nuovaToolStripMenuItem.Name = "nuovaToolStripMenuItem";
            this.nuovaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.nuovaToolStripMenuItem.Text = "Nuova";
            // 
            // perSocioToolStripMenuItem
            // 
            this.perSocioToolStripMenuItem.Name = "perSocioToolStripMenuItem";
            this.perSocioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.perSocioToolStripMenuItem.Text = "Per socio";
            this.perSocioToolStripMenuItem.Click += new System.EventHandler(this.perSocioToolStripMenuItem_Click);
            // 
            // genericaToolStripMenuItem
            // 
            this.genericaToolStripMenuItem.Name = "genericaToolStripMenuItem";
            this.genericaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.genericaToolStripMenuItem.Text = "Generica";
            this.genericaToolStripMenuItem.Click += new System.EventHandler(this.genericaToolStripMenuItem_Click);
            // 
            // cancellaFatturaErrataToolStripMenuItem
            // 
            this.cancellaFatturaErrataToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.delete85;
            this.cancellaFatturaErrataToolStripMenuItem.Name = "cancellaFatturaErrataToolStripMenuItem";
            this.cancellaFatturaErrataToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cancellaFatturaErrataToolStripMenuItem.Text = "Cancella fattura errata";
            this.cancellaFatturaErrataToolStripMenuItem.Click += new System.EventHandler(this.cancellaFatturaErrataToolStripMenuItem_Click);
            // 
            // stampaFatturePerAnnoToolStripMenuItem
            // 
            this.stampaFatturePerAnnoToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.print45;
            this.stampaFatturePerAnnoToolStripMenuItem.Name = "stampaFatturePerAnnoToolStripMenuItem";
            this.stampaFatturePerAnnoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.stampaFatturePerAnnoToolStripMenuItem.Text = "Stampa fatture per anno";
            this.stampaFatturePerAnnoToolStripMenuItem.Click += new System.EventHandler(this.stampaFatturePerAnnoToolStripMenuItem_Click);
            // 
            // nominativoClientiToolStripMenuItem
            // 
            this.nominativoClientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.cancellaToolStripMenuItem1});
            this.nominativoClientiToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.center13;
            this.nominativoClientiToolStripMenuItem.Name = "nominativoClientiToolStripMenuItem";
            this.nominativoClientiToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.nominativoClientiToolStripMenuItem.Text = "Nominativo clienti";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // cancellaToolStripMenuItem1
            // 
            this.cancellaToolStripMenuItem1.Name = "cancellaToolStripMenuItem1";
            this.cancellaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cancellaToolStripMenuItem1.Text = "Cancella";
            this.cancellaToolStripMenuItem1.Click += new System.EventHandler(this.cancellaToolStripMenuItem1_Click);
            // 
            // ingressiDanzantiToolStripMenuItem
            // 
            this.ingressiDanzantiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventoToolStripMenuItem,
            this.prenotazioneTavoliToolStripMenuItem,
            this.visualizzaIngressiToolStripMenuItem});
            this.ingressiDanzantiToolStripMenuItem.Name = "ingressiDanzantiToolStripMenuItem";
            this.ingressiDanzantiToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ingressiDanzantiToolStripMenuItem.Text = "Ingressi Danzanti";
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaNuovoToolStripMenuItem,
            this.cancellaToolStripMenuItem});
            this.eventoToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.star174;
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // creaNuovoToolStripMenuItem
            // 
            this.creaNuovoToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.round75;
            this.creaNuovoToolStripMenuItem.Name = "creaNuovoToolStripMenuItem";
            this.creaNuovoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.creaNuovoToolStripMenuItem.Text = "Crea nuovo";
            this.creaNuovoToolStripMenuItem.Click += new System.EventHandler(this.creaNuovoToolStripMenuItem_Click);
            // 
            // cancellaToolStripMenuItem
            // 
            this.cancellaToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.delete85;
            this.cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            this.cancellaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cancellaToolStripMenuItem.Text = "Cancella";
            this.cancellaToolStripMenuItem.Click += new System.EventHandler(this.cancellaToolStripMenuItem_Click);
            // 
            // prenotazioneTavoliToolStripMenuItem
            // 
            this.prenotazioneTavoliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prenotaTavoloToolStripMenuItem,
            this.stampaPrenotazioniToolStripMenuItem});
            this.prenotazioneTavoliToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.location44;
            this.prenotazioneTavoliToolStripMenuItem.Name = "prenotazioneTavoliToolStripMenuItem";
            this.prenotazioneTavoliToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.prenotazioneTavoliToolStripMenuItem.Text = "Prenotazione tavoli";
            // 
            // prenotaTavoloToolStripMenuItem
            // 
            this.prenotaTavoloToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.round75;
            this.prenotaTavoloToolStripMenuItem.Name = "prenotaTavoloToolStripMenuItem";
            this.prenotaTavoloToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.prenotaTavoloToolStripMenuItem.Text = "Prenota tavolo";
            this.prenotaTavoloToolStripMenuItem.Click += new System.EventHandler(this.prenotaTavoloToolStripMenuItem_Click);
            // 
            // stampaPrenotazioniToolStripMenuItem
            // 
            this.stampaPrenotazioniToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.print45;
            this.stampaPrenotazioniToolStripMenuItem.Name = "stampaPrenotazioniToolStripMenuItem";
            this.stampaPrenotazioniToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.stampaPrenotazioniToolStripMenuItem.Text = "Stampa prenotazioni";
            this.stampaPrenotazioniToolStripMenuItem.Click += new System.EventHandler(this.stampaPrenotazioniToolStripMenuItem_Click);
            // 
            // visualizzaIngressiToolStripMenuItem
            // 
            this.visualizzaIngressiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.perMeseToolStripMenuItem,
            this.perEventoToolStripMenuItem});
            this.visualizzaIngressiToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.eye106;
            this.visualizzaIngressiToolStripMenuItem.Name = "visualizzaIngressiToolStripMenuItem";
            this.visualizzaIngressiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.visualizzaIngressiToolStripMenuItem.Text = "Visualizza ingressi";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.liveToolStripMenuItem.Text = "Live";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // perMeseToolStripMenuItem
            // 
            this.perMeseToolStripMenuItem.Name = "perMeseToolStripMenuItem";
            this.perMeseToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.perMeseToolStripMenuItem.Text = "Per mese";
            // 
            // perEventoToolStripMenuItem
            // 
            this.perEventoToolStripMenuItem.Name = "perEventoToolStripMenuItem";
            this.perEventoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.perEventoToolStripMenuItem.Text = "Per evento";
            // 
            // serviziToolStripMenuItem
            // 
            this.serviziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abbonamentiToolStripMenuItem});
            this.serviziToolStripMenuItem.Name = "serviziToolStripMenuItem";
            this.serviziToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.serviziToolStripMenuItem.Text = "Servizi";
            // 
            // abbonamentiToolStripMenuItem
            // 
            this.abbonamentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definisciNuovaTipologiaToolStripMenuItem,
            this.modificaTipologiaToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.abbonamentiToolStripMenuItem.Name = "abbonamentiToolStripMenuItem";
            this.abbonamentiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abbonamentiToolStripMenuItem.Text = "Abbonamenti";
            // 
            // definisciNuovaTipologiaToolStripMenuItem
            // 
            this.definisciNuovaTipologiaToolStripMenuItem.Name = "definisciNuovaTipologiaToolStripMenuItem";
            this.definisciNuovaTipologiaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.definisciNuovaTipologiaToolStripMenuItem.Text = "Definisci nuova tipologia";
            this.definisciNuovaTipologiaToolStripMenuItem.Click += new System.EventHandler(this.definisciNuovaTipologiaToolStripMenuItem_Click);
            // 
            // modificaTipologiaToolStripMenuItem
            // 
            this.modificaTipologiaToolStripMenuItem.Name = "modificaTipologiaToolStripMenuItem";
            this.modificaTipologiaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.modificaTipologiaToolStripMenuItem.Text = "Modifica tipologia";
            this.modificaTipologiaToolStripMenuItem.Click += new System.EventHandler(this.modificaTipologiaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // cddToolStripMenuItem
            // 
            this.cddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definisciInizioFineStagioneToolStripMenuItem,
            this.stampanteFattureToolStripMenuItem,
            this.accountEmailToolStripMenuItem,
            this.accountClickatellToolStripMenuItem});
            this.cddToolStripMenuItem.Name = "cddToolStripMenuItem";
            this.cddToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cddToolStripMenuItem.Text = "Impostazioni";
            // 
            // definisciInizioFineStagioneToolStripMenuItem
            // 
            this.definisciInizioFineStagioneToolStripMenuItem.Name = "definisciInizioFineStagioneToolStripMenuItem";
            this.definisciInizioFineStagioneToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.definisciInizioFineStagioneToolStripMenuItem.Text = "Definisci inizio / fine stagione";
            this.definisciInizioFineStagioneToolStripMenuItem.Click += new System.EventHandler(this.definisciInizioFineStagioneToolStripMenuItem_Click);
            // 
            // stampanteFattureToolStripMenuItem
            // 
            this.stampanteFattureToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.print45;
            this.stampanteFattureToolStripMenuItem.Name = "stampanteFattureToolStripMenuItem";
            this.stampanteFattureToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.stampanteFattureToolStripMenuItem.Text = "Stampante fatture";
            this.stampanteFattureToolStripMenuItem.Click += new System.EventHandler(this.stampanteFattureToolStripMenuItem_Click);
            // 
            // accountEmailToolStripMenuItem
            // 
            this.accountEmailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiNuovoToolStripMenuItem});
            this.accountEmailToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources.Communication_gmail_icon;
            this.accountEmailToolStripMenuItem.Name = "accountEmailToolStripMenuItem";
            this.accountEmailToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.accountEmailToolStripMenuItem.Text = "Account gmail";
            // 
            // aggiungiNuovoToolStripMenuItem
            // 
            this.aggiungiNuovoToolStripMenuItem.Name = "aggiungiNuovoToolStripMenuItem";
            this.aggiungiNuovoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aggiungiNuovoToolStripMenuItem.Text = "Aggiungi nuovo";
            this.aggiungiNuovoToolStripMenuItem.Click += new System.EventHandler(this.aggiungiNuovoToolStripMenuItem_Click);
            // 
            // accountClickatellToolStripMenuItem
            // 
            this.accountClickatellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiNuovoToolStripMenuItem1});
            this.accountClickatellToolStripMenuItem.Image = global::GestioneLibroSoci.Properties.Resources._16543a7a6f686214dd2064b3d96e68fb_128x128;
            this.accountClickatellToolStripMenuItem.Name = "accountClickatellToolStripMenuItem";
            this.accountClickatellToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.accountClickatellToolStripMenuItem.Text = "Account clickatell";
            // 
            // aggiungiNuovoToolStripMenuItem1
            // 
            this.aggiungiNuovoToolStripMenuItem1.Name = "aggiungiNuovoToolStripMenuItem1";
            this.aggiungiNuovoToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.aggiungiNuovoToolStripMenuItem1.Text = "Aggiungi nuovo";
            this.aggiungiNuovoToolStripMenuItem1.Click += new System.EventHandler(this.aggiungiNuovoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informazioniSuToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // informazioniSuToolStripMenuItem
            // 
            this.informazioniSuToolStripMenuItem.Name = "informazioniSuToolStripMenuItem";
            this.informazioniSuToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.informazioniSuToolStripMenuItem.Text = "Informazioni su Libro soci";
            this.informazioniSuToolStripMenuItem.Click += new System.EventHandler(this.informazioniSuToolStripMenuItem_Click);
            // 
            // tbStagioni
            // 
            this.tbStagioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStagioni.Location = new System.Drawing.Point(0, 24);
            this.tbStagioni.Name = "tbStagioni";
            this.tbStagioni.SelectedIndex = 0;
            this.tbStagioni.Size = new System.Drawing.Size(1350, 705);
            this.tbStagioni.TabIndex = 1;
            // 
            // StampaPDFIscritti
            // 
            this.StampaPDFIscritti.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StampaPDFIscritti_DoWork);
            // 
            // Stampa_moduli
            // 
            this.Stampa_moduli.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Stampa_moduli_PrintPage);
            // 
            // timerStampaModuli
            // 
            this.timerStampaModuli.Interval = 1000;
            this.timerStampaModuli.Tick += new System.EventHandler(this.timerStampaModuli_Tick);
            // 
            // notifica
            // 
            this.notifica.ContextMenuStrip = this.SceltaRapida;
            this.notifica.Icon = ((System.Drawing.Icon)(resources.GetObject("notifica.Icon")));
            this.notifica.Text = "Libro Soci";
            this.notifica.Visible = true;
            // 
            // SceltaRapida
            // 
            this.SceltaRapida.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esci});
            this.SceltaRapida.Name = "SceltaRapida";
            this.SceltaRapida.Size = new System.Drawing.Size(95, 26);
            // 
            // esci
            // 
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(94, 22);
            this.esci.Text = "Esci";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tbStagioni);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro soci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SceltaRapida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciNuovoToolStripMenuItem;
        private System.Windows.Forms.TabControl tbStagioni;
        private System.Windows.Forms.ToolStripMenuItem cddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definisciInizioFineStagioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaAnagraficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rinnovaIscrizioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaIscrittiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker StampaPDFIscritti;
        private System.Windows.Forms.ToolStripMenuItem fatturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genericaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampanteFattureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiNuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inviaComunicazioneAgliIscrittiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciCertificatoMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informazioniSuToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument Stampa_moduli;
        private System.Windows.Forms.Timer timerStampaModuli;
        private System.Windows.Forms.NotifyIcon notifica;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaFatturaErrataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviziToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker StampaCertificati;
        private System.Windows.Forms.ToolStripMenuItem ingressiDanzantiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaNuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenotazioneTavoliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prenotaTavoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaPrenotazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaIscrizioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaIngressiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perMeseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaFatturePerAnnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominativoClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abbonamentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definisciNuovaTipologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaTipologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SceltaRapida;
        private System.Windows.Forms.ToolStripMenuItem esci;
        private System.Windows.Forms.ToolStripMenuItem applicazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountClickatellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiNuovoToolStripMenuItem1;
    }
}

