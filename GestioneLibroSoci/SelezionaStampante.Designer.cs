namespace GestioneLibroSoci
{
    partial class SelezionaStampante
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
            this.listaPrt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaPrt
            // 
            this.listaPrt.FormattingEnabled = true;
            this.listaPrt.Location = new System.Drawing.Point(29, 53);
            this.listaPrt.Name = "listaPrt";
            this.listaPrt.Size = new System.Drawing.Size(487, 147);
            this.listaPrt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona una stampante da utilizzare per le fatture";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(441, 222);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 2;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // SelezionaStampante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 266);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaPrt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelezionaStampante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleziona stampante fatture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaPrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConferma;
    }
}