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
        private decimal totaal;
        private List<string> kortingenKeuze;
        private List<string> supplementenKeuze;

        public FrmTransactie()
        {
            InitializeComponent();
            kortingenKeuze = new List<string>();
            supplementenKeuze = new List<string>();
        }

        // Alle info tonen in de juiste labels
        public void DisplayTransaction()
        {
            lblTitle.Text = "Transactie geslaagd!";
            lblFilmKeuze.Text = film;
            lblAantalVolwassenen.Text = volwassenen.ToString();
            lblAantalKinderen.Text = kinderen.ToString();
            
            //Kortingen string opbouwen
            string kortingen = "";
            foreach(string korting in kortingenKeuze)
            {
                kortingen += korting + ", ";
            }
            //Laatste ', ' afknippen, indien nodig
            if(kortingen.EndsWith(", ")) { 
                kortingen = kortingen.Substring(0, kortingen.Length - 2);
            }
            lblKortingenKeuze.Text = kortingen;

            //Supplementen string opbouwen
            string supplementen = "";
            foreach(string supplement in supplementenKeuze)
            {
                supplementen += supplement + ", ";
            }
            //Laatste ', ' afknippen, indien nodig
            if(supplementen.EndsWith(", ")) { 
                supplementen = supplementen.Substring(0, supplementen.Length - 2);
            }
            lblSupplementenKeuze.Text = supplementen;

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

        public void SetTotaal(decimal d)
        {
            this.totaal = d;
        }

        public void AddKorting(string korting)
        {
            kortingenKeuze.Add(korting);
        }

        public void AddSupplement(string supplement)
        {
            supplementenKeuze.Add(supplement);
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
            SetTotaal(0M);
        }
    }
}
