using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace AirportManager.PresentationWF.Services.Implementation
{
    public class NavigationService : Interfaces.INavigationService
    {
        private Container _container;

        public NavigationService(Container container)
        {
            _container = container;
        }

        public Form Navigate<TForm>() where TForm : Form
        {
            return _container.GetInstance<TForm>();
        }

        public Form Navigate<TForm>(Form form) where TForm : Form
        {
            throw new NotImplementedException();
            //return _container.GetInstance<TForm>();
        }
    }
}
