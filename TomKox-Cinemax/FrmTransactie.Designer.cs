namespace TomKox_Cinemax
{
    partial class FrmTransactie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransactie));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblVolwassenen = new System.Windows.Forms.Label();
            this.lblKinderen = new System.Windows.Forms.Label();
            this.lblKorting = new System.Windows.Forms.Label();
            this.lblFilmKeuze = new System.Windows.Forms.Label();
            this.lblAantalVolwassenen = new System.Windows.Forms.Label();
            this.lblAantalKinderen = new System.Windows.Forms.Label();
            this.lblKortingJaNee = new System.Windows.Forms.Label();
            this.lblPrijsTotaal = new System.Windows.Forms.Label();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(104, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(548, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transactie geslaagd!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilm
            // 
            this.lblFilm.BackColor = System.Drawing.Color.Transparent;
            this.lblFilm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.Location = new System.Drawing.Point(253, 141);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(146, 33);
            this.lblFilm.TabIndex = 1;
            this.lblFilm.Text = "Film:";
            this.lblFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotaal
            // 
            this.lblTotaal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotaal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(257, 293);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(142, 33);
            this.lblTotaal.TabIndex = 2;
            this.lblTotaal.Text = "Totaal:";
            this.lblTotaal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVolwassenen
            // 
            this.lblVolwassenen.BackColor = System.Drawing.Color.Transparent;
            this.lblVolwassenen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVolwassenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolwassenen.Location = new System.Drawing.Point(253, 174);
            this.lblVolwassenen.Name = "lblVolwassenen";
            this.lblVolwassenen.Size = new System.Drawing.Size(146, 33);
            this.lblVolwassenen.TabIndex = 3;
            this.lblVolwassenen.Text = "Volwassenen:";
            this.lblVolwassenen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKinderen
            // 
            this.lblKinderen.BackColor = System.Drawing.Color.Transparent;
            this.lblKinderen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinderen.Location = new System.Drawing.Point(253, 207);
            this.lblKinderen.Name = "lblKinderen";
            this.lblKinderen.Size = new System.Drawing.Size(146, 33);
            this.lblKinderen.TabIndex = 4;
            this.lblKinderen.Text = "Kinderen:";
            this.lblKinderen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKorting
            // 
            this.lblKorting.BackColor = System.Drawing.Color.Transparent;
            this.lblKorting.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorting.Location = new System.Drawing.Point(253, 240);
            this.lblKorting.Name = "lblKorting";
            this.lblKorting.Size = new System.Drawing.Size(146, 33);
            this.lblKorting.TabIndex = 5;
            this.lblKorting.Text = "Korting?";
            this.lblKorting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilmKeuze
            // 
            this.lblFilmKeuze.BackColor = System.Drawing.Color.Transparent;
            this.lblFilmKeuze.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFilmKeuze.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmKeuze.Location = new System.Drawing.Point(405, 141);
            this.lblFilmKeuze.Name = "lblFilmKeuze";
            this.lblFilmKeuze.Size = new System.Drawing.Size(226, 33);
            this.lblFilmKeuze.TabIndex = 6;
            this.lblFilmKeuze.Text = "Filmtitel";
            this.lblFilmKeuze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAantalVolwassenen
            // 
            this.lblAantalVolwassenen.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalVolwassenen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAantalVolwassenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalVolwassenen.Location = new System.Drawing.Point(405, 174);
            this.lblAantalVolwassenen.Name = "lblAantalVolwassenen";
            this.lblAantalVolwassenen.Size = new System.Drawing.Size(226, 33);
            this.lblAantalVolwassenen.TabIndex = 7;
            this.lblAantalVolwassenen.Text = "0";
            this.lblAantalVolwassenen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAantalKinderen
            // 
            this.lblAantalKinderen.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalKinderen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAantalKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalKinderen.Location = new System.Drawing.Point(405, 207);
            this.lblAantalKinderen.Name = "lblAantalKinderen";
            this.lblAantalKinderen.Size = new System.Drawing.Size(226, 33);
            this.lblAantalKinderen.TabIndex = 8;
            this.lblAantalKinderen.Text = "0";
            this.lblAantalKinderen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKortingJaNee
            // 
            this.lblKortingJaNee.BackColor = System.Drawing.Color.Transparent;
            this.lblKortingJaNee.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKortingJaNee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKortingJaNee.Location = new System.Drawing.Point(405, 240);
            this.lblKortingJaNee.Name = "lblKortingJaNee";
            this.lblKortingJaNee.Size = new System.Drawing.Size(226, 33);
            this.lblKortingJaNee.TabIndex = 9;
            this.lblKortingJaNee.Text = "Nee";
            this.lblKortingJaNee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrijsTotaal
            // 
            this.lblPrijsTotaal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrijsTotaal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrijsTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijsTotaal.Location = new System.Drawing.Point(404, 293);
            this.lblPrijsTotaal.Name = "lblPrijsTotaal";
            this.lblPrijsTotaal.Size = new System.Drawing.Size(227, 33);
            this.lblPrijsTotaal.TabIndex = 10;
            this.lblPrijsTotaal.Text = "€ 0";
            this.lblPrijsTotaal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSluiten
            // 
            this.btnSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluiten.Location = new System.Drawing.Point(506, 343);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(125, 37);
            this.btnSluiten.TabIndex = 11;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            // 
            // FrmTransactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(777, 485);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.lblPrijsTotaal);
            this.Controls.Add(this.lblKortingJaNee);
            this.Controls.Add(this.lblAantalKinderen);
            this.Controls.Add(this.lblAantalVolwassenen);
            this.Controls.Add(this.lblFilmKeuze);
            this.Controls.Add(this.lblKorting);
            this.Controls.Add(this.lblKinderen);
            this.Controls.Add(this.lblVolwassenen);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmTransactie";
            this.Text = "Transactie";
            this.Load += new System.EventHandler(this.FrmTransactie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblVolwassenen;
        private System.Windows.Forms.Label lblKinderen;
        private System.Windows.Forms.Label lblKorting;
        private System.Windows.Forms.Label lblFilmKeuze;
        private System.Windows.Forms.Label lblAantalVolwassenen;
        private System.Windows.Forms.Label lblAantalKinderen;
        private System.Windows.Forms.Label lblKortingJaNee;
        private System.Windows.Forms.Label lblPrijsTotaal;
        private System.Windows.Forms.Button btnSluiten;
    }
}