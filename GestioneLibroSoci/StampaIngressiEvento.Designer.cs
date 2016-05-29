namespace GestioneLibroSoci
{
    partial class StampaIngressiEvento
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
            this.lblEvento = new System.Windows.Forms.Label();
            this.listaEventi = new System.Windows.Forms.ComboBox();
            this.lblIngressi = new System.Windows.Forms.Label();
            this.btnEsporta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.Carica = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(12, 43);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(155, 24);
            this.lblEvento.TabIndex = 6;
            this.lblEvento.Text = "Seleziona evento";
            // 
            // listaEventi
            // 
            this.listaEventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listaEventi.FormattingEnabled = true;
            this.listaEventi.Location = new System.Drawing.Point(220, 40);
            this.listaEventi.Name = "listaEventi";
            this.listaEventi.Size = new System.Drawing.Size(321, 32);
            this.listaEventi.TabIndex = 7;
            // 
            // lblIngressi
            // 
            this.lblIngressi.AutoSize = true;
            this.lblIngressi.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngressi.Location = new System.Drawing.Point(146, 94);
            this.lblIngressi.Name = "lblIngressi";
            this.lblIngressi.Size = new System.Drawing.Size(287, 152);
            this.lblIngressi.TabIndex = 21;
            this.lblIngressi.Text = "000";
            // 
            // btnEsporta
            // 
            this.btnEsporta.Location = new System.Drawing.Point(466, 254);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(75, 23);
            this.btnEsporta.TabIndex = 22;
            this.btnEsporta.Text = "Esporta";
            this.btnEsporta.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(119, 17);
            this.info.Text = "Caricamento eventi...";
            // 
            // Carica
            // 
            this.Carica.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Carica_DoWork);
            this.Carica.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Carica_RunWorkerCompleted);
            // 
            // StampaIngressiEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.lblIngressi);
            this.Controls.Add(this.listaEventi);
            this.Controls.Add(this.lblEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StampaIngressiEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stampa ingressi per evento";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox listaEventi;
        private System.Windows.Forms.Label lblIngressi;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.ComponentModel.BackgroundWorker Carica;

    }
}