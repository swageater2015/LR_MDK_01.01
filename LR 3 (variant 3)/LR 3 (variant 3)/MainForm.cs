using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_3__variant_3_
{
    public partial class MainForm: Form
    {
        List<Filmes> allFilmes = new List<Filmes>();
        public MainForm()
        {
            InitializeComponent();
            Filmes film1 = new Filmes(1000000, "", "", 28);
            Filmes film2 = new Filmes(3000000, "", "", 21);
            Filmes film3 = new Filmes(20000000, "", "", 21);

            allFilmes.Add(film1);
            allFilmes.Add(film2);
            allFilmes.Add(film3);

            GenresListBox.Items.Add("Ужасы");
            GenresListBox.Items.Add("Комедии");
            GenresListBox.Items.Add("Драмы");

        }
        private void FilmesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FilmImagePictureBox.Image = Image.FromFile(FilmesComboBox.SelectedItem.ToString());
        }


      
        
    }
}
