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
    public partial class TripForm : Form
    {
        public TripForm()
        {
            InitializeComponent();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
            dgvTrip.AutoGenerateColumns = true;

            Trip.lsTrip = new List<Trip>();
            if (Trip.lsTrip.Count == 0)
                btnSelectTrip.Enabled = false;
        }

        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private int _sec = 0;
        //////////////////////////////////////////////////////////////////////////////////////////





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

        private void btnNewTrip_MouseEnter(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(76, 75, 105);

        private void btnNewTrip_MouseLeave(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(52, 51, 73);

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            var ls = new Trip() { Id = Trip.lsTrip.Count + 1, Name = txtAddTrip.Text };
            Trip.lsTrip.Add(ls);
            Form1.trip_ID = ls.Id;
            dgvTrip.DataSource = null;
            dgvTrip.DataSource = Trip.lsTrip;
            btnSelectTrip.Enabled = true;
            ProgressBarNewTrip.Start();
            timerNewTrip.Start();
        }


        private void ProgressBarNewTrip_MouseEnter(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(76, 75, 105);

        private void lblNewTrip_MouseEnter(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(76, 75, 105);



        private void btnSelectTrip_Click(object sender, EventArgs e)
        {
            
        }

        private void timerNewTrip_Tick(object sender, EventArgs e)
        {
            _sec++;

            if (_sec == 3)
            {
                new AddPeopleForm().Show();
                timerNewTrip.Stop();
                Close();
            }
        }

    }
}
