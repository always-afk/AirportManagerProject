using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportManager.PresentationWF.Forms.AdminForms
{
    public partial class SwitchForm : Form
    {
        private readonly Form _form;

        public SwitchForm(Form form)
        {
            _form = form;

            InitializeComponent();
        }

        private void SwitchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
