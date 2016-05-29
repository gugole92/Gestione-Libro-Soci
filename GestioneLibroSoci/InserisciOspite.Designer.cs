namespace GestioneLibroSoci
{
    partial class InserisciOspite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualizzaDati = new System.Windows.Forms.DataGridView();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.checkSocio = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkPagato = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.TesseraN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNominativo
            // 
            this.txtNominativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNominativo.Location = new System.Drawing.Point(281, 35);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(224, 20);
            this.txtNominativo.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nominativo";
            // 
            // txtNote
            // 
            this.txtNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNote.Location = new System.Drawing.Point(281, 79);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(224, 20);
            this.txtNote.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Note";
            // 
            // VisualizzaDati
            // 
            this.VisualizzaDati.AllowUserToAddRows = false;
            this.VisualizzaDati.AllowUserToDeleteRows = false;
            this.VisualizzaDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizzaDati.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VisualizzaDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisualizzaDati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TesseraN,
            this.nomativo,
            this.note,
            this.pagato});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualizzaDati.DefaultCellStyle = dataGridViewCellStyle2;
            this.VisualizzaDati.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VisualizzaDati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.VisualizzaDati.Location = new System.Drawing.Point(0, 132);
            this.VisualizzaDati.Name = "VisualizzaDati";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizzaDati.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VisualizzaDati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisualizzaDati.Size = new System.Drawing.Size(1071, 208);
            this.VisualizzaDati.TabIndex = 92;
            this.VisualizzaDati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualizzaDati_CellClick);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(565, 80);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 93;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(672, 80);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 94;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // checkSocio
            // 
            this.checkSocio.AutoSize = true;
            this.checkSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSocio.Location = new System.Drawing.Point(91, 32);
            this.checkSocio.Name = "checkSocio";
            this.checkSocio.Size = new System.Drawing.Size(39, 24);
            this.checkSocio.TabIndex = 96;
            this.checkSocio.Text = "si";
            this.checkSocio.UseVisualStyleBackColor = true;
            this.checkSocio.CheckedChanged += new System.EventHandler(this.checkSocio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 95;
            this.label6.Text = "É socio";
            // 
            // checkPagato
            // 
            this.checkPagato.AutoSize = true;
            this.checkPagato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPagato.Location = new System.Drawing.Point(660, 32);
            this.checkPagato.Name = "checkPagato";
            this.checkPagato.Size = new System.Drawing.Size(39, 24);
            this.checkPagato.TabIndex = 98;
            this.checkPagato.Text = "si";
            this.checkPagato.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Pagato";
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(778, 80);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 99;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // TesseraN
            // 
            this.TesseraN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TesseraN.HeaderText = "N° T.";
            this.TesseraN.Name = "TesseraN";
            this.TesseraN.Width = 57;
            // 
            // nomativo
            // 
            this.nomativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nomativo.HeaderText = "NOMINATIVO";
            this.nomativo.Name = "nomativo";
            this.nomativo.ReadOnly = true;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.note.HeaderText = "NOTE";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // pagato
            // 
            this.pagato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pagato.HeaderText = "PAGATO";
            this.pagato.Name = "pagato";
            this.pagato.Width = 76;
            // 
            // InserisciOspite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 340);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.checkPagato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkSocio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.VisualizzaDati);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InserisciOspite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserisci ospite";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VisualizzaDati;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.CheckBox checkSocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkPagato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn TesseraN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagato;
    }
}