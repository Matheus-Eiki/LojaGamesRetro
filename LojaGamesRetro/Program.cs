
using System;
using System.Windows.Forms;

namespace LojaGamesRetro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FrmTelaSplash splash = new FrmTelaSplash();

            splash.SplashConcluida += (sender, e) =>
            {
                FrmTelaMenu menu = new FrmTelaMenu();

                // Se o menu for fechado, encerra o aplicativo.
                menu.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };

                menu.Show();
                splash.Hide();
            };

            Application.Run(splash);
        }
    }
}
