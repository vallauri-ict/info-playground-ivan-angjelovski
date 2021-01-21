namespace _24_Gioco_Tresette
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
            this.btnProponi = new System.Windows.Forms.Button();
            this.btnAggiungiCarta = new System.Windows.Forms.Button();
            this.cmbValore = new System.Windows.Forms.ComboBox();
            this.cmbSeme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnProponi
            // 
            this.btnProponi.Location = new System.Drawing.Point(12, 12);
            this.btnProponi.Name = "btnProponi";
            this.btnProponi.Size = new System.Drawing.Size(205, 128);
            this.btnProponi.TabIndex = 0;
            this.btnProponi.Text = "Proponi";
            this.btnProponi.UseVisualStyleBackColor = true;
            this.btnProponi.Click += new System.EventHandler(this.btnProponi_Click);
            // 
            // btnAggiungiCarta
            // 
            this.btnAggiungiCarta.Location = new System.Drawing.Point(224, 42);
            this.btnAggiungiCarta.Name = "btnAggiungiCarta";
            this.btnAggiungiCarta.Size = new System.Drawing.Size(205, 98);
            this.btnAggiungiCarta.TabIndex = 1;
            this.btnAggiungiCarta.Text = "Aggiungi Carta";
            this.btnAggiungiCarta.UseVisualStyleBackColor = true;
            this.btnAggiungiCarta.Click += new System.EventHandler(this.btnAggiungiCarta_Click);
            // 
            // cmbValore
            // 
            this.cmbValore.FormattingEnabled = true;
            this.cmbValore.Items.AddRange(new object[] {
            "Asso",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "Fante",
            "Regina",
            "Re"});
            this.cmbValore.Location = new System.Drawing.Point(223, 12);
            this.cmbValore.Name = "cmbValore";
            this.cmbValore.Size = new System.Drawing.Size(101, 24);
            this.cmbValore.TabIndex = 2;
            // 
            // cmbSeme
            // 
            this.cmbSeme.FormattingEnabled = true;
            this.cmbSeme.Items.AddRange(new object[] {
            "Cuore",
            "Picche",
            "Fiore",
            "Quadri"});
            this.cmbSeme.Location = new System.Drawing.Point(330, 12);
            this.cmbSeme.Name = "cmbSeme";
            this.cmbSeme.Size = new System.Drawing.Size(99, 24);
            this.cmbSeme.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSeme);
            this.Controls.Add(this.cmbValore);
            this.Controls.Add(this.btnAggiungiCarta);
            this.Controls.Add(this.btnProponi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProponi;
        private System.Windows.Forms.Button btnAggiungiCarta;
        private System.Windows.Forms.ComboBox cmbValore;
        private System.Windows.Forms.ComboBox cmbSeme;
    }
}

