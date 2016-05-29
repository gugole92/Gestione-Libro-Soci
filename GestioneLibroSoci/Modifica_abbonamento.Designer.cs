namespace GestioneLibroSoci
{
    partial class Modifica_abbonamento
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
            this.btnConferma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.componenti = new System.Windows.Forms.ComboBox();
            this.valido = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lezioni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listaTipologie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.valido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lezioni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Enabled = false;
            this.btnConferma.Location = new System.Drawing.Point(550, 213);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 145;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 144;
            this.label6.Text = "€";
            // 
            // txtQuota
            // 
            this.txtQuota.Enabled = false;
            this.txtQuota.Location = new System.Drawing.Point(252, 184);
            this.txtQuota.MaxLength = 255;
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.Size = new System.Drawing.Size(85, 20);
            this.txtQuota.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 143;
            this.label5.Text = "Quota iscrizione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 141;
            this.label4.Text = "dalla data di emissione";
            // 
            // componenti
            // 
            this.componenti.Enabled = false;
            this.componenti.FormattingEnabled = true;
            this.componenti.Items.AddRange(new object[] {
            "GIORNO/I",
            "MESE/I",
            "ANNO/I"});
            this.componenti.Location = new System.Drawing.Point(336, 131);
            this.componenti.Name = "componenti";
            this.componenti.Size = new System.Drawing.Size(121, 21);
            this.componenti.TabIndex = 140;
            // 
            // valido
            // 
            this.valido.Enabled = false;
            this.valido.Location = new System.Drawing.Point(252, 131);
            this.valido.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.valido.Name = "valido";
            this.valido.Size = new System.Drawing.Size(51, 20);
            this.valido.TabIndex = 139;
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
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Valido per";
            // 
            // lezioni
            // 
            this.lezioni.Enabled = false;
            this.lezioni.Location = new System.Drawing.Point(252, 74);
            this.lezioni.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.lezioni.Name = "lezioni";
            this.lezioni.Size = new System.Drawing.Size(51, 20);
            this.lezioni.TabIndex = 137;
            this.lezioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "Lezioni incluse (da 1 a ∞)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 147;
            this.label9.Text = "Nome abbonamento";
            // 
            // listaTipologie
            // 
            this.listaTipologie.FormattingEnabled = true;
            this.listaTipologie.Location = new System.Drawing.Point(252, 24);
            this.listaTipologie.Name = "listaTipologie";
            this.listaTipologie.Size = new System.Drawing.Size(205, 21);
            this.listaTipologie.TabIndex = 148;
            this.listaTipologie.SelectedIndexChanged += new System.EventHandler(this.listaTipologie_SelectedIndexChanged);
            // 
            // Modifica_abbonamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 277);
            this.Controls.Add(this.listaTipologie);
            this.Controls.Add(this.label9);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Modifica_abbonamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifica abbonamento";
            ((System.ComponentModel.ISupportInitialize)(this.valido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lezioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox componenti;
        private System.Windows.Forms.NumericUpDown valido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lezioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox listaTipologie;
    }
}