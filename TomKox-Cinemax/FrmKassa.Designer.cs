namespace TomKox_Cinemax
{
    partial class FrmKassa
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
            this.lboxSelectieLijst = new System.Windows.Forms.ListBox();
            this.txtFilmToevoegen = new System.Windows.Forms.TextBox();
            this.lblFilmToevoegen = new System.Windows.Forms.Label();
            this.btnFilmToevoegen = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnVerwerken = new System.Windows.Forms.Button();
            this.cbxKorting = new System.Windows.Forms.CheckBox();
            this.lblVolwassenen = new System.Windows.Forms.Label();
            this.lblKinderen = new System.Windows.Forms.Label();
            this.lblTotalePrijs = new System.Windows.Forms.Label();
            this.lblCinemax = new System.Windows.Forms.Label();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.numKinderen = new System.Windows.Forms.NumericUpDown();
            this.numVolwassenen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numKinderen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolwassenen)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxSelectieLijst
            // 
            this.lboxSelectieLijst.FormattingEnabled = true;
            this.lboxSelectieLijst.Location = new System.Drawing.Point(12, 64);
            this.lboxSelectieLijst.Name = "lboxSelectieLijst";
            this.lboxSelectieLijst.Size = new System.Drawing.Size(246, 264);
            this.lboxSelectieLijst.TabIndex = 0;
            this.lboxSelectieLijst.SelectedValueChanged += new System.EventHandler(this.lboxSelectieLijst_SelectedValueChanged);
            // 
            // txtFilmToevoegen
            // 
            this.txtFilmToevoegen.Location = new System.Drawing.Point(100, 344);
            this.txtFilmToevoegen.Name = "txtFilmToevoegen";
            this.txtFilmToevoegen.Size = new System.Drawing.Size(158, 20);
            this.txtFilmToevoegen.TabIndex = 1;
            this.txtFilmToevoegen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilmToevoegen_KeyUp);
            // 
            // lblFilmToevoegen
            // 
            this.lblFilmToevoegen.AutoSize = true;
            this.lblFilmToevoegen.Location = new System.Drawing.Point(12, 347);
            this.lblFilmToevoegen.Name = "lblFilmToevoegen";
            this.lblFilmToevoegen.Size = new System.Drawing.Size(82, 13);
            this.lblFilmToevoegen.TabIndex = 2;
            this.lblFilmToevoegen.Text = "Film toevoegen:";
            // 
            // btnFilmToevoegen
            // 
            this.btnFilmToevoegen.Location = new System.Drawing.Point(183, 370);
            this.btnFilmToevoegen.Name = "btnFilmToevoegen";
            this.btnFilmToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnFilmToevoegen.TabIndex = 3;
            this.btnFilmToevoegen.Text = "Toevoegen";
            this.btnFilmToevoegen.UseVisualStyleBackColor = true;
            this.btnFilmToevoegen.Click += new System.EventHandler(this.btnFilmToevoegen_Click);
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(326, 64);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(251, 20);
            this.txtFilm.TabIndex = 4;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(285, 67);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(25, 13);
            this.lblFilm.TabIndex = 5;
            this.lblFilm.Text = "Film";
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(502, 370);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.btnAfsluiten.TabIndex = 8;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnVerwerken
            // 
            this.btnVerwerken.Enabled = false;
            this.btnVerwerken.Location = new System.Drawing.Point(421, 370);
            this.btnVerwerken.Name = "btnVerwerken";
            this.btnVerwerken.Size = new System.Drawing.Size(75, 23);
            this.btnVerwerken.TabIndex = 9;
            this.btnVerwerken.Text = "Verwerken";
            this.btnVerwerken.UseVisualStyleBackColor = true;
            this.btnVerwerken.Click += new System.EventHandler(this.btnVerwerken_Click);
            // 
            // cbxKorting
            // 
            this.cbxKorting.AutoSize = true;
            this.cbxKorting.Location = new System.Drawing.Point(288, 201);
            this.cbxKorting.Name = "cbxKorting";
            this.cbxKorting.Size = new System.Drawing.Size(59, 17);
            this.cbxKorting.TabIndex = 10;
            this.cbxKorting.Text = "Korting";
            this.cbxKorting.UseVisualStyleBackColor = true;
            this.cbxKorting.CheckedChanged += new System.EventHandler(this.cbxKorting_CheckedChanged);
            // 
            // lblVolwassenen
            // 
            this.lblVolwassenen.AutoSize = true;
            this.lblVolwassenen.Location = new System.Drawing.Point(285, 148);
            this.lblVolwassenen.Name = "lblVolwassenen";
            this.lblVolwassenen.Size = new System.Drawing.Size(70, 13);
            this.lblVolwassenen.TabIndex = 11;
            this.lblVolwassenen.Text = "Volwassenen";
            // 
            // lblKinderen
            // 
            this.lblKinderen.AutoSize = true;
            this.lblKinderen.Location = new System.Drawing.Point(285, 174);
            this.lblKinderen.Name = "lblKinderen";
            this.lblKinderen.Size = new System.Drawing.Size(49, 13);
            this.lblKinderen.TabIndex = 12;
            this.lblKinderen.Text = "Kinderen";
            // 
            // lblTotalePrijs
            // 
            this.lblTotalePrijs.AutoSize = true;
            this.lblTotalePrijs.Location = new System.Drawing.Point(285, 275);
            this.lblTotalePrijs.Name = "lblTotalePrijs";
            this.lblTotalePrijs.Size = new System.Drawing.Size(58, 13);
            this.lblTotalePrijs.TabIndex = 13;
            this.lblTotalePrijs.Text = "Totale prijs";
            // 
            // lblCinemax
            // 
            this.lblCinemax.AutoSize = true;
            this.lblCinemax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinemax.Location = new System.Drawing.Point(9, 9);
            this.lblCinemax.Name = "lblCinemax";
            this.lblCinemax.Size = new System.Drawing.Size(149, 37);
            this.lblCinemax.TabIndex = 15;
            this.lblCinemax.Text = "Cinemax";
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(477, 272);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.ReadOnly = true;
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 16;
            this.txtPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numKinderen
            // 
            this.numKinderen.Location = new System.Drawing.Point(502, 172);
            this.numKinderen.Name = "numKinderen";
            this.numKinderen.Size = new System.Drawing.Size(75, 20);
            this.numKinderen.TabIndex = 17;
            this.numKinderen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKinderen.ValueChanged += new System.EventHandler(this.numKinderen_ValueChanged);
            // 
            // numVolwassenen
            // 
            this.numVolwassenen.Location = new System.Drawing.Point(502, 146);
            this.numVolwassenen.Name = "numVolwassenen";
            this.numVolwassenen.Size = new System.Drawing.Size(75, 20);
            this.numVolwassenen.TabIndex = 18;
            this.numVolwassenen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVolwassenen.ValueChanged += new System.EventHandler(this.numVolwassenen_ValueChanged);
            // 
            // FrmKassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.numVolwassenen);
            this.Controls.Add(this.numKinderen);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.lblCinemax);
            this.Controls.Add(this.lblTotalePrijs);
            this.Controls.Add(this.lblKinderen);
            this.Controls.Add(this.lblVolwassenen);
            this.Controls.Add(this.cbxKorting);
            this.Controls.Add(this.btnVerwerken);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.btnFilmToevoegen);
            this.Controls.Add(this.lblFilmToevoegen);
            this.Controls.Add(this.txtFilmToevoegen);
            this.Controls.Add(this.lboxSelectieLijst);
            this.Name = "FrmKassa";
            this.Text = "Cinemax Kassa";
            this.Load += new System.EventHandler(this.FrmKassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKinderen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolwassenen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxSelectieLijst;
        private System.Windows.Forms.TextBox txtFilmToevoegen;
        private System.Windows.Forms.Label lblFilmToevoegen;
        private System.Windows.Forms.Button btnFilmToevoegen;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnVerwerken;
        private System.Windows.Forms.CheckBox cbxKorting;
        private System.Windows.Forms.Label lblVolwassenen;
        private System.Windows.Forms.Label lblKinderen;
        private System.Windows.Forms.Label lblTotalePrijs;
        private System.Windows.Forms.Label lblCinemax;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.NumericUpDown numKinderen;
        private System.Windows.Forms.NumericUpDown numVolwassenen;
    }
}

