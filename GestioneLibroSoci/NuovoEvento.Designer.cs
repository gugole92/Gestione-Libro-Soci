namespace GestioneLibroSoci
{
    partial class NuovoEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataEvento = new System.Windows.Forms.MonthCalendar();
            this.chkPrenotazione = new System.Windows.Forms.CheckBox();
            this.btnConferma = new System.Windows.Forms.Button();
            this.listaEventi = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenotazione = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaEventi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(153, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 35;
            this.txtNome.Text = "SERATA DANZANTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome dell\'evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Seleziona giorno";
            // 
            // dataEvento
            // 
            this.dataEvento.Location = new System.Drawing.Point(153, 94);
            this.dataEvento.Name = "dataEvento";
            this.dataEvento.TabIndex = 66;
            // 
            // chkPrenotazione
            // 
            this.chkPrenotazione.AutoSize = true;
            this.chkPrenotazione.Location = new System.Drawing.Point(29, 287);
            this.chkPrenotazione.Name = "chkPrenotazione";
            this.chkPrenotazione.Size = new System.Drawing.Size(137, 17);
            this.chkPrenotazione.TabIndex = 71;
            this.chkPrenotazione.Text = "Con prenotazione tavoli";
            this.chkPrenotazione.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(377, 309);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 70;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // listaEventi
            // 
            this.listaEventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEventi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.giorno,
            this.prenotazione});
            this.listaEventi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaEventi.Location = new System.Drawing.Point(0, 364);
            this.listaEventi.Name = "listaEventi";
            this.listaEventi.Size = new System.Drawing.Size(478, 165);
            this.listaEventi.TabIndex = 72;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nome.HeaderText = "Nome serata";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 92;
            // 
            // giorno
            // 
            this.giorno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.giorno.HeaderText = "Giorno";
            this.giorno.Name = "giorno";
            this.giorno.ReadOnly = true;
            this.giorno.Width = 63;
            // 
            // prenotazione
            // 
            this.prenotazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenotazione.HeaderText = "Con prenotazione";
            this.prenotazione.Name = "prenotazione";
            this.prenotazione.ReadOnly = true;
            // 
            // NuovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 529);
            this.Controls.Add(this.listaEventi);
            this.Controls.Add(this.chkPrenotazione);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataEvento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NuovoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuovo evento";
            ((System.ComponentModel.ISupportInitialize)(this.listaEventi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar dataEvento;
        private System.Windows.Forms.CheckBox chkPrenotazione;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.DataGridView listaEventi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn giorno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prenotazione;
    }
}