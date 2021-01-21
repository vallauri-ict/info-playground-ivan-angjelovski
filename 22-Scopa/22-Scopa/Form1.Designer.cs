namespace _22_Scopa
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
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnMazzo = new System.Windows.Forms.Button();
            this.btnMostraMazzo = new System.Windows.Forms.Button();
            this.btnMescolaMazzo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(12, 12);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(157, 99);
            this.btnEstrai.TabIndex = 0;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnMazzo
            // 
            this.btnMazzo.Location = new System.Drawing.Point(175, 12);
            this.btnMazzo.Name = "btnMazzo";
            this.btnMazzo.Size = new System.Drawing.Size(157, 99);
            this.btnMazzo.TabIndex = 1;
            this.btnMazzo.Text = "Mazzo";
            this.btnMazzo.UseVisualStyleBackColor = true;
            this.btnMazzo.Click += new System.EventHandler(this.btnMazzo_Click);
            // 
            // btnMostraMazzo
            // 
            this.btnMostraMazzo.Location = new System.Drawing.Point(12, 117);
            this.btnMostraMazzo.Name = "btnMostraMazzo";
            this.btnMostraMazzo.Size = new System.Drawing.Size(157, 99);
            this.btnMostraMazzo.TabIndex = 2;
            this.btnMostraMazzo.Text = "Mostra mazzo";
            this.btnMostraMazzo.UseVisualStyleBackColor = true;
            this.btnMostraMazzo.Click += new System.EventHandler(this.btnMostraMazzo_Click);
            // 
            // btnMescolaMazzo
            // 
            this.btnMescolaMazzo.Location = new System.Drawing.Point(175, 117);
            this.btnMescolaMazzo.Name = "btnMescolaMazzo";
            this.btnMescolaMazzo.Size = new System.Drawing.Size(157, 99);
            this.btnMescolaMazzo.TabIndex = 3;
            this.btnMescolaMazzo.Text = "Mescola mazzo";
            this.btnMescolaMazzo.UseVisualStyleBackColor = true;
            this.btnMescolaMazzo.Click += new System.EventHandler(this.btnMescolaMazzo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 228);
            this.Controls.Add(this.btnMescolaMazzo);
            this.Controls.Add(this.btnMostraMazzo);
            this.Controls.Add(this.btnMazzo);
            this.Controls.Add(this.btnEstrai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnMazzo;
        private System.Windows.Forms.Button btnMostraMazzo;
        private System.Windows.Forms.Button btnMescolaMazzo;
    }
}

