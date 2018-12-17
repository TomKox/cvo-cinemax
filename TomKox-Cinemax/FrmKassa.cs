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
        private decimal prijsVolwassen, prijsKind, supplement3D, supplementLang, schoolKortingPCT, groepsKortingPCT;

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

        //private void cbxKorting_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdatePrijs();
        //}

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
        }

        private void cboxGroepsKorting_CheckedChanged(object sender, EventArgs e)
        {
            // Schoolkorting en groepskorting niet tegelijk mogelijk
            if(cboxGroepsKorting.Checked)
            {
                cboxSchoolKorting.Checked = false;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
            }
        }

        private void btnVerwerken_Click(object sender, EventArgs e)
        {
            FrmTransactie transactie = new FrmTransactie();
            transactie.SetFilm(txtFilm.Text);
            transactie.SetVolwassenen(aantalVolwassenen);
            transactie.SetKinderen(aantalKinderen);
            transactie.SetKorting(true);
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

            // btnVerwerken standaard uitschakelen
            btnVerwerken.Enabled = false;

            // Totaal berekenen
            totaal = aantalKinderen * prijsKind + aantalVolwassenen * prijsVolwassen;

            // Korting toepassing indien nodig
            // Bedrag < 0 niet mogelijk
            /*  kortingJaNee = cbxKorting.Checked;
            if (kortingJaNee && totaal > 0)
            {
                totaal -= korting;
            } **/

            // Geldbedrag afronden op 2 decimalen
            Math.Round(totaal, 2);

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
            if(numVolwassenen.Value > 9)
            {
                cboxGroepsKorting.Enabled = true;
            } 
            else
            {
                cboxGroepsKorting.Enabled = false;
                cboxGroepsKorting.Checked = false;
            }

            if(numKinderen.Value > 14)
            {
                cboxSchoolKorting.Enabled = true;
            }
            else
            {
                cboxSchoolKorting.Enabled = false;
                cboxSchoolKorting.Checked = false;
            }
        public void ResetKassa()
        {
            lboxSelectieLijst.ClearSelected();
            txtFilm.Text = "";
            txtFilmToevoegen.Text = "";
            numKinderen.Value = 0;
            numVolwassenen.Value = 0;
            cbxKorting.Checked = false;
            UpdatePrijs();
        }
    }
}
