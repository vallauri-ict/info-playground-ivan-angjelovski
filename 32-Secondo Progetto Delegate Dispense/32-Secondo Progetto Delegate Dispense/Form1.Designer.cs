namespace _32_Secondo_Progetto_Delegate_Dispense
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
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.btnIncrementa = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Value:";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(96, 10);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(125, 22);
            this.txtMaxValue.TabIndex = 1;
            // 
            // btnIncrementa
            // 
            this.btnIncrementa.Location = new System.Drawing.Point(121, 39);
            this.btnIncrementa.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncrementa.Name = "btnIncrementa";
            this.btnIncrementa.Size = new System.Drawing.Size(100, 28);
            this.btnIncrementa.TabIndex = 4;
            this.btnIncrementa.Text = "Incrementa";
            this.btnIncrementa.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 39);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 28);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 77);
            this.Controls.Add(this.btnIncrementa);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Button btnIncrementa;
        private System.Windows.Forms.Button btnCreate;
    }
}

