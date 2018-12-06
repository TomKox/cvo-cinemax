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
        }

        private void btnFilmToevoegen_Click(object sender, EventArgs e)
        {
            AddFilm(txtFilmToevoegen.Text);
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
    }
}
