namespace GestioneLibroSoci
{
    partial class CercaNominativo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNominativo = new MattBerther.Controls.AutoCompleteComboBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caricaNominativi = new System.ComponentModel.BackgroundWorker();
            this.txtpIVA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Nella prossima schermata puoi modificare i dati del cliente.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Seleziona solo il nominativo da modificare e fai clic su Conferma.";
            // 
            // txtNominativo
            // 
            this.txtNominativo.FormattingEnabled = true;
            this.txtNominativo.LimitToList = true;
            this.txtNominativo.Location = new System.Drawing.Point(132, 21);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(270, 21);
            this.txtNominativo.TabIndex = 87;
            this.txtNominativo.SelectedIndexChanged += new System.EventHandler(this.txtNominativo_SelectedIndexChanged);
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(430, 156);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 82;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nominativo";
            // 
            // caricaNominativi
            // 
            this.caricaNominativi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.caricaNominativi_DoWork);
            this.caricaNominativi.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.caricaNominativi_RunWorkerCompleted);
            // 
            // txtpIVA
            // 
            this.txtpIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpIVA.Location = new System.Drawing.Point(132, 139);
            this.txtpIVA.Name = "txtpIVA";
            this.txtpIVA.ReadOnly = true;
            this.txtpIVA.ShortcutsEnabled = false;
            this.txtpIVA.Size = new System.Drawing.Size(118, 20);
            this.txtpIVA.TabIndex = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 99;
            this.label11.Text = "P. IVA";
            // 
            // txtCF
            // 
            this.txtCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCF.Location = new System.Drawing.Point(132, 100);
            this.txtCF.Name = "txtCF";
            this.txtCF.ReadOnly = true;
            this.txtCF.Size = new System.Drawing.Size(118, 20);
            this.txtCF.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Codice Fiscale";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndirizzo.Location = new System.Drawing.Point(132, 61);
            this.txtIndirizzo.MaxLength = 40;
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.ReadOnly = true;
            this.txtIndirizzo.Size = new System.Drawing.Size(270, 20);
            this.txtIndirizzo.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Indirizzo";
            // 
            // CercaNominativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 207);
            this.Controls.Add(this.txtpIVA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CercaNominativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerca nominativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MattBerther.Controls.AutoCompleteComboBox txtNominativo;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker caricaNominativi;
        private System.Windows.Forms.TextBox txtpIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label2;
    }
}