// GitHub Repository voor dit project: https://github.com/TomKox/cvo-cinemax

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomKox_Cinemax
{
    public partial class FrmKassa : Form
    {
        // prijzen en korting
        private decimal prijsVolwassen, prijsKind, supplement3D, supplementLang, schoolKortingPCT, groepsKortingPCT, customKorting;

        // keuzes en totalen
        private int aantalVolwassenen, aantalKinderen;
        decimal totaal;


        public FrmKassa()
        {
            InitializeComponent();
        }

        private void FrmKassa_Load(object sender, EventArgs e)
        {
            // Films toevoegen
            AddFilm("Divergent");
            AddFilm("First Man");
            AddFilm("Godzilla");
            AddFilm("Spiderman 2");
            AddFilm("Noah");
            AddFilm("Rio 2");

            // Standaardprijzen en korting instellen
            prijsVolwassen = 9M;
            prijsKind = 7.50M;
            supplement3D = 2M;
            supplementLang = 1.50M;
            schoolKortingPCT = 15; // Percent
            groepsKortingPCT = 10; // Percent

            // Initiële call van ResetKassa om bedrag = 0 in te vullen
            ResetKassa();
        }

        private void btnFilmToevoegen_Click(object sender, EventArgs e)
        {
            AddFilm(txtFilmToevoegen.Text);
            txtFilmToevoegen.Text = String.Empty;
        }

        private void AddFilm(string film)
        {
            // Onnodige spaties verwijderen
            film = film.Trim();

            // Controle op lege strings
            if (film == string.Empty) return;

            // Extra controle op mogelijke vergissingen rond hoofdletters en spaties
            foreach(string gekendeFilm in lboxSelectieLijst.Items)
            {
                if(RemoveSpaces(film.ToLower()) == RemoveSpaces(gekendeFilm.ToLower())
                    && film != gekendeFilm)
                {
                    string message = "De lijst bevat al een gelijkaardige titel." + Environment.NewLine
                        + "Wilt u deze toch toevoegen?";
                    string messageTitle = "Gelijkaardige titel gevonden";
                    if (MessageBox.Show(message,
                        messageTitle,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            // Enkel nieuwe films toevoegen
            if(!lboxSelectieLijst.Items.Contains(film)) { 
                lboxSelectieLijst.Items.Add(film);
            }
        }

        private void txtFilmToevoegen_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddFilm(txtFilmToevoegen.Text);
                txtFilmToevoegen.Text = String.Empty;
            }
        }

        private void lboxSelectieLijst_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFilm.Text = lboxSelectieLijst.Text;
            // Call van UpdatePrijs om btnVerwerken te activeren indien nodig
            UpdatePrijs();
        }

        private void numVolwassenen_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
            CheckKortingen();
        }

        private void numKinderen_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
            CheckKortingen();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboxSchoolKorting_CheckedChanged(object sender, EventArgs e)
        {
            // Groepskorting en schoolkorting niet tegelijk mogelijk
            if(cboxSchoolKorting.Checked)
            {
                cboxGroepsKorting.Checked = false;
            }

            UpdatePrijs();
        }

        private void cboxGroepsKorting_CheckedChanged(object sender, EventArgs e)
        {
            // Schoolkorting en groepskorting niet tegelijk mogelijk
            if(cboxGroepsKorting.Checked)
            {
                cboxSchoolKorting.Checked = false;
            }

            UpdatePrijs();
        }

        private void cbox3D_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void cboxLangeFilm_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void mtxtCustomKorting_TextChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void cboxCustomKorting_CheckedChanged(object sender, EventArgs e)
        {
            // Textbox andere korting activeren wanneer checkbox aangevinkt
            if(cboxCustomKorting.Checked)
            {
                lblEuro.Enabled = true;
                mtxtCustomKorting.Enabled = true;
            }
            else
            {
                lblEuro.Enabled = false;
                mtxtCustomKorting.Enabled = false;
                mtxtCustomKorting.Text = "";
            }

            UpdatePrijs();
        }

        private void btnVerwerken_Click(object sender, EventArgs e)
        {
            FrmTransactie transactie = new FrmTransactie();
            transactie.SetFilm(txtFilm.Text);
            transactie.SetVolwassenen(aantalVolwassenen);
            transactie.SetKinderen(aantalKinderen);

            if (cboxSchoolKorting.Checked) transactie.AddKorting("Schoolkorting");
            if (cboxGroepsKorting.Checked) transactie.AddKorting("Groepskorting");
            if (cboxCustomKorting.Checked) transactie.AddKorting("Andere: €" + customKorting.ToString());

            if (cbox3D.Checked) transactie.AddSupplement("3D Film");
            if (cboxLangeFilm.Checked) transactie.AddSupplement("Lange film");

            transactie.SetTotaal(totaal);
            transactie.DisplayTransaction();
            transactie.ShowDialog();
            ResetKassa();
        }

        // Hulpmethode om spaties uit strings te halen.
        private string RemoveSpaces(string text)
        {
            string zonderSpaties = "";

            foreach(char c in text)
            {
                if(c != ' ')
                {
                    zonderSpaties += c;
                }
            }
            return zonderSpaties;
        }

        private void UpdatePrijs()
        {
            totaal = 0;
            aantalVolwassenen = Convert.ToInt32(numVolwassenen.Value);
            aantalKinderen = Convert.ToInt32(numKinderen.Value);

            // Kortingen verwerken
            decimal kortingPCT = 0M;
            customKorting = 0M;
            // Groeps- of schoolkorting
            if (cboxSchoolKorting.Checked) kortingPCT = this.schoolKortingPCT;
            if (cboxGroepsKorting.Checked) kortingPCT = this.groepsKortingPCT;
            // Andere korting
            if (cboxCustomKorting.Checked)
            {
                string ckortTxt = mtxtCustomKorting.Text; // tijdelijke string om conversie te vergemakkelijken
                ckortTxt = RemoveSpaces(ckortTxt);
                ckortTxt += "0";
                customKorting = Convert.ToDecimal(ckortTxt);
                customKorting = Math.Round(customKorting, 2);
            }

            // Supplementen verwerken
            decimal supp3D = 0M, suppLang = 0M;
            if (cbox3D.Checked) supp3D = this.supplement3D;
            if (cboxLangeFilm.Checked) suppLang = this.supplementLang;

            // btnVerwerken standaard uitschakelen
            btnVerwerken.Enabled = false;

            // Totaal berekenen
            totaal = aantalKinderen * (prijsKind + supp3D + suppLang) + aantalVolwassenen * (prijsVolwassen + supp3D + suppLang);

            // Kortingen toepassen
            decimal kortingBedrag = totaal * kortingPCT / 100;
            totaal = totaal - kortingBedrag - customKorting;

            // Geldbedrag afronden op 2 decimalen
            totaal = Math.Round(totaal, 2);

            // Tekstveld Prijs updaten
            txtPrijs.Text = "€ "+ totaal.ToString();

            // btnVerwerken inschakelen wanneer prijs > 0
            // en film ingevuld
            if(totaal > 0 && txtFilm.Text != "")
            {
                btnVerwerken.Enabled = true;
            }
        }

        private void CheckKortingen()
        {
            // Groepskorting enkel vanaf 10 volwassenen
            if (numVolwassenen.Value > 9)
            {
                cboxGroepsKorting.Enabled = true;
            }
            else
            {
                cboxGroepsKorting.Enabled = false;
                cboxGroepsKorting.Checked = false;
            }

            // Schoolkorting enkel vanaf 15 volwassenen
            if (numKinderen.Value > 14)
            {
                cboxSchoolKorting.Enabled = true;
            }
            else
            {
                cboxSchoolKorting.Enabled = false;
                cboxSchoolKorting.Checked = false;
            }
        }

        public void ResetKassa()
        {
            lboxSelectieLijst.ClearSelected();
            txtFilm.Text = "";
            txtFilmToevoegen.Text = "";
            numKinderen.Value = 0;
            numVolwassenen.Value = 0;
            cboxSchoolKorting.Checked = false;
            cboxGroepsKorting.Checked = false;
            cboxCustomKorting.Checked = false;
            cbox3D.Checked = false;
            cboxLangeFilm.Checked = false;

            UpdatePrijs();
        }
    }
}
