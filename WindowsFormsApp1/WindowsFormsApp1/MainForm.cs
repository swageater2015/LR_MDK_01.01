using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            FileNamesListBox.Items.Add("дверь");
            FileNamesListBox.Items.Add("стол");

        }


        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureArea.Image = Image.FromFile(FileNamesListBox.SelectedItem.ToString());
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    FileNamesListBox.Items.Add(filePath);
                }
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
         
            
        }
    }
}
