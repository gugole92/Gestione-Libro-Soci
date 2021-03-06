﻿namespace GestioneLibroSoci
{
    partial class Pagamento_Abbonamenti
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
            this.label10 = new System.Windows.Forms.Label();
            this.elenco_abbonati = new System.Windows.Forms.DataGridView();
            this.btnConferma = new System.Windows.Forms.Button();
            this.Coppia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scadenza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elenco_abbonati)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Seleziona l\'abbonamento da saldare";
            // 
            // elenco_abbonati
            // 
            this.elenco_abbonati.AllowUserToAddRows = false;
            this.elenco_abbonati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elenco_abbonati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coppia,
            this.pagamento,
            this.emissione,
            this.scadenza,
            this.dataPagamento});
            this.elenco_abbonati.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.elenco_abbonati.Location = new System.Drawing.Point(0, 71);
            this.elenco_abbonati.MultiSelect = false;
            this.elenco_abbonati.Name = "elenco_abbonati";
            this.elenco_abbonati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elenco_abbonati.Size = new System.Drawing.Size(637, 297);
            this.elenco_abbonati.TabIndex = 79;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(512, 27);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 80;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // Coppia
            // 
            this.Coppia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Coppia.HeaderText = "Coppia";
            this.Coppia.Name = "Coppia";
            this.Coppia.ReadOnly = true;
            this.Coppia.Width = 65;
            // 
            // pagamento
            // 
            this.pagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pagamento.HeaderText = "Stato pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 104;
            // 
            // emissione
            // 
            this.emissione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emissione.HeaderText = "Data emissione";
            this.emissione.Name = "emissione";
            this.emissione.ReadOnly = true;
            this.emissione.Width = 96;
            // 
            // scadenza
            // 
            this.scadenza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.scadenza.HeaderText = "Scadenza";
            this.scadenza.Name = "scadenza";
            this.scadenza.ReadOnly = true;
            this.scadenza.Width = 80;
            // 
            // dataPagamento
            // 
            this.dataPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataPagamento.HeaderText = "Data pagamento";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            // 
            // Pagamento_Abbonamenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 368);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.elenco_abbonati);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Pagamento_Abbonamenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salda pagamenti";
            ((System.ComponentModel.ISupportInitialize)(this.elenco_abbonati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView elenco_abbonati;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coppia;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissione;
        private System.Windows.Forms.DataGridViewTextBoxColumn scadenza;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
    }
}