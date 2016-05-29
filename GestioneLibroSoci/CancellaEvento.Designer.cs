namespace GestioneLibroSoci
{
    partial class CancellaEvento
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
            this.txtGiorno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaEventi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.CaricaEventi = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtGiorno
            // 
            this.txtGiorno.Location = new System.Drawing.Point(141, 70);
            this.txtGiorno.Mask = "00/00/0000";
            this.txtGiorno.Name = "txtGiorno";
            this.txtGiorno.ReadOnly = true;
            this.txtGiorno.Size = new System.Drawing.Size(100, 20);
            this.txtGiorno.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Data evento:";
            // 
            // listaEventi
            // 
            this.listaEventi.FormattingEnabled = true;
            this.listaEventi.Location = new System.Drawing.Point(141, 30);
            this.listaEventi.Name = "listaEventi";
            this.listaEventi.Size = new System.Drawing.Size(274, 21);
            this.listaEventi.TabIndex = 57;
            this.listaEventi.SelectedIndexChanged += new System.EventHandler(this.listaEventi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nome evento:";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(340, 102);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 60;
            this.btnConferma.Text = "Cancella";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // CaricaEventi
            // 
            this.CaricaEventi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CaricaEventi_DoWork);
            this.CaricaEventi.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CaricaEventi_RunWorkerCompleted);
            // 
            // CancellaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 146);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtGiorno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaEventi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CancellaEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancella evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtGiorno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaEventi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConferma;
        private System.ComponentModel.BackgroundWorker CaricaEventi;
    }
}