using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportManager.DataAccess.Services.Implementation;

namespace AirportManager.PresentationWF.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _signInButton_Click(object sender, EventArgs e)
        {
            DBService service = new DBService();
            var staff = service.LoadStaff();
            if (staff.Any(p => p.Login == _loginTextBox.Text && p.Password == _passwordTextBox.Text))
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
