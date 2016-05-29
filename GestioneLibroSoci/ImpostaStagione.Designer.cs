namespace GestioneLibroSoci
{
    partial class ImpostaStagione
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataInizio = new System.Windows.Forms.DateTimePicker();
            this.DataFine = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data inizio stagione";
            // 
            // DataInizio
            // 
            this.DataInizio.Location = new System.Drawing.Point(203, 27);
            this.DataInizio.Name = "DataInizio";
            this.DataInizio.Size = new System.Drawing.Size(200, 20);
            this.DataInizio.TabIndex = 1;
            // 
            // DataFine
            // 
            this.DataFine.Location = new System.Drawing.Point(203, 175);
            this.DataFine.Name = "DataFine";
            this.DataFine.Size = new System.Drawing.Size(200, 20);
            this.DataFine.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data fine stagione";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(30, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 51);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "In queste impostazioni definisci la data di inizio e quella di fine stagione. Va " +
    "impostata solo al primo utilizzo del programma in quanto ad ogni inizio stagione" +
    " verrà generato un nuovo libro soci.";
            // 
            // ImpostaStagione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DataFine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataInizio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ImpostaStagione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Imposta stagione";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImpostaStagione_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataInizio;
        private System.Windows.Forms.DateTimePicker DataFine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}