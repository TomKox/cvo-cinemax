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
            lboxSelectieLijst.Items.Add("Divergent");
            lboxSelectieLijst.Items.Add("First Man");
            lboxSelectieLijst.Items.Add("Godzilla");
        }

        private void btnFilmToevoegen_Click(object sender, EventArgs e)
        {

        }
    }
}
