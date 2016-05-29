﻿namespace GestioneLibroSoci
{
    partial class Fattura_Generica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fattura_Generica));
            this.cmbDescrizione = new MattBerther.Controls.AutoCompleteComboBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFattura = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtIvaCalcolata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImponibile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAliquota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.txtNominativo = new MattBerther.Controls.AutoCompleteComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDescrizione
            // 
            this.cmbDescrizione.FormattingEnabled = true;
            this.cmbDescrizione.LimitToList = true;
            this.cmbDescrizione.Location = new System.Drawing.Point(156, 174);
            this.cmbDescrizione.MaxLength = 90;
            this.cmbDescrizione.Name = "cmbDescrizione";
            this.cmbDescrizione.Size = new System.Drawing.Size(307, 21);
            this.cmbDescrizione.TabIndex = 112;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(509, 70);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(69, 20);
            this.txtData.TabIndex = 109;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(156, 73);
            this.txtIndirizzo.MaxLength = 40;
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(307, 20);
            this.txtIndirizzo.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 106;
            this.label12.Text = "Indirizzo cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 105;
            this.label10.Text = "Nominativo cliente";
            // 
            // txtCF
            // 
            this.txtCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCF.Location = new System.Drawing.Point(156, 108);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(118, 20);
            this.txtCF.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 103;
            this.label9.Text = "Codice Fiscale";
            // 
            // lblFattura
            // 
            this.lblFattura.AutoSize = true;
            this.lblFattura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFattura.Location = new System.Drawing.Point(506, 35);
            this.lblFattura.Name = "lblFattura";
            this.lblFattura.Size = new System.Drawing.Size(62, 16);
            this.lblFattura.TabIndex = 102;
            this.lblFattura.Text = "Fattura n.";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(541, 311);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 101;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtIvaCalcolata
            // 
            this.txtIvaCalcolata.Location = new System.Drawing.Point(564, 266);
            this.txtIvaCalcolata.Name = "txtIvaCalcolata";
            this.txtIvaCalcolata.ReadOnly = true;
            this.txtIvaCalcolata.Size = new System.Drawing.Size(52, 20);
            this.txtIvaCalcolata.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Iva calcolata";
            // 
            // txtImponibile
            // 
            this.txtImponibile.Location = new System.Drawing.Point(156, 255);
            this.txtImponibile.Name = "txtImponibile";
            this.txtImponibile.Size = new System.Drawing.Size(52, 20);
            this.txtImponibile.TabIndex = 98;
            this.txtImponibile.TextChanged += new System.EventHandler(this.txtImponibile_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 97;
            this.label7.Text = "Imponibile €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "%";
            // 
            // txtAliquota
            // 
            this.txtAliquota.Location = new System.Drawing.Point(156, 289);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(26, 20);
            this.txtAliquota.TabIndex = 95;
            this.txtAliquota.Text = "22";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "separatore decimale virgola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Aliquota IVA";
            // 
            // txtImporto
            // 
            this.txtImporto.Location = new System.Drawing.Point(564, 231);
            this.txtImporto.Name = "txtImporto";
            this.txtImporto.Size = new System.Drawing.Size(52, 20);
            this.txtImporto.TabIndex = 92;
            this.txtImporto.TextChanged += new System.EventHandler(this.txtImporto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "Importo €";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(156, 218);
            this.txtQuantita.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(42, 20);
            this.txtQuantita.TabIndex = 90;
            this.txtQuantita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Quantità";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Natura del bene";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(517, 108);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 65);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 108;
            this.btnPrint.TabStop = false;
            // 
            // txtNominativo
            // 
            this.txtNominativo.FormattingEnabled = true;
            this.txtNominativo.LimitToList = true;
            this.txtNominativo.Location = new System.Drawing.Point(158, 39);
            this.txtNominativo.MaxLength = 90;
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(307, 21);
            this.txtNominativo.TabIndex = 113;
            this.txtNominativo.SelectedIndexChanged += new System.EventHandler(this.txtNominativo_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtIVA
            // 
            this.txtIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIVA.Location = new System.Drawing.Point(156, 141);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(118, 20);
            this.txtIVA.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 114;
            this.label11.Text = "Partita IVA";
            // 
            // Fattura_Generica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 368);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.cmbDescrizione);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFattura);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtIvaCalcolata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImponibile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAliquota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImporto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Fattura_Generica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuova fattura generica";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MattBerther.Controls.AutoCompleteComboBox cmbDescrizione;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFattura;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtIvaCalcolata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImponibile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAliquota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQuantita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MattBerther.Controls.AutoCompleteComboBox txtNominativo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label11;
    }
}