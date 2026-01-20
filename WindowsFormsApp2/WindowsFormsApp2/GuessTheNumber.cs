using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp2
{
    public partial class GuessTheNumber: Form
    {
        int nextrand_;
        public GuessTheNumber()
        {
            InitializeComponent();
            Random rnd = new Random();
            nextrand_ = rnd.Next(100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);

            if (nextrand_ > input)
            {
                MessageBox.Show("Введенное число меньше!");
            }
            else if (nextrand_<input)
            {
                MessageBox.Show("Введенное число больше!");
            }
            else 
            {
                MessageBox.Show("Вы угадали!!!");
            }
            
        }
    }
}
