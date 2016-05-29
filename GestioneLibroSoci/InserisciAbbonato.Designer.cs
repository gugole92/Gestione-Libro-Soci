namespace GestioneLibroSoci
{
    partial class InserisciAbbonato
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSocio1 = new System.Windows.Forms.TextBox();
            this.txtSocio2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbbonamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataEmissione = new System.Windows.Forms.MaskedTextBox();
            this.txtScadenza = new System.Windows.Forms.MaskedTextBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 125;
            this.label9.Text = "Socio 1";
            // 
            // txtSocio1
            // 
            this.txtSocio1.Location = new System.Drawing.Point(134, 33);
            this.txtSocio1.MaxLength = 255;
            this.txtSocio1.Name = "txtSocio1";
            this.txtSocio1.ReadOnly = true;
            this.txtSocio1.Size = new System.Drawing.Size(205, 20);
            this.txtSocio1.TabIndex = 126;
            // 
            // txtSocio2
            // 
            this.txtSocio2.Location = new System.Drawing.Point(134, 72);
            this.txtSocio2.MaxLength = 255;
            this.txtSocio2.Name = "txtSocio2";
            this.txtSocio2.ReadOnly = true;
            this.txtSocio2.Size = new System.Drawing.Size(205, 20);
            this.txtSocio2.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Socio 2";
            // 
            // txtAbbonamento
            // 
            this.txtAbbonamento.Location = new System.Drawing.Point(178, 124);
            this.txtAbbonamento.MaxLength = 255;
            this.txtAbbonamento.Name = "txtAbbonamento";
            this.txtAbbonamento.ReadOnly = true;
            this.txtAbbonamento.Size = new System.Drawing.Size(205, 20);
            this.txtAbbonamento.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Tipo abbonamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 131;
            this.label3.Text = "Scadenza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 133;
            this.label4.Text = "Valido da";
            // 
            // txtDataEmissione
            // 
            this.txtDataEmissione.Location = new System.Drawing.Point(178, 200);
            this.txtDataEmissione.Mask = "00/00/0000";
            this.txtDataEmissione.Name = "txtDataEmissione";
            this.txtDataEmissione.Size = new System.Drawing.Size(76, 20);
            this.txtDataEmissione.TabIndex = 135;
            this.txtDataEmissione.ValidatingType = typeof(System.DateTime);
            // 
            // txtScadenza
            // 
            this.txtScadenza.Location = new System.Drawing.Point(178, 162);
            this.txtScadenza.Mask = "00/00/0000";
            this.txtScadenza.Name = "txtScadenza";
            this.txtScadenza.ReadOnly = true;
            this.txtScadenza.Size = new System.Drawing.Size(76, 20);
            this.txtScadenza.TabIndex = 136;
            this.txtScadenza.ValidatingType = typeof(System.DateTime);
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(376, 240);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 137;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 21);
            this.button1.TabIndex = 138;
            this.button1.Text = "cambia data emissione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InserisciAbbonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtScadenza);
            this.Controls.Add(this.txtDataEmissione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAbbonamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSocio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSocio1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InserisciAbbonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserisci abbonato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSocio1;
        private System.Windows.Forms.TextBox txtSocio2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbbonamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataEmissione;
        private System.Windows.Forms.MaskedTextBox txtScadenza;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button button1;
    }
}