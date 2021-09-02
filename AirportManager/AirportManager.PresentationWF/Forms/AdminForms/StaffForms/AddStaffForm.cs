using AirportManager.BusinessLogic.Services.Interfaces;
using AirportManager.Common.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportManager.PresentationWF.Forms.AdminForms.StaffForms
{
    public partial class AddStaffForm : Form
    {
        private readonly IAddStaffService _service;

        public AddStaffForm(IAddStaffService service)
        {
            _service = service;

            InitializeComponent();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            var positions = _service.GetPositions();
            foreach(var pos in positions)
            {
                _positionComboBox.Items.Add(pos.Name);
                //_positionComboBox.DisplayMember = pos.Name;
                //_positionComboBox.ValueMember = pos.Id.ToString();
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            var person = new Staff();
            if (CheckInput())
            {
                person.Name = _nameTextBox.Text;
                person.Age = Int32.Parse(_ageTextBox.Text);
                person.Position = (Common.Enums.Positions)_positionComboBox.SelectedIndex;
                person.User = new User
                {
                    Login = _loginTextBox.Text,
                    Password = _passwordTextBox.Text
                };
                _service.AddStaff(person);
            }
            
        }
        private bool CheckInput()
        {
            return true;
        }
    }
}
