namespace GestioneLibroSoci
{
    partial class MostraOspiti
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
            this.VisualizzaDati = new System.Windows.Forms.DataGridView();
            this.nomativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).BeginInit();
            this.SuspendLayout();
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
            this.nomativo,
            this.note});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualizzaDati.DefaultCellStyle = dataGridViewCellStyle2;
            this.VisualizzaDati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualizzaDati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.VisualizzaDati.Location = new System.Drawing.Point(0, 0);
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
            this.VisualizzaDati.Size = new System.Drawing.Size(1077, 255);
            this.VisualizzaDati.TabIndex = 91;
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
            // MostraOspiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 255);
            this.Controls.Add(this.VisualizzaDati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MostraOspiti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizza ospiti";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizzaDati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VisualizzaDati;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}