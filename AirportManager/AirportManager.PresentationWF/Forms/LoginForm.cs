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
        private IViewService _viewService;
        public LoginForm(IViewService viewService)
        {
            InitializeComponent();

            _viewService = viewService;
        }

        private void _signInButton_Click(object sender, EventArgs e)
        {
            if(_viewService.Login(_loginTextBox.Text, _passwordTextBox.Text))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
