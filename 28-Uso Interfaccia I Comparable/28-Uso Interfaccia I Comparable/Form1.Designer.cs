namespace _28_Uso_Interfaccia_I_Comparable
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
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(12, 12);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(298, 131);
            this.btnVisualizza.TabIndex = 0;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(316, 12);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(298, 131);
            this.btnOrdina.TabIndex = 0;
            this.btnOrdina.Text = "Ordina e Mostra";
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 155);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.btnVisualizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnOrdina;
    }
}

