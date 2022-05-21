namespace ListaZadan.Kontrolki
{
    partial class LoginControls
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.btnZalozKonto = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(112, 165);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Location = new System.Drawing.Point(112, 212);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(48, 17);
            this.lblHaslo.TabIndex = 1;
            this.lblHaslo.Text = "Hasło:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(165, 165);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 22);
            this.tbLogin.TabIndex = 2;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(165, 212);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(100, 22);
            this.tbHaslo.TabIndex = 3;
            // 
            // lblWalidacjaLogowania
            // 
            this.lblWalidacjaLogowania.AutoSize = true;
            this.lblWalidacjaLogowania.Location = new System.Drawing.Point(97, 255);
            this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            this.lblWalidacjaLogowania.Size = new System.Drawing.Size(185, 17);
            this.lblWalidacjaLogowania.TabIndex = 4;
            this.lblWalidacjaLogowania.Text = "Niepoprawny login lub haslo";
            this.lblWalidacjaLogowania.Visible = false;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(132, 297);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(123, 68);
            this.btnZaloguj.TabIndex = 5;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // btnZalozKonto
            // 
            this.btnZalozKonto.Location = new System.Drawing.Point(132, 380);
            this.btnZalozKonto.Name = "btnZalozKonto";
            this.btnZalozKonto.Size = new System.Drawing.Size(123, 67);
            this.btnZalozKonto.TabIndex = 6;
            this.btnZalozKonto.Text = "Załóż konto";
            this.btnZalozKonto.UseVisualStyleBackColor = true;
            this.btnZalozKonto.Click += new System.EventHandler(this.btnZalozKonto_Click);
            // 
            // lblLista
            // 
            this.lblLista.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLista.Location = new System.Drawing.Point(112, 68);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(201, 56);
            this.lblLista.TabIndex = 7;
            this.lblLista.Text = "Lista zadań";
            // 
            // LoginControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnZalozKonto);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.lblWalidacjaLogowania);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginControls";
            this.Size = new System.Drawing.Size(417, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label lblWalidacjaLogowania;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnZalozKonto;
        private System.Windows.Forms.Label lblLista;
    }
}
