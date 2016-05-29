namespace GestioneLibroSoci
{
    partial class Cancella_fatture
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
            this.btnCancella = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnno = new System.Windows.Forms.ComboBox();
            this.VisualizzaDati = new System.Windows.Forms.DataGridView();
            this.clNominativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImporto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAliquota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProgressivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(258, 26);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(136, 23);
            this.btnCancella.TabIndex = 81;
            this.btnCancella.Text = "Cancella fattura";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-5, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 12);
            this.panel1.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Anno di riferimento:";
            // 
            // cmbAnno
            // 
            this.cmbAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnno.FormattingEnabled = true;
            this.cmbAnno.Location = new System.Drawing.Point(149, 25);
            this.cmbAnno.Name = "cmbAnno";
            this.cmbAnno.Size = new System.Drawing.Size(66, 24);
            this.cmbAnno.TabIndex = 82;
            this.cmbAnno.SelectedIndexChanged += new System.EventHandler(this.cmbAnno_SelectedIndexChanged);
            // 
            // VisualizzaDati
            // 
            this.VisualizzaDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisualizzaDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisualizzaDati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNominativo,
            this.clCF,
            this.clIVA,
            this.clDescrizione,
            this.clImporto,
            this.clAliquota,
            this.clData,
            this.clProgressivo});
            this.VisualizzaDati.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VisualizzaDati.Location = new System.Drawing.Point(0, 100);
            this.VisualizzaDati.MultiSelect = false;
            this.VisualizzaDati.Name = "VisualizzaDati";
            this.VisualizzaDati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisualizzaDati.Size = new System.Drawing.Size(905, 254);
            this.VisualizzaDati.TabIndex = 83;
            // 
            // clNominativo
            // 
            this.clNominativo.HeaderText = "Nominativo";
            this.clNominativo.Name = "clNominativo";
            // 
            // clCF
            // 
            this.clCF.HeaderText = "Codice fiscale";
            this.clCF.Name = "clCF";
            // 
            // clIVA
            // 
            this.clIVA.HeaderText = "P. IVA";
            this.clIVA.Name = "clIVA";
            // 
            // clDescrizione
            // 
            this.clDescrizione.HeaderText = "Descrizione";
            this.clDescrizione.Name = "clDescrizione";
            // 
            // clImporto
            // 
            this.clImporto.HeaderText = "Importo";
            this.clImporto.Name = "clImporto";
            // 
            // clAliquota
            // 
            this.clAliquota.HeaderText = "Aliquota";
            this.clAliquota.Name = "clAliquota";
            // 
            // clData
            // 
            this.clData.HeaderText = "Data";
            this.clData.Name = "clData";
            // 
            // clProgressivo
            // 
            this.clProgressivo.HeaderText = "Progressivo";
            this.clProgressivo.Name = "clProgressivo";
            // 
            // Cancella_fatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 354);
            this.Controls.Add(this.VisualizzaDati);
            this.Controls.Add(this.cmbAnno);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cancella_fatture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancella fattura";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnno;
        private System.Windows.Forms.DataGridView VisualizzaDati;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNominativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImporto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAliquota;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProgressivo;
    }
}