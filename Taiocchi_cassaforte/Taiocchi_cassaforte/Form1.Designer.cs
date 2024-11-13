namespace Taiocchi_cassaforte
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cassaforte = new Label();
            Stato = new Label();
            Apertura = new Label();
            label1 = new Label();
            codiceUtente5 = new TextBox();
            Pin = new TextBox();
            label2 = new Label();
            Apri = new Button();
            Chiudi = new Button();
            label3 = new Label();
            CodiceSblocco = new TextBox();
            Sblocca = new Button();
            impostaCodice = new Button();
            label4 = new Label();
            Label_data = new TextBox();
            SuspendLayout();
            // 
            // Cassaforte
            // 
            Cassaforte.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Cassaforte.Location = new Point(605, 158);
            Cassaforte.Name = "Cassaforte";
            Cassaforte.Size = new Size(138, 43);
            Cassaforte.TabIndex = 0;
            Cassaforte.Text = "Cassaforte";
            // 
            // Stato
            // 
            Stato.AutoSize = true;
            Stato.Location = new Point(622, 211);
            Stato.Name = "Stato";
            Stato.Size = new Size(90, 15);
            Stato.TabIndex = 1;
            Stato.Text = "Stato: sbloccata";
            // 
            // Apertura
            // 
            Apertura.AutoSize = true;
            Apertura.Location = new Point(622, 240);
            Apertura.Name = "Apertura";
            Apertura.Size = new Size(93, 15);
            Apertura.TabIndex = 2;
            Apertura.Text = "Apertura: chiusa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 73);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 3;
            label1.Text = "Imposta il codice utente (5 cifre)";
            // 
            // codiceUtente5
            // 
            codiceUtente5.Location = new Point(51, 91);
            codiceUtente5.Name = "codiceUtente5";
            codiceUtente5.Size = new Size(177, 23);
            codiceUtente5.TabIndex = 4;
            // 
            // Pin
            // 
            Pin.Location = new Point(74, 158);
            Pin.Name = "Pin";
            Pin.Size = new Size(106, 23);
            Pin.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 139);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 6;
            label2.Text = "PIN";
            // 
            // Apri
            // 
            Apri.BackColor = Color.FromArgb(0, 192, 0);
            Apri.Location = new Point(346, 91);
            Apri.Name = "Apri";
            Apri.Size = new Size(127, 35);
            Apri.TabIndex = 7;
            Apri.Text = "Apri";
            Apri.UseVisualStyleBackColor = false;
            Apri.Click += Apri_Click;
            // 
            // Chiudi
            // 
            Chiudi.BackColor = Color.Red;
            Chiudi.Location = new Point(346, 161);
            Chiudi.Name = "Chiudi";
            Chiudi.Size = new Size(127, 38);
            Chiudi.TabIndex = 8;
            Chiudi.Text = "Chiudi";
            Chiudi.UseVisualStyleBackColor = false;
            Chiudi.Click += Chiudi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 231);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 9;
            label3.Text = "Codice di sblocco (12 cifre)";
            // 
            // CodiceSblocco
            // 
            CodiceSblocco.Location = new Point(51, 249);
            CodiceSblocco.Name = "CodiceSblocco";
            CodiceSblocco.Size = new Size(150, 23);
            CodiceSblocco.TabIndex = 10;
            // 
            // Sblocca
            // 
            Sblocca.BackColor = Color.FromArgb(0, 192, 192);
            Sblocca.Location = new Point(346, 231);
            Sblocca.Name = "Sblocca";
            Sblocca.Size = new Size(127, 38);
            Sblocca.TabIndex = 11;
            Sblocca.Text = "Sblocca";
            Sblocca.UseVisualStyleBackColor = false;
            Sblocca.Click += Sblocca_Click;
            // 
            // impostaCodice
            // 
            impostaCodice.BackColor = Color.FromArgb(0, 192, 192);
            impostaCodice.Location = new Point(346, 296);
            impostaCodice.Name = "impostaCodice";
            impostaCodice.Size = new Size(127, 35);
            impostaCodice.TabIndex = 12;
            impostaCodice.Text = "Imposta Codice";
            impostaCodice.UseVisualStyleBackColor = false;
            impostaCodice.Click += impostaCodice_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 310);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "Data";
            // 
            // Label_data
            // 
            Label_data.Location = new Point(100, 328);
            Label_data.Name = "Label_data";
            Label_data.Size = new Size(56, 23);
            Label_data.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_data);
            Controls.Add(label4);
            Controls.Add(impostaCodice);
            Controls.Add(Sblocca);
            Controls.Add(CodiceSblocco);
            Controls.Add(label3);
            Controls.Add(Chiudi);
            Controls.Add(Apri);
            Controls.Add(label2);
            Controls.Add(Pin);
            Controls.Add(codiceUtente5);
            Controls.Add(label1);
            Controls.Add(Apertura);
            Controls.Add(Stato);
            Controls.Add(Cassaforte);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Cassaforte;
        private Label Stato;
        private Label Apertura;
        private Label label1;
        private TextBox codiceUtente5;
        private TextBox Pin;
        private Label label2;
        private Button Apri;
        private Button Chiudi;
        private Label label3;
        private TextBox CodiceSblocco;
        private Button Sblocca;
        private Button impostaCodice;
        private Label label4;
        private TextBox Label_data;
    }
}
