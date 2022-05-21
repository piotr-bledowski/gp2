namespace ListaZadan.Kontrolki
{
    partial class TasksControl
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
            this.lblZalogowany = new System.Windows.Forms.Label();
            this.lblZalogowanyWartosc = new System.Windows.Forms.Label();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lvZadanie = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collsReady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblZalogowany
            // 
            this.lblZalogowany.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZalogowany.Location = new System.Drawing.Point(68, 20);
            this.lblZalogowany.Name = "lblZalogowany";
            this.lblZalogowany.Size = new System.Drawing.Size(157, 59);
            this.lblZalogowany.TabIndex = 0;
            this.lblZalogowany.Text = "Zalogowany jako:";
            // 
            // lblZalogowanyWartosc
            // 
            this.lblZalogowanyWartosc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZalogowanyWartosc.Location = new System.Drawing.Point(231, 20);
            this.lblZalogowanyWartosc.Name = "lblZalogowanyWartosc";
            this.lblZalogowanyWartosc.Size = new System.Drawing.Size(106, 59);
            this.lblZalogowanyWartosc.TabIndex = 1;
            this.lblZalogowanyWartosc.Text = "Anonim";
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.Location = new System.Drawing.Point(343, 20);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(71, 59);
            this.btnWyloguj.TabIndex = 2;
            this.btnWyloguj.Text = "Wyloguj";
            this.btnWyloguj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(343, 96);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(70, 182);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(343, 284);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(71, 162);
            this.btnEdytuj.TabIndex = 4;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(343, 452);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(70, 78);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // lvZadanie
            // 
            this.lvZadanie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.collsReady});
            this.lvZadanie.FullRowSelect = true;
            this.lvZadanie.GridLines = true;
            this.lvZadanie.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZadanie.HideSelection = false;
            this.lvZadanie.Location = new System.Drawing.Point(3, 96);
            this.lvZadanie.MultiSelect = false;
            this.lvZadanie.Name = "lvZadanie";
            this.lvZadanie.ShowGroups = false;
            this.lvZadanie.Size = new System.Drawing.Size(334, 434);
            this.lvZadanie.TabIndex = 6;
            this.lvZadanie.UseCompatibleStateImageBehavior = false;
            this.lvZadanie.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colTitle
            // 
            this.colTitle.Text = "Tytuł";
            this.colTitle.Width = 159;
            // 
            // collsReady
            // 
            this.collsReady.Text = "Zrobione";
            this.collsReady.Width = 110;
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvZadanie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWyloguj);
            this.Controls.Add(this.lblZalogowanyWartosc);
            this.Controls.Add(this.lblZalogowany);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(417, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblZalogowany;
        private System.Windows.Forms.Label lblZalogowanyWartosc;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.ListView lvZadanie;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader collsReady;
    }
}
