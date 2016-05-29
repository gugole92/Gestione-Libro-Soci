namespace GestioneLibroSoci
{
    partial class InvioEmailAPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvioEmailAPI));
            this.btnCancellaEmail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPivacy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tags = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaMail = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStagione = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.notifica = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.Invio = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancellaEmail
            // 
            this.btnCancellaEmail.Location = new System.Drawing.Point(407, 167);
            this.btnCancellaEmail.Name = "btnCancellaEmail";
            this.btnCancellaEmail.Size = new System.Drawing.Size(78, 23);
            this.btnCancellaEmail.TabIndex = 25;
            this.btnCancellaEmail.Text = "Cancella mail";
            this.btnCancellaEmail.UseVisualStyleBackColor = true;
            this.btnCancellaEmail.Click += new System.EventHandler(this.btnCancellaEmail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Informativa";
            // 
            // txtPivacy
            // 
            this.txtPivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPivacy.Location = new System.Drawing.Point(132, 456);
            this.txtPivacy.Multiline = true;
            this.txtPivacy.Name = "txtPivacy";
            this.txtPivacy.Size = new System.Drawing.Size(486, 90);
            this.txtPivacy.TabIndex = 23;
            this.txtPivacy.Text = resources.GetString("txtPivacy.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tags);
            this.groupBox1.Location = new System.Drawing.Point(516, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 147);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAGS";
            // 
            // tags
            // 
            this.tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tags.FormattingEnabled = true;
            this.tags.ItemHeight = 20;
            this.tags.Items.AddRange(new object[] {
            "<NOME>",
            "<COGNOME>",
            "<TESSERA>",
            "<CODICE>"});
            this.tags.Location = new System.Drawing.Point(3, 16);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(235, 128);
            this.tags.TabIndex = 0;
            this.tags.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tags_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Messaggio";
            // 
            // listaMail
            // 
            this.listaMail.FormattingEnabled = true;
            this.listaMail.Location = new System.Drawing.Point(132, 95);
            this.listaMail.Name = "listaMail";
            this.listaMail.Size = new System.Drawing.Size(269, 95);
            this.listaMail.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Destinatari";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOggetto.Location = new System.Drawing.Point(132, 216);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(269, 26);
            this.txtOggetto.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oggetto";
            // 
            // cmbStagione
            // 
            this.cmbStagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStagione.FormattingEnabled = true;
            this.cmbStagione.Location = new System.Drawing.Point(132, 41);
            this.cmbStagione.Name = "cmbStagione";
            this.cmbStagione.Size = new System.Drawing.Size(269, 28);
            this.cmbStagione.TabIndex = 16;
            this.cmbStagione.SelectedIndexChanged += new System.EventHandler(this.cmbStagione_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Stagione";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(682, 523);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 14;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(132, 272);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(486, 154);
            this.txtMessaggio.TabIndex = 13;
            // 
            // notifica
            // 
            this.notifica.Text = "notifyIcon1";
            this.notifica.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 26;
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
            // InvioEmailAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 586);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancellaEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPivacy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOggetto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStagione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMessaggio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvioEmailAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvioEmailAPI";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancellaEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPivacy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox tags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStagione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.NotifyIcon notifica;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.ComponentModel.BackgroundWorker Invio;
    }
}