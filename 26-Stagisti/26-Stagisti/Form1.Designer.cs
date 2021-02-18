namespace _26_Stagisti
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
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Classe = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSpecializzazione = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnRicercaAzienda = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtPosizione = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtCittà
            // 
            this.txtCittà.Location = new System.Drawing.Point(101, 69);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(100, 22);
            this.txtCittà.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Città";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(101, 41);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cognome";
            // 
            // Classe
            // 
            this.Classe.AutoSize = true;
            this.Classe.Location = new System.Drawing.Point(13, 100);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(50, 17);
            this.Classe.TabIndex = 6;
            this.Classe.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(101, 97);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 24);
            this.cmbClasse.TabIndex = 7;
            // 
            // cmbSpecializzazione
            // 
            this.cmbSpecializzazione.FormattingEnabled = true;
            this.cmbSpecializzazione.Items.AddRange(new object[] {
            "INF",
            "ELT",
            "MEC",
            "LSSA"});
            this.cmbSpecializzazione.Location = new System.Drawing.Point(343, 40);
            this.cmbSpecializzazione.Name = "cmbSpecializzazione";
            this.cmbSpecializzazione.Size = new System.Drawing.Size(100, 24);
            this.cmbSpecializzazione.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spec.";
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(343, 10);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(100, 24);
            this.cmbSezione.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sezione";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "Azienda 1",
            "Azienda 2",
            "Azienda 3"});
            this.cmbAzienda.Location = new System.Drawing.Point(343, 70);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(100, 24);
            this.cmbAzienda.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Azienda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ore";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(343, 100);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 22);
            this.txtOre.TabIndex = 16;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(16, 149);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(185, 63);
            this.btnInserisci.TabIndex = 17;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // btnRicercaAzienda
            // 
            this.btnRicercaAzienda.Location = new System.Drawing.Point(258, 149);
            this.btnRicercaAzienda.Name = "btnRicercaAzienda";
            this.btnRicercaAzienda.Size = new System.Drawing.Size(185, 63);
            this.btnRicercaAzienda.TabIndex = 18;
            this.btnRicercaAzienda.Text = "Ricerca Azienda";
            this.btnRicercaAzienda.UseVisualStyleBackColor = true;
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(16, 219);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(427, 219);
            this.dgvStudenti.TabIndex = 19;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(16, 444);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(185, 63);
            this.btnElimina.TabIndex = 20;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // txtPosizione
            // 
            this.txtPosizione.Location = new System.Drawing.Point(343, 464);
            this.txtPosizione.Name = "txtPosizione";
            this.txtPosizione.Size = new System.Drawing.Size(100, 22);
            this.txtPosizione.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Posizione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 516);
            this.Controls.Add(this.txtPosizione);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnRicercaAzienda);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSpecializzazione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCittà);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Classe;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSpecializzazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnRicercaAzienda;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtPosizione;
        private System.Windows.Forms.Label label8;
    }
}

