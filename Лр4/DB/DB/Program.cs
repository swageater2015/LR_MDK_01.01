using System;
using System.Windows.Forms;

namespace CollegeStudentsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStudents());  // ← здесь создаётся форма
        }
    }
}