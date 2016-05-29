namespace GestioneLibroSoci
{
    partial class IngressiLive
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
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblIngressi = new System.Windows.Forms.Label();
            this.listaIngressi = new System.Windows.Forms.ListBox();
            this.timerAggiorna = new System.Windows.Forms.Timer(this.components);
            this.aggiorna = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(27, 29);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(280, 29);
            this.lblEvento.TabIndex = 5;
            this.lblEvento.Text = "Nessun evento registrato";
            // 
            // lblIngressi
            // 
            this.lblIngressi.AutoSize = true;
            this.lblIngressi.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngressi.Location = new System.Drawing.Point(211, 69);
            this.lblIngressi.Name = "lblIngressi";
            this.lblIngressi.Size = new System.Drawing.Size(287, 152);
            this.lblIngressi.TabIndex = 20;
            this.lblIngressi.Text = "000";
            // 
            // listaIngressi
            // 
            this.listaIngressi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaIngressi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaIngressi.FormattingEnabled = true;
            this.listaIngressi.ItemHeight = 29;
            this.listaIngressi.Location = new System.Drawing.Point(0, 233);
            this.listaIngressi.Name = "listaIngressi";
            this.listaIngressi.Size = new System.Drawing.Size(708, 265);
            this.listaIngressi.TabIndex = 21;
            // 
            // timerAggiorna
            // 
            this.timerAggiorna.Interval = 1000;
            this.timerAggiorna.Tick += new System.EventHandler(this.timerAggiorna_Tick);
            // 
            // aggiorna
            // 
            this.aggiorna.DoWork += new System.ComponentModel.DoWorkEventHandler(this.aggiorna_DoWork);
            this.aggiorna.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.aggiorna_RunWorkerCompleted);
            // 
            // IngressiLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 498);
            this.Controls.Add(this.listaIngressi);
            this.Controls.Add(this.lblIngressi);
            this.Controls.Add(this.lblEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IngressiLive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingressi live";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblIngressi;
        private System.Windows.Forms.ListBox listaIngressi;
        private System.Windows.Forms.Timer timerAggiorna;
        private System.ComponentModel.BackgroundWorker aggiorna;
    }
}