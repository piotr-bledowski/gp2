namespace ListaZadan.Kontrolki
{
    partial class RegisterControl
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.lblImieWalidacja = new System.Windows.Forms.Label();
            this.lblLoginWalidacja = new System.Windows.Forms.Label();
            this.lblHasloWalidacja = new System.Windows.Forms.Label();
            this.lblPowtorzHasloWalidacja = new System.Windows.Forms.Label();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.lblRejestracja = new System.Windows.Forms.Label();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(117, 133);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(37, 17);
            this.lblImie.TabIndex = 0;
            this.lblImie.Text = "Imię:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(107, 202);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Location = new System.Drawing.Point(106, 270);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(48, 17);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(54, 335);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(100, 17);
            this.lblPowtorzHaslo.TabIndex = 3;
            this.lblPowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(160, 128);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 22);
            this.tbImie.TabIndex = 4;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(160, 197);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 22);
            this.tbLogin.TabIndex = 5;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(160, 265);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(100, 22);
            this.tbHaslo.TabIndex = 6;
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(160, 330);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(100, 22);
            this.tbPowtorzHaslo.TabIndex = 7;
            // 
            // lblImieWalidacja
            // 
            this.lblImieWalidacja.AutoSize = true;
            this.lblImieWalidacja.Location = new System.Drawing.Point(157, 166);
            this.lblImieWalidacja.Name = "lblImieWalidacja";
            this.lblImieWalidacja.Size = new System.Drawing.Size(120, 17);
            this.lblImieWalidacja.TabIndex = 8;
            this.lblImieWalidacja.Text = "Niepoprawne imię";
            this.lblImieWalidacja.Visible = false;
            // 
            // lblLoginWalidacja
            // 
            this.lblLoginWalidacja.AutoSize = true;
            this.lblLoginWalidacja.Location = new System.Drawing.Point(157, 231);
            this.lblLoginWalidacja.Name = "lblLoginWalidacja";
            this.lblLoginWalidacja.Size = new System.Drawing.Size(124, 17);
            this.lblLoginWalidacja.TabIndex = 9;
            this.lblLoginWalidacja.Text = "Niepoprawny login";
            this.lblLoginWalidacja.Visible = false;
            // 
            // lblHasloWalidacja
            // 
            this.lblHasloWalidacja.AutoSize = true;
            this.lblHasloWalidacja.Location = new System.Drawing.Point(157, 300);
            this.lblHasloWalidacja.Name = "lblHasloWalidacja";
            this.lblHasloWalidacja.Size = new System.Drawing.Size(129, 17);
            this.lblHasloWalidacja.TabIndex = 10;
            this.lblHasloWalidacja.Text = "Niepoprawne hasło";
            this.lblHasloWalidacja.Visible = false;
            // 
            // lblPowtorzHasloWalidacja
            // 
            this.lblPowtorzHasloWalidacja.AutoSize = true;
            this.lblPowtorzHasloWalidacja.Location = new System.Drawing.Point(157, 364);
            this.lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            this.lblPowtorzHasloWalidacja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPowtorzHasloWalidacja.Size = new System.Drawing.Size(129, 17);
            this.lblPowtorzHasloWalidacja.TabIndex = 11;
            this.lblPowtorzHasloWalidacja.Text = "Niepoprawne hasło";
            this.lblPowtorzHasloWalidacja.Visible = false;
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.Location = new System.Drawing.Point(78, 422);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(246, 71);
            this.btnZarejestruj.TabIndex = 13;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = true;
            // 
            // lblRejestracja
            // 
            this.lblRejestracja.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRejestracja.Location = new System.Drawing.Point(160, 32);
            this.lblRejestracja.Name = "lblRejestracja";
            this.lblRejestracja.Size = new System.Drawing.Size(201, 56);
            this.lblRejestracja.TabIndex = 14;
            this.lblRejestracja.Text = "Rejestracja";
            // 
            // btnCofnij
            // 
            this.btnCofnij.Image = global::ListaZadan.Properties.Resources.U_21E61;
            this.btnCofnij.Location = new System.Drawing.Point(22, 27);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(95, 61);
            this.btnCofnij.TabIndex = 12;
            this.btnCofnij.UseVisualStyleBackColor = true;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRejestracja);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.lblPowtorzHasloWalidacja);
            this.Controls.Add(this.lblHasloWalidacja);
            this.Controls.Add(this.lblLoginWalidacja);
            this.Controls.Add(this.lblImieWalidacja);
            this.Controls.Add(this.tbPowtorzHaslo);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lblPowtorzHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblImie);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(417, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblPowtorzHaslo;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.Label lblImieWalidacja;
        private System.Windows.Forms.Label lblLoginWalidacja;
        private System.Windows.Forms.Label lblHasloWalidacja;
        private System.Windows.Forms.Label lblPowtorzHasloWalidacja;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label lblRejestracja;
    }
}
