using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRIP_APP.Models;
using TripConsole;

namespace TRIP_APP
{
    public partial class AddPeopleForm : Form
    {
        public AddPeopleForm() => InitializeComponent();
        public static int trip_ID;

        private void AddPeopleForm_Load(object sender, EventArgs e)
        {

        }

        //Global vars
        readonly List<Person> lsPerson = new List<Person>();


        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void navBar_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddPeople.Text))
            {
                MessageBox.Show("Please enter a valid name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var person = new Person() { Id = lsPerson.Count + 1, Name = txtAddPeople.Text };
            lsPerson.Add(person);
            Trip.AddPerson(person);
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = lsPerson;
            txtAddPeople.ResetText();
            txtAddPeople.Focus();
        }

        private void btnSelectTrip_Click(object sender, EventArgs e)
        {
            if (dgvPerson.Rows.Count < 2)
            {
                MessageBox.Show("Please enter at least 2 people", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new Form1().Show();
            Close();
        }
        //////////////////////////////////////////////////////////////////////////////////////////
    }
}
