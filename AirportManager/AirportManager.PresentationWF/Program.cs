using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using SimpleInjector.Lifestyles;

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

            //_container.Register<DataAccess.Context.AirportDBContext>(Lifestyle.Scoped);

            RegisterContext();

   
            
            _container.Register<Services.Interfaces.INavigationService,
                Services.Implementation.NavigationService>();

            RegisterForms();

            RegisterBusinessLogic();

            RegisterDataAccess();

            _container.Verify();
        }

        static void RegisterBusinessLogic()
        {
            _container.Register<BusinessLogic.Services.Interfaces.ILoginService,
                BusinessLogic.Services.Implementation.LoginService>();
            _container.Register<BusinessLogic.Services.Interfaces.IAddStaffService,
                BusinessLogic.Services.Implementation.AddStaffService>();
            _container.Register<BusinessLogic.Services.Interfaces.IStaffService,
                BusinessLogic.Services.Implementation.StaffService>();
        }

        static void RegisterDataAccess()
        {
            _container.Register<DataAccess.Repositories.Interfaces.IPositionRepository,
                DataAccess.Repositories.Implementation.PositionRepository>();
            _container.Register<DataAccess.Repositories.Interfaces.IStaffRepository,
                DataAccess.Repositories.Implementation.StaffRepository>();
        }

        static void RegisterContext()
        {
            
                var registration =
                    Lifestyle.Transient.CreateRegistration(typeof(DataAccess.Context.AirportDBContext), _container);

                registration.SuppressDiagnosticWarning(
                DiagnosticType.DisposableTransientComponent,
                "Forms should be disposed by app code; not by the container.");

                _container.AddRegistration(typeof(DataAccess.Context.AirportDBContext), registration);
            
        }

        static void RegisterForms()
        {
            var types = _container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration =
                    Lifestyle.Transient.CreateRegistration(type, _container);

                registration.SuppressDiagnosticWarning(
                DiagnosticType.DisposableTransientComponent,
                "Forms should be disposed by app code; not by the container.");

                _container.AddRegistration(type, registration);
            }
        }
    }
}
