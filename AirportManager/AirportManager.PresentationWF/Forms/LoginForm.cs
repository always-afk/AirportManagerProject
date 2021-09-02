using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportManager.BusinessLogic.Services.Interfaces;

namespace AirportManager.PresentationWF.Forms
{
    public partial class LoginForm : Form
    {
        private ILoginService _loginService;
        private Services.Interfaces.INavigationService _navigationService;
        public LoginForm(ILoginService loginService, Services.Interfaces.INavigationService navigationService)
        {
            InitializeComponent();

            _loginService = loginService;
            _navigationService = navigationService;
        }

        private void _signInButton_Click(object sender, EventArgs e)
        {
            var curUser = _loginService.Login(_loginTextBox.Text, _passwordTextBox.Text);
            if (curUser is not null)
            {
                MessageBox.Show("Success");
                switch (curUser.Position)
                {
                    case Common.Enums.Positions.Admin:
                        Form adminForm = _navigationService.Navigate<AdminForms.SwitchForm>();
                        adminForm.Show();
                        break;
                    case Common.Enums.Positions.Pilot:
                        Form pilotForm = _navigationService.Navigate<PilotForms.MainForm>();
                        pilotForm.Show();
                        break;
                    //case (int)Common.Enums.Positions.Cashier:
                    //    Form cashierForm = _navigationService.Navigate<CachierForms.MainForm>();
                    //    cashierForm.Show();
                    //    break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
