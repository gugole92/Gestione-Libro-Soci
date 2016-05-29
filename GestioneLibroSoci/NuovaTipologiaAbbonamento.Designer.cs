namespace GestioneLibroSoci
{
    partial class NuovaTipologiaAbbonamento
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lezioni = new System.Windows.Forms.NumericUpDown();
            this.valido = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.componenti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lezioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(252, 32);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 124;
            this.label9.Text = "Nome abbonamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 125;
            this.label1.Text = "Lezioni incluse (da 1 a ∞)";
            // 
            // lezioni
            // 
            this.lezioni.Location = new System.Drawing.Point(252, 85);
            this.lezioni.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.lezioni.Name = "lezioni";
            this.lezioni.Size = new System.Drawing.Size(51, 20);
            this.lezioni.TabIndex = 126;
            this.lezioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valido
            // 
            this.valido.Location = new System.Drawing.Point(252, 142);
            this.valido.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.valido.Name = "valido";
            this.valido.Size = new System.Drawing.Size(51, 20);
            this.valido.TabIndex = 129;
            this.valido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Valido per";
            // 
            // componenti
            // 
            this.componenti.FormattingEnabled = true;
            this.componenti.Items.AddRange(new object[] {
            "GIORNO/I",
            "MESE/I",
            "ANNO/I"});
            this.componenti.Location = new System.Drawing.Point(336, 142);
            this.componenti.Name = "componenti";
            this.componenti.Size = new System.Drawing.Size(121, 21);
            this.componenti.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "dalla data di emissione";
            // 
            // txtQuota
            // 
            this.txtQuota.Location = new System.Drawing.Point(252, 195);
            this.txtQuota.MaxLength = 255;
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Size = new System.Drawing.Size(85, 20);
            this.txtQuota.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 133;
            this.label5.Text = "Quota iscrizione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "€";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(550, 224);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 135;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // NuovaTipologiaAbbonamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 277);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.componenti);
            this.Controls.Add(this.valido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lezioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NuovaTipologiaAbbonamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuova tipologia abbonamento";
            ((System.ComponentModel.ISupportInitialize)(this.lezioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lezioni;
        private System.Windows.Forms.NumericUpDown valido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox componenti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConferma;
    }
}