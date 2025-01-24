using System;
using System.Windows.Forms;
using OtelProjeDeluxeEdition.UI;

namespace OtelProjeDeluxeEdition
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }
    }
}