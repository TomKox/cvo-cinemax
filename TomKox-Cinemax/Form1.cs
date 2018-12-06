﻿using System;
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
        private decimal prijsVolwassen, prijsKind, korting;

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

            //Standaardprijzen en korting instellen
            prijsVolwassen = 9M;
            prijsKind = 7.50M;
            korting = 1M;
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
        }

        private void numVolwassenen_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void numKinderen_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void cbxKorting_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrijs();
        }

        private void btnVerwerken_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePrijs()
        {
            decimal totaal;
            int aantalVolwassenen = Convert.ToInt32(numVolwassenen.Value);
            int aantalKinderen = Convert.ToInt32(numKinderen.Value);

            // Totaal berekenen
            totaal = aantalKinderen * prijsKind + aantalVolwassenen * prijsVolwassen;

            // Korting toepassing indien nodig
            if(cbxKorting.Checked)
            {
                totaal -= korting;
            }

            // Geldbedrag afronden op 2 decimalen
            Math.Round(totaal, 2);

            // Tekstveld Prijs updaten
            txtPrijs.Text = "€ "+ totaal.ToString();
        }
    }
}
