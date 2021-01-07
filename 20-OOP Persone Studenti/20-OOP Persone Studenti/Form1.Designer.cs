namespace _20_OOP_Persone_Studenti
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCarica = new System.Windows.Forms.Button();
            this.lstVwStudenti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnAggiungiVoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(114, 37);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome:";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(114, 65);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 22);
            this.txtEta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Età:";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(114, 94);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 22);
            this.txtSesso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sesso:";
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(16, 127);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(198, 40);
            this.btnCarica.TabIndex = 8;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // lstVwStudenti
            // 
            this.lstVwStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstVwStudenti.HideSelection = false;
            this.lstVwStudenti.Location = new System.Drawing.Point(220, 13);
            this.lstVwStudenti.MultiSelect = false;
            this.lstVwStudenti.Name = "lstVwStudenti";
            this.lstVwStudenti.Size = new System.Drawing.Size(447, 269);
            this.lstVwStudenti.TabIndex = 9;
            this.lstVwStudenti.UseCompatibleStateImageBehavior = false;
            this.lstVwStudenti.View = System.Windows.Forms.View.List;
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(114, 174);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 22);
            this.txtVoto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voto:";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(16, 202);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(198, 39);
            this.btnMedia.TabIndex = 13;
            this.btnMedia.Text = "Visualizza la Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnAggiungiVoto
            // 
            this.btnAggiungiVoto.Location = new System.Drawing.Point(16, 247);
            this.btnAggiungiVoto.Name = "btnAggiungiVoto";
            this.btnAggiungiVoto.Size = new System.Drawing.Size(198, 39);
            this.btnAggiungiVoto.TabIndex = 14;
            this.btnAggiungiVoto.Text = "Aggiungi Voto";
            this.btnAggiungiVoto.UseVisualStyleBackColor = true;
            this.btnAggiungiVoto.Click += new System.EventHandler(this.btnAggiungiVoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 294);
            this.Controls.Add(this.btnAggiungiVoto);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVwStudenti);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.ListView lstVwStudenti;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnAggiungiVoto;
    }
}

