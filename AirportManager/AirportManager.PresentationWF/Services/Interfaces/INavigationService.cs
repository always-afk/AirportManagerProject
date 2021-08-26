using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;

namespace AirportManager.PresentationWF.Services.Interfaces
{
    public interface INavigationService
    {
        public Form Navigate<TForm>() where TForm : Form;
        public Form Navigate<TForm>(Form form) where TForm : Form;
    }
}
