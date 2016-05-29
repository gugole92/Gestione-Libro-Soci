namespace GestioneLibroSoci
{
    partial class Rinnova_iscrizione
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblScadenzaIscrizione = new System.Windows.Forms.Label();
            this.txtScadenzaTessera = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtTessera = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCellulare = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Conferma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScadenzaIscrizione
            // 
            this.lblScadenzaIscrizione.AutoSize = true;
            this.lblScadenzaIscrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScadenzaIscrizione.Location = new System.Drawing.Point(379, 59);
            this.lblScadenzaIscrizione.Name = "lblScadenzaIscrizione";
            this.lblScadenzaIscrizione.Size = new System.Drawing.Size(142, 16);
            this.lblScadenzaIscrizione.TabIndex = 81;
            this.lblScadenzaIscrizione.Text = "Iscrizione valida fino al";
            // 
            // txtScadenzaTessera
            // 
            this.txtScadenzaTessera.Location = new System.Drawing.Point(152, 200);
            this.txtScadenzaTessera.Mask = "00/00/0000";
            this.txtScadenzaTessera.Name = "txtScadenzaTessera";
            this.txtScadenzaTessera.ReadOnly = true;
            this.txtScadenzaTessera.Size = new System.Drawing.Size(65, 20);
            this.txtScadenzaTessera.TabIndex = 80;
            this.txtScadenzaTessera.Text = "3108";
            this.txtScadenzaTessera.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(29, 200);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(117, 16);
            this.lblData.TabIndex = 79;
            this.lblData.Text = "Scadenza tessera";
            // 
            // txtTessera
            // 
            this.txtTessera.AutoSize = true;
            this.txtTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTessera.Location = new System.Drawing.Point(379, 24);
            this.txtTessera.Name = "txtTessera";
            this.txtTessera.Size = new System.Drawing.Size(72, 16);
            this.txtTessera.TabIndex = 78;
            this.txtTessera.Text = "Tessera n.";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(122, 164);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(308, 20);
            this.txtMail.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Email";
            // 
            // txtCellulare
            // 
            this.txtCellulare.Location = new System.Drawing.Point(320, 129);
            this.txtCellulare.Name = "txtCellulare";
            this.txtCellulare.ReadOnly = true;
            this.txtCellulare.Size = new System.Drawing.Size(110, 20);
            this.txtCellulare.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Cellulare";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 129);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(110, 20);
            this.txtTelefono.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Telefono";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(320, 94);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.ReadOnly = true;
            this.txtCitta.Size = new System.Drawing.Size(110, 20);
            this.txtCitta.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 70;
            this.label5.Text = "Città";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(122, 94);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.ReadOnly = true;
            this.txtIndirizzo.Size = new System.Drawing.Size(110, 20);
            this.txtIndirizzo.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Indirizzo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(122, 24);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.ReadOnly = true;
            this.txtCognome.Size = new System.Drawing.Size(224, 20);
            this.txtCognome.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cognome";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Rinnova_iscrizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScadenzaIscrizione);
            this.Controls.Add(this.txtScadenzaTessera);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtTessera);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCellulare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rinnova_iscrizione";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rinnova iscrizione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblScadenzaIscrizione;
        private System.Windows.Forms.MaskedTextBox txtScadenzaTessera;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label txtTessera;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCellulare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}