namespace _08_CodaLibri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il libro:";
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(155, 23);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(132, 22);
            this.txtLibro.TabIndex = 1;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(126, 53);
            this.btnInserisci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(189, 28);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "Inserisci in coda di Stampa";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(126, 99);
            this.btnStampa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(189, 44);
            this.btnStampa.TabIndex = 3;
            this.btnStampa.Text = "Stampa primo elemento";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 156);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnStampa;
    }
}

