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

namespace AirportManager.PresentationWF.Forms.AdminForms.PlanesForms
{
    public partial class PlanesForm : Form
    {
        private readonly Services.Interfaces.INavigationService _navigation;
        private readonly IPlanesService _planesService;
        private DataTable _dataTable;

        public PlanesForm(Services.Interfaces.INavigationService navigation, IPlanesService planesService)
        {
            _navigation = navigation;
            _planesService = planesService;

            InitializeComponent();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            Form form = _navigation.Navigate<AddPlaneForm>();
            form.Show();
        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            _dataTable = new DataTable();
            _dataTable.Columns.Add("Name", typeof(string));
            _dataTable.Columns.Add("Number of Seats", typeof(int));
            _dataTable.Columns.Add("Pilot", typeof(string));

            var planes = _planesService.LoadPlanes().Select(p => new
            {
                Name = p.Name,
                NumOfSeats = p.NumOfSeats,
                Pilot = p.Staff
            }).ToList();

            foreach(var p in planes)
            {
                _dataTable.Rows.Add(p.Name, p.NumOfSeats, p.Pilot);
            }

            _planesTable.DataSource = _dataTable;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var srows = _planesTable.SelectedRows;
            var arows = _planesTable.Rows;
            var rows = FindRows(arows, srows);
            var planesToDel = RowsToStringArray(rows);
            
        }

        private List<DataGridViewRow> FindRows(DataGridViewRowCollection arows, DataGridViewSelectedRowCollection srows)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach(DataGridViewRow r in arows)
            {
                if (srows.Contains(r))
                {
                    rows.Add(r);
                }
            }
            return rows;
        }

        private List<string[]> RowsToStringArray(List<DataGridViewRow> rows)
        {
            var elems = new List<string[]>();
            foreach (var r in rows)
            {
                var cells = new string[3];
                for(int i = 0; i < cells.Length; i++) 
                {
                    if(r.Cells[i].Value is null)
                    {
                        cells[i] = null;
                    }
                    else
                    {
                        cells[i] = r.Cells[i].Value.ToString();
                    }
                }
            }
            return elems;
        }
    }
}
