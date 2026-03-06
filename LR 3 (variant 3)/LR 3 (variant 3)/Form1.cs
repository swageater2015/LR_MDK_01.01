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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            FillGenres();
        }
        List<Film> llFilms = new List<Film>();
        List<string> orderTitles = new List<string>();
        List<int> orderQtys = new List<int>();
    }
}
