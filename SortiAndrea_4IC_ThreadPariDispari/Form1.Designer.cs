namespace SortiAndrea_4IC_ThreadPariDispari
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbThreads = new System.Windows.Forms.ListBox();
            this.btnThread_Pari = new System.Windows.Forms.Button();
            this.btnThread_Dispari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbThreads
            // 
            this.lbThreads.FormattingEnabled = true;
            this.lbThreads.ItemHeight = 16;
            this.lbThreads.Location = new System.Drawing.Point(12, 12);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(776, 260);
            this.lbThreads.TabIndex = 0;
            // 
            // btnThread_Pari
            // 
            this.btnThread_Pari.Location = new System.Drawing.Point(12, 289);
            this.btnThread_Pari.Name = "btnThread_Pari";
            this.btnThread_Pari.Size = new System.Drawing.Size(369, 149);
            this.btnThread_Pari.TabIndex = 1;
            this.btnThread_Pari.Text = "Avvia thread 1 (pari)";
            this.btnThread_Pari.UseVisualStyleBackColor = true;
            this.btnThread_Pari.Click += new System.EventHandler(this.btnThread_Pari_Click);
            // 
            // btnThread_Dispari
            // 
            this.btnThread_Dispari.Location = new System.Drawing.Point(419, 289);
            this.btnThread_Dispari.Name = "btnThread_Dispari";
            this.btnThread_Dispari.Size = new System.Drawing.Size(369, 149);
            this.btnThread_Dispari.TabIndex = 2;
            this.btnThread_Dispari.Text = "Avvia thread 2 (dispari)";
            this.btnThread_Dispari.UseVisualStyleBackColor = true;
            this.btnThread_Dispari.Click += new System.EventHandler(this.btnThread_Dispari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThread_Dispari);
            this.Controls.Add(this.btnThread_Pari);
            this.Controls.Add(this.lbThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbThreads;
        private System.Windows.Forms.Button btnThread_Pari;
        private System.Windows.Forms.Button btnThread_Dispari;
    }
}

