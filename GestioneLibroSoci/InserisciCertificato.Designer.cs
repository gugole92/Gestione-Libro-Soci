namespace GestioneLibroSoci
{
    partial class InserisciCertificato
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
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTessera = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCellulare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Items.AddRange(new object[] {
            "AGONISTICO",
            "NON AGONISTICO"});
            this.cmbTipologia.Location = new System.Drawing.Point(186, 281);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(129, 21);
            this.cmbTipologia.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "Tipo certificato:";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(458, 295);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 105;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(186, 239);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(69, 20);
            this.txtData.TabIndex = 104;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 103;
            this.label9.Text = "Imposta scadenza:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(183, 205);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 16);
            this.lblData.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "Scadenza certificato:";
            // 
            // txtTessera
            // 
            this.txtTessera.AutoSize = true;
            this.txtTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTessera.Location = new System.Drawing.Point(461, 27);
            this.txtTessera.Name = "txtTessera";
            this.txtTessera.Size = new System.Drawing.Size(72, 16);
            this.txtTessera.TabIndex = 100;
            this.txtTessera.Text = "Tessera n.";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(134, 166);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(308, 20);
            this.txtMail.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Email";
            // 
            // txtCellulare
            // 
            this.txtCellulare.Location = new System.Drawing.Point(332, 131);
            this.txtCellulare.Name = "txtCellulare";
            this.txtCellulare.ReadOnly = true;
            this.txtCellulare.Size = new System.Drawing.Size(110, 20);
            this.txtCellulare.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 96;
            this.label8.Text = "Cellulare";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(134, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 94;
            this.label7.Text = "Telefono";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(332, 96);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.ReadOnly = true;
            this.txtCitta.Size = new System.Drawing.Size(110, 20);
            this.txtCitta.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 92;
            this.label5.Text = "Città";
            // 
            // txtVia
            // 
            this.txtVia.Location = new System.Drawing.Point(134, 96);
            this.txtVia.Name = "txtVia";
            this.txtVia.ReadOnly = true;
            this.txtVia.Size = new System.Drawing.Size(110, 20);
            this.txtVia.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Via";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(134, 26);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.ReadOnly = true;
            this.txtCognome.Size = new System.Drawing.Size(224, 20);
            this.txtCognome.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Cognome";
            // 
            // InserisciCertificato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.cmbTipologia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTessera);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCellulare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InserisciCertificato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserisci certificato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipologia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTessera;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCellulare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
    }
}