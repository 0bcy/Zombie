namespace Gra_Zombie_2020.KartyRęka
{
    partial class UserControlKartaRekaOsoba
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
            this.pictureBoxObrazek = new System.Windows.Forms.PictureBox();
            this.pictureBoxTyp = new System.Windows.Forms.PictureBox();
            this.pictureBoxSila = new System.Windows.Forms.PictureBox();
            this.pictureBoxNazwa = new System.Windows.Forms.PictureBox();
            this.pictureBoxKolor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazwa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxObrazek
            // 
            this.pictureBoxObrazek.Location = new System.Drawing.Point(3, 39);
            this.pictureBoxObrazek.Name = "pictureBoxObrazek";
            this.pictureBoxObrazek.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxObrazek.TabIndex = 0;
            this.pictureBoxObrazek.TabStop = false;
            // 
            // pictureBoxTyp
            // 
            this.pictureBoxTyp.Location = new System.Drawing.Point(103, 195);
            this.pictureBoxTyp.Name = "pictureBoxTyp";
            this.pictureBoxTyp.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTyp.TabIndex = 1;
            this.pictureBoxTyp.TabStop = false;
            // 
            // pictureBoxSila
            // 
            this.pictureBoxSila.Location = new System.Drawing.Point(3, 195);
            this.pictureBoxSila.Name = "pictureBoxSila";
            this.pictureBoxSila.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSila.TabIndex = 2;
            this.pictureBoxSila.TabStop = false;
            // 
            // pictureBoxNazwa
            // 
            this.pictureBoxNazwa.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNazwa.Name = "pictureBoxNazwa";
            this.pictureBoxNazwa.Size = new System.Drawing.Size(150, 30);
            this.pictureBoxNazwa.TabIndex = 3;
            this.pictureBoxNazwa.TabStop = false;
            this.pictureBoxNazwa.Click += new System.EventHandler(this.pictureBoxNazwa_Click);
            // 
            // pictureBoxKolor
            // 
            this.pictureBoxKolor.Location = new System.Drawing.Point(53, 195);
            this.pictureBoxKolor.Name = "pictureBoxKolor";
            this.pictureBoxKolor.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxKolor.TabIndex = 4;
            this.pictureBoxKolor.TabStop = false;
            // 
            // UserControlKartaRekaOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxKolor);
            this.Controls.Add(this.pictureBoxNazwa);
            this.Controls.Add(this.pictureBoxSila);
            this.Controls.Add(this.pictureBoxTyp);
            this.Controls.Add(this.pictureBoxObrazek);
            this.Name = "UserControlKartaRekaOsoba";
            this.Size = new System.Drawing.Size(156, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazwa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxObrazek;
        private System.Windows.Forms.PictureBox pictureBoxTyp;
        private System.Windows.Forms.PictureBox pictureBoxSila;
        private System.Windows.Forms.PictureBox pictureBoxNazwa;
        private System.Windows.Forms.PictureBox pictureBoxKolor;
    }
}
