namespace GestioneLibroSoci
{
    partial class Elimina_abbonamento
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
            this.listaTipologie = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaTipologie
            // 
            this.listaTipologie.FormattingEnabled = true;
            this.listaTipologie.Location = new System.Drawing.Point(211, 43);
            this.listaTipologie.Name = "listaTipologie";
            this.listaTipologie.Size = new System.Drawing.Size(225, 21);
            this.listaTipologie.TabIndex = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 149;
            this.label9.Text = "Nome abbonamento";
            // 
            // btnConferma
            // 
            this.btnConferma.Enabled = false;
            this.btnConferma.Location = new System.Drawing.Point(361, 96);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 151;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // Elimina_abbonamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 149);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.listaTipologie);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Elimina_abbonamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elimina abbonamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaTipologie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConferma;
    }
}