namespace GestioneLibroSoci
{
    partial class Modifica_Socio
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
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLuogoNascita = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtFrazione = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProvResidenza = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProvNascita = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCF
            // 
            this.txtCF.BackColor = System.Drawing.Color.White;
            this.txtCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCF.Location = new System.Drawing.Point(319, 266);
            this.txtCF.MaxLength = 16;
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(136, 20);
            this.txtCF.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 81;
            this.label11.Text = "Codice fiscale";
            // 
            // txtLuogoNascita
            // 
            this.txtLuogoNascita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLuogoNascita.Location = new System.Drawing.Point(319, 234);
            this.txtLuogoNascita.Name = "txtLuogoNascita";
            this.txtLuogoNascita.Size = new System.Drawing.Size(110, 20);
            this.txtLuogoNascita.TabIndex = 10;
            this.txtLuogoNascita.TextChanged += new System.EventHandler(this.txtLuogoNascita_TextChanged);
            this.txtLuogoNascita.Leave += new System.EventHandler(this.txtLuogoNascita_Leave);
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.Location = new System.Drawing.Point(121, 234);
            this.txtDataNascita.Mask = "00/00/0000";
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(110, 20);
            this.txtDataNascita.TabIndex = 9;
            this.txtDataNascita.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Nato il";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nato a";
            // 
            // txtTessera
            // 
            this.txtTessera.AutoSize = true;
            this.txtTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTessera.Location = new System.Drawing.Point(449, 64);
            this.txtTessera.Name = "txtTessera";
            this.txtTessera.Size = new System.Drawing.Size(72, 16);
            this.txtTessera.TabIndex = 76;
            this.txtTessera.Text = "Tessera n.";
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Location = new System.Drawing.Point(121, 368);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(308, 20);
            this.txtMail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Email";
            // 
            // txtCellulare
            // 
            this.txtCellulare.Location = new System.Drawing.Point(319, 333);
            this.txtCellulare.Name = "txtCellulare";
            this.txtCellulare.Size = new System.Drawing.Size(110, 20);
            this.txtCellulare.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(241, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "Cellulare";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 333);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Telefono";
            // 
            // txtCitta
            // 
            this.txtCitta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCitta.Location = new System.Drawing.Point(320, 133);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(110, 20);
            this.txtCitta.TabIndex = 5;
            this.txtCitta.TextChanged += new System.EventHandler(this.txtCitta_TextChanged);
            this.txtCitta.Leave += new System.EventHandler(this.txtCitta_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Comune";
            // 
            // txtVia
            // 
            this.txtVia.Location = new System.Drawing.Point(122, 132);
            this.txtVia.Name = "txtVia";
            this.txtVia.Size = new System.Drawing.Size(110, 20);
            this.txtVia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Indirizzo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCognome.Location = new System.Drawing.Point(122, 62);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(224, 20);
            this.txtCognome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cognome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 83;
            this.label9.Text = "Codice";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(122, 27);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(110, 20);
            this.txtCodice.TabIndex = 1;
            // 
            // txtFrazione
            // 
            this.txtFrazione.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrazione.Location = new System.Drawing.Point(515, 133);
            this.txtFrazione.Name = "txtFrazione";
            this.txtFrazione.Size = new System.Drawing.Size(110, 20);
            this.txtFrazione.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 85;
            this.label12.Text = "Frazione";
            // 
            // txtProvResidenza
            // 
            this.txtProvResidenza.Location = new System.Drawing.Point(122, 167);
            this.txtProvResidenza.MaxLength = 2;
            this.txtProvResidenza.Name = "txtProvResidenza";
            this.txtProvResidenza.Size = new System.Drawing.Size(55, 20);
            this.txtProvResidenza.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 87;
            this.label13.Text = "Provincia";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(320, 164);
            this.txtCap.MaxLength = 5;
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(55, 20);
            this.txtCap.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(255, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 89;
            this.label14.Text = "CAP";
            // 
            // txtProvNascita
            // 
            this.txtProvNascita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvNascita.Location = new System.Drawing.Point(514, 231);
            this.txtProvNascita.MaxLength = 2;
            this.txtProvNascita.Name = "txtProvNascita";
            this.txtProvNascita.Size = new System.Drawing.Size(55, 20);
            this.txtProvNascita.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(448, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 91;
            this.label15.Text = "Provincia";
            // 
            // txtSesso
            // 
            this.txtSesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSesso.Location = new System.Drawing.Point(121, 266);
            this.txtSesso.MaxLength = 1;
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(55, 20);
            this.txtSesso.TabIndex = 12;
            this.txtSesso.TextChanged += new System.EventHandler(this.txtSesso_TextChanged);
            this.txtSesso.Leave += new System.EventHandler(this.txtSesso_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 16);
            this.label16.TabIndex = 93;
            this.label16.Text = "Sesso";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(550, 366);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 94;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // Modifica_Socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 422);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtProvNascita);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProvResidenza);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFrazione);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLuogoNascita);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.label10);
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
            this.Name = "Modifica_Socio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifica socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLuogoNascita;
        private System.Windows.Forms.MaskedTextBox txtDataNascita;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtFrazione;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProvResidenza;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProvNascita;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSalva;
    }
}