namespace GestioneLibroSoci
{
    partial class Prenotazione_tavolo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.txtGiorno = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.listaEventi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAvanzo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumTavolo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTavoloDa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VisualizzaDati = new System.Windows.Forms.DataGridView();
            this.nTessera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPersone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tavoloDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntavolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avanzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConferma = new System.Windows.Forms.Button();
            this.checkPagato = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSocio = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.caricaEventi = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(606, 188);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(122, 23);
            this.btnModifica.TabIndex = 105;
            this.btnModifica.Text = "Modifica prenotazione";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(786, 188);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(132, 23);
            this.btnCancella.TabIndex = 104;
            this.btnCancella.Text = "Cancella prenotazione";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // txtGiorno
            // 
            this.txtGiorno.Location = new System.Drawing.Point(487, 192);
            this.txtGiorno.Mask = "00/00/0000";
            this.txtGiorno.Name = "txtGiorno";
            this.txtGiorno.ReadOnly = true;
            this.txtGiorno.Size = new System.Drawing.Size(67, 20);
            this.txtGiorno.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-2, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 11);
            this.panel1.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 101;
            this.label11.Text = "Data";
            // 
            // listaEventi
            // 
            this.listaEventi.FormattingEnabled = true;
            this.listaEventi.Location = new System.Drawing.Point(122, 191);
            this.listaEventi.Name = "listaEventi";
            this.listaEventi.Size = new System.Drawing.Size(224, 21);
            this.listaEventi.TabIndex = 100;
            this.listaEventi.SelectedIndexChanged += new System.EventHandler(this.listaEventi_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 99;
            this.label10.Text = "Evento";
            // 
            // txtNote
            // 
            this.txtNote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNote.Location = new System.Drawing.Point(487, 106);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(241, 20);
            this.txtNote.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Note";
            // 
            // txtAvanzo
            // 
            this.txtAvanzo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAvanzo.Location = new System.Drawing.Point(809, 71);
            this.txtAvanzo.Name = "txtAvanzo";
            this.txtAvanzo.Size = new System.Drawing.Size(50, 20);
            this.txtAvanzo.TabIndex = 96;
            this.txtAvanzo.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 95;
            this.label8.Text = "Avanzo";
            // 
            // txtNumTavolo
            // 
            this.txtNumTavolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumTavolo.Location = new System.Drawing.Point(999, 35);
            this.txtNumTavolo.Name = "txtNumTavolo";
            this.txtNumTavolo.Size = new System.Drawing.Size(50, 20);
            this.txtNumTavolo.TabIndex = 94;
            this.txtNumTavolo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(906, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 93;
            this.label7.Text = "N° tavolo";
            // 
            // txtTavoloDa
            // 
            this.txtTavoloDa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTavoloDa.Location = new System.Drawing.Point(809, 38);
            this.txtTavoloDa.Name = "txtTavoloDa";
            this.txtTavoloDa.Size = new System.Drawing.Size(50, 20);
            this.txtTavoloDa.TabIndex = 92;
            this.txtTavoloDa.Text = "0";
            this.txtTavoloDa.TextChanged += new System.EventHandler(this.txtTavoloDa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Tavolo da";
            // 
            // VisualizzaDati
            // 
            this.VisualizzaDati.AllowUserToAddRows = false;
            this.VisualizzaDati.AllowUserToDeleteRows = false;
            this.VisualizzaDati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizzaDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizzaDati.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.VisualizzaDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisualizzaDati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nTessera,
            this.cognome,
            this.nome,
            this.nPersone,
            this.pagato,
            this.tavoloDa,
            this.ntavolo,
            this.avanzo,
            this.note});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualizzaDati.DefaultCellStyle = dataGridViewCellStyle5;
            this.VisualizzaDati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.VisualizzaDati.Location = new System.Drawing.Point(-2, 275);
            this.VisualizzaDati.MultiSelect = false;
            this.VisualizzaDati.Name = "VisualizzaDati";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizzaDati.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.VisualizzaDati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VisualizzaDati.Size = new System.Drawing.Size(1080, 243);
            this.VisualizzaDati.TabIndex = 90;
            this.VisualizzaDati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualizzaDati_CellClick);
            this.VisualizzaDati.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualizzaDati_CellDoubleClick);
            // 
            // nTessera
            // 
            this.nTessera.FillWeight = 76.14213F;
            this.nTessera.HeaderText = "N° T.";
            this.nTessera.Name = "nTessera";
            this.nTessera.ReadOnly = true;
            // 
            // cognome
            // 
            this.cognome.FillWeight = 105.9645F;
            this.cognome.HeaderText = "COGNOME";
            this.cognome.Name = "cognome";
            this.cognome.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.FillWeight = 105.9645F;
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // nPersone
            // 
            this.nPersone.FillWeight = 105.9645F;
            this.nPersone.HeaderText = "N. PERSONE";
            this.nPersone.Name = "nPersone";
            this.nPersone.ReadOnly = true;
            // 
            // pagato
            // 
            this.pagato.FillWeight = 105.9645F;
            this.pagato.HeaderText = "PAGATO";
            this.pagato.Name = "pagato";
            this.pagato.ReadOnly = true;
            // 
            // tavoloDa
            // 
            this.tavoloDa.HeaderText = "TAVOLO DA";
            this.tavoloDa.Name = "tavoloDa";
            this.tavoloDa.ReadOnly = true;
            // 
            // ntavolo
            // 
            this.ntavolo.HeaderText = "N° TAVOLO";
            this.ntavolo.Name = "ntavolo";
            this.ntavolo.ReadOnly = true;
            // 
            // avanzo
            // 
            this.avanzo.HeaderText = "AVANZO";
            this.avanzo.Name = "avanzo";
            this.avanzo.ReadOnly = true;
            // 
            // note
            // 
            this.note.HeaderText = "NOTE";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(974, 91);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 89;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // checkPagato
            // 
            this.checkPagato.AutoSize = true;
            this.checkPagato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPagato.Location = new System.Drawing.Point(487, 68);
            this.checkPagato.Name = "checkPagato";
            this.checkPagato.Size = new System.Drawing.Size(39, 24);
            this.checkPagato.TabIndex = 88;
            this.checkPagato.Text = "si";
            this.checkPagato.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Pagato";
            // 
            // txtPersone
            // 
            this.txtPersone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPersone.Location = new System.Drawing.Point(487, 38);
            this.txtPersone.Name = "txtPersone";
            this.txtPersone.Size = new System.Drawing.Size(50, 20);
            this.txtPersone.TabIndex = 86;
            this.txtPersone.Text = "0";
            this.txtPersone.TextChanged += new System.EventHandler(this.txtPersone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "N° persone";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(122, 106);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCognome.Location = new System.Drawing.Point(122, 71);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(224, 20);
            this.txtCognome.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Cognome";
            // 
            // checkSocio
            // 
            this.checkSocio.AutoSize = true;
            this.checkSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSocio.Location = new System.Drawing.Point(122, 35);
            this.checkSocio.Name = "checkSocio";
            this.checkSocio.Size = new System.Drawing.Size(39, 24);
            this.checkSocio.TabIndex = 80;
            this.checkSocio.Text = "si";
            this.checkSocio.UseVisualStyleBackColor = true;
            this.checkSocio.CheckedChanged += new System.EventHandler(this.checkSocio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "É socio";
            // 
            // caricaEventi
            // 
            this.caricaEventi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.caricaEventi_DoWork);
            this.caricaEventi.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.caricaEventi_RunWorkerCompleted);
            // 
            // Prenotazione_tavolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 518);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.txtGiorno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listaEventi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAvanzo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumTavolo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTavoloDa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VisualizzaDati);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.checkPagato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkSocio);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Prenotazione_tavolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prenotazione tavolo";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.MaskedTextBox txtGiorno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox listaEventi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvanzo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumTavolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTavoloDa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView VisualizzaDati;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTessera;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPersone;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagato;
        private System.Windows.Forms.DataGridViewTextBoxColumn tavoloDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntavolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn avanzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.CheckBox checkPagato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSocio;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker caricaEventi;
    }
}