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
            Imposta = new Button();
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
            Cassaforte.Click += label1_Click;
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
            // Imposta
            // 
            Imposta.Location = new Point(63, 64);
            Imposta.Name = "Imposta";
            Imposta.Size = new Size(75, 23);
            Imposta.TabIndex = 3;
            Imposta.Text = "button1";
            Imposta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Imposta);
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
        private Button Imposta;
    }
}
