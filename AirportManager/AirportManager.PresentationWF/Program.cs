using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace AirportManager.PresentationWF
{
    static class Program
    {
        static readonly Container _container;
        static Program()
        {
            _container = new Container();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Register();
            Application.Run(_container.GetInstance<Forms.LoginForm>());
        }

        static void Register()
        {
            _container.Register<Forms.LoginForm>(Lifestyle.Singleton);

            _container.Verify();
        }
    }
}
