using System;
using System.Windows.Forms;
using Task_6;

//8.Добавить в конец строку, содержащую максимумы всех строк.

namespace Matrix
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
