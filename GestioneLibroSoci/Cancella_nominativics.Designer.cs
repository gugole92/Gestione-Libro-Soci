﻿namespace GestioneLibroSoci
{
    partial class Cancella_nominativics
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
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.txtpIVA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressivo = new System.Windows.Forms.ToolStripProgressBar();
            this.CancellaNominativi = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNominativo
            // 
            this.txtNominativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNominativo.Location = new System.Drawing.Point(133, 20);
            this.txtNominativo.MaxLength = 40;
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(270, 20);
            this.txtNominativo.TabIndex = 104;
            // 
            // txtpIVA
            // 
            this.txtpIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpIVA.Location = new System.Drawing.Point(133, 143);
            this.txtpIVA.Name = "txtpIVA";
            this.txtpIVA.ShortcutsEnabled = false;
            this.txtpIVA.Size = new System.Drawing.Size(118, 20);
            this.txtpIVA.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "P. IVA";
            // 
            // txtCF
            // 
            this.txtCF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCF.Location = new System.Drawing.Point(133, 102);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(118, 20);
            this.txtCF.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 100;
            this.label9.Text = "Codice Fiscale";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(431, 159);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 99;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndirizzo.Location = new System.Drawing.Point(133, 61);
            this.txtIndirizzo.MaxLength = 40;
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(270, 20);
            this.txtIndirizzo.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Indirizzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Nominativo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.progressivo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 105;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            // 
            // progressivo
            // 
            this.progressivo.Name = "progressivo";
            this.progressivo.Size = new System.Drawing.Size(100, 16);
            // 
            // CancellaNominativi
            // 
            this.CancellaNominativi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CancellaNominativi_DoWork);
            this.CancellaNominativi.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CancellaNominativi_RunWorkerCompleted);
            // 
            // Cancella_nominativics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 207);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.txtpIVA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cancella_nominativics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancella nominativi";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.TextBox txtpIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.ToolStripProgressBar progressivo;
        private System.ComponentModel.BackgroundWorker CancellaNominativi;
    }
}