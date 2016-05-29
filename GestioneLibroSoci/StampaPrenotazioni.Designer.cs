namespace GestioneLibroSoci
{
    partial class StampaPrenotazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtGiorno = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listaEventi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.caricaEventi = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(333, 92);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 81;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtGiorno
            // 
            this.txtGiorno.Location = new System.Drawing.Point(122, 64);
            this.txtGiorno.Mask = "00/00/0000";
            this.txtGiorno.Name = "txtGiorno";
            this.txtGiorno.ReadOnly = true;
            this.txtGiorno.Size = new System.Drawing.Size(67, 20);
            this.txtGiorno.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Data";
            // 
            // listaEventi
            // 
            this.listaEventi.FormattingEnabled = true;
            this.listaEventi.Location = new System.Drawing.Point(122, 19);
            this.listaEventi.Name = "listaEventi";
            this.listaEventi.Size = new System.Drawing.Size(286, 21);
            this.listaEventi.TabIndex = 78;
            this.listaEventi.SelectedIndexChanged += new System.EventHandler(this.listaEventi_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Evento";
            // 
            // caricaEventi
            // 
            this.caricaEventi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.caricaEventi_DoWork);
            this.caricaEventi.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.caricaEventi_RunWorkerCompleted);
            // 
            // StampaPrenotazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 135);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtGiorno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listaEventi);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StampaPrenotazioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stampa prenotazioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.MaskedTextBox txtGiorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox listaEventi;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker caricaEventi;
    }
}