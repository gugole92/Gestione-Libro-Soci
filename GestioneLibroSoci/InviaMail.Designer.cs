namespace GestioneLibroSoci
{
    partial class InviaMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviaMail));
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStagione = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaMail = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tags = new System.Windows.Forms.ListBox();
            this.txtPivacy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancellaEmail = new System.Windows.Forms.Button();
            this.Invio = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.barra = new System.Windows.Forms.ToolStripProgressBar();
            this.notifica = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessaggio.Location = new System.Drawing.Point(131, 257);
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(486, 154);
            this.txtMessaggio.TabIndex = 0;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(681, 508);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 1;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stagione";
            // 
            // cmbStagione
            // 
            this.cmbStagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStagione.FormattingEnabled = true;
            this.cmbStagione.Location = new System.Drawing.Point(131, 26);
            this.cmbStagione.Name = "cmbStagione";
            this.cmbStagione.Size = new System.Drawing.Size(269, 28);
            this.cmbStagione.TabIndex = 3;
            this.cmbStagione.SelectedIndexChanged += new System.EventHandler(this.cmbStagione_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oggetto";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOggetto.Location = new System.Drawing.Point(131, 201);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(269, 26);
            this.txtOggetto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destinatari";
            // 
            // listaMail
            // 
            this.listaMail.FormattingEnabled = true;
            this.listaMail.Location = new System.Drawing.Point(131, 80);
            this.listaMail.Name = "listaMail";
            this.listaMail.Size = new System.Drawing.Size(269, 95);
            this.listaMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Messaggio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tags);
            this.groupBox1.Location = new System.Drawing.Point(515, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 147);
            this.groupBox1.TabIndex = 9;
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
            // txtPivacy
            // 
            this.txtPivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPivacy.Location = new System.Drawing.Point(131, 441);
            this.txtPivacy.Multiline = true;
            this.txtPivacy.Name = "txtPivacy";
            this.txtPivacy.Size = new System.Drawing.Size(486, 90);
            this.txtPivacy.TabIndex = 10;
            this.txtPivacy.Text = resources.GetString("txtPivacy.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Informativa";
            // 
            // btnCancellaEmail
            // 
            this.btnCancellaEmail.Location = new System.Drawing.Point(406, 152);
            this.btnCancellaEmail.Name = "btnCancellaEmail";
            this.btnCancellaEmail.Size = new System.Drawing.Size(78, 23);
            this.btnCancellaEmail.TabIndex = 12;
            this.btnCancellaEmail.Text = "Cancella mail";
            this.btnCancellaEmail.UseVisualStyleBackColor = true;
            this.btnCancellaEmail.Click += new System.EventHandler(this.btnCancellaEmail_Click);
            // 
            // Invio
            // 
            this.Invio.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Invio_DoWork);
            this.Invio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Invio_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barra,
            this.info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            // 
            // barra
            // 
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(100, 16);
            // 
            // notifica
            // 
            this.notifica.Text = "notifyIcon1";
            this.notifica.Visible = true;
            // 
            // InviaMail
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InviaMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invia mail";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStagione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox tags;
        private System.Windows.Forms.TextBox txtPivacy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancellaEmail;
        private System.ComponentModel.BackgroundWorker Invio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.ToolStripProgressBar barra;
        private System.Windows.Forms.NotifyIcon notifica;
    }
}