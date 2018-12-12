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
    public partial class FrmTransactie : Form
    {
        private string film;
        private int volwassenen, kinderen;
        private bool korting;
        private decimal totaal;

        public FrmTransactie()
        {
            InitializeComponent();
        }

        // Alle info tonen in de juiste labels
        public void DisplayTransaction()
        {
            lblTitle.Text = "Transactie geslaagd!";
            lblFilmKeuze.Text = film;
            lblAantalVolwassenen.Text = volwassenen.ToString();
            lblAantalKinderen.Text = kinderen.ToString();
            if (korting) lblKortingJaNee.Text = "Ja";
            if (!korting) lblKortingJaNee.Text = "Nee";
            lblPrijsTotaal.Text = "€ " + totaal.ToString();
        }

        public void SetFilm(string film)
        {
            this.film = film;
        }

        public void SetVolwassenen(int i)
        {
            this.volwassenen = i;
        }

        public void SetKinderen(int i)
        {
            this.kinderen = i;
        }

        public void SetKorting(bool korting)
        {
            this.korting = korting;
        }

        public void SetTotaal(decimal d)
        {
            this.totaal = d;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTransactie_Load(object sender, EventArgs e)
        {
            SetFilm("");
            SetVolwassenen(0);
            SetKinderen(0);
            SetKorting(false);
            SetTotaal(0M);
        }
    }
}
