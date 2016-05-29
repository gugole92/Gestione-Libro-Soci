namespace GestioneLibroSoci
{
    partial class InviaSMS
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
            this.btnCancellaNumero = new System.Windows.Forms.Button();
            this.listaNumeri = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStagione = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.caratteriDisponibili = new System.Windows.Forms.Label();
            this.btnInvia = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.Invio = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancellaNumero
            // 
            this.btnCancellaNumero.Location = new System.Drawing.Point(392, 159);
            this.btnCancellaNumero.Name = "btnCancellaNumero";
            this.btnCancellaNumero.Size = new System.Drawing.Size(97, 23);
            this.btnCancellaNumero.TabIndex = 17;
            this.btnCancellaNumero.Text = "Cancella numero";
            this.btnCancellaNumero.UseVisualStyleBackColor = true;
            this.btnCancellaNumero.Click += new System.EventHandler(this.btnCancellaNumero_Click);
            // 
            // listaNumeri
            // 
            this.listaNumeri.FormattingEnabled = true;
            this.listaNumeri.Location = new System.Drawing.Point(117, 87);
            this.listaNumeri.Name = "listaNumeri";
            this.listaNumeri.Size = new System.Drawing.Size(269, 95);
            this.listaNumeri.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destinatari";
            // 
            // cmbStagione
            // 
            this.cmbStagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStagione.FormattingEnabled = true;
            this.cmbStagione.Location = new System.Drawing.Point(117, 33);
            this.cmbStagione.Name = "cmbStagione";
            this.cmbStagione.Size = new System.Drawing.Size(269, 28);
            this.cmbStagione.TabIndex = 14;
            this.cmbStagione.SelectedIndexChanged += new System.EventHandler(this.cmbStagione_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stagione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Messaggio";
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(117, 207);
            this.txtMessaggio.MaxLength = 160;
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(269, 103);
            this.txtMessaggio.TabIndex = 18;
            this.txtMessaggio.TextChanged += new System.EventHandler(this.txtMessaggio_TextChanged);
            // 
            // caratteriDisponibili
            // 
            this.caratteriDisponibili.AutoSize = true;
            this.caratteriDisponibili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caratteriDisponibili.Location = new System.Drawing.Point(346, 313);
            this.caratteriDisponibili.Name = "caratteriDisponibili";
            this.caratteriDisponibili.Size = new System.Drawing.Size(40, 16);
            this.caratteriDisponibili.TabIndex = 20;
            this.caratteriDisponibili.Text = "0/160";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(414, 287);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 21;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(520, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            // 
            // Invio
            // 
            this.Invio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Invio_DoWork);
            this.Invio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Invio_RunWorkerCompleted);
            // 
            // InviaSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.caratteriDisponibili);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.btnCancellaNumero);
            this.Controls.Add(this.listaNumeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStagione);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InviaSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invia SMS";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancellaNumero;
        private System.Windows.Forms.ListBox listaNumeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStagione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Label caratteriDisponibili;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.ComponentModel.BackgroundWorker Invio;
    }
}