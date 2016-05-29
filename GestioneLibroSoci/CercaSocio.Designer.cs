namespace GestioneLibroSoci
{
    partial class CercaSocio
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CaricaSoci = new System.ComponentModel.BackgroundWorker();
            this.lista_Soci = new System.Windows.Forms.DataGridView();
            this.Tessera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Soci)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Conferma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(134, 17);
            this.info.Text = "Caricamento database...";
            // 
            // txtCodice
            // 
            this.txtCodice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodice.Location = new System.Drawing.Point(242, 102);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(104, 20);
            this.txtCodice.TabIndex = 51;
            this.txtCodice.TextChanged += new System.EventHandler(this.txtCodice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ricerca socio per tessera:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(242, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 20);
            this.txtNome.TabIndex = 48;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ricerca socio per nome:";
            // 
            // txtCognome
            // 
            this.txtCognome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCognome.Location = new System.Drawing.Point(242, 22);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(195, 20);
            this.txtCognome.TabIndex = 45;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ricerca socio per cognome:";
            // 
            // CaricaSoci
            // 
            this.CaricaSoci.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CaricaSoci_DoWork);
            this.CaricaSoci.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CaricaSoci_RunWorkerCompleted);
            // 
            // lista_Soci
            // 
            this.lista_Soci.AllowUserToAddRows = false;
            this.lista_Soci.AllowUserToDeleteRows = false;
            this.lista_Soci.AllowUserToOrderColumns = true;
            this.lista_Soci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.lista_Soci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_Soci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tessera,
            this.cognome,
            this.nome,
            this.indirizzo,
            this.comune});
            this.lista_Soci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lista_Soci.Location = new System.Drawing.Point(0, 146);
            this.lista_Soci.MultiSelect = false;
            this.lista_Soci.Name = "lista_Soci";
            this.lista_Soci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista_Soci.Size = new System.Drawing.Size(669, 103);
            this.lista_Soci.TabIndex = 53;
            // 
            // Tessera
            // 
            this.Tessera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tessera.HeaderText = "T n°";
            this.Tessera.Name = "Tessera";
            this.Tessera.Width = 52;
            // 
            // cognome
            // 
            this.cognome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cognome.HeaderText = "Cognome";
            this.cognome.Name = "cognome";
            this.cognome.Width = 77;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // indirizzo
            // 
            this.indirizzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.indirizzo.HeaderText = "Indirizzo";
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.Width = 70;
            // 
            // comune
            // 
            this.comune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comune.HeaderText = "Comune";
            this.comune.Name = "comune";
            // 
            // CercaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 271);
            this.Controls.Add(this.lista_Soci);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CercaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerca socio";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_Soci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker CaricaSoci;
        private System.Windows.Forms.DataGridView lista_Soci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tessera;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comune;
    }
}