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
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        public static int trip_ID;

        private void Form1_Load(object sender, EventArgs e)
        {
            var region = Trip.lsTrip.Where(t => t.Id == trip_ID).Select(t => t.Name).FirstOrDefault();
            lblRegion.Text = region;
            dgvParticipants.DataSource = Trip.DisplayPeople();
        }




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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            MultiPage.SetPage("tabPage1");
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            MultiPage.SetPage("tabPage2");
        }
        //////////////////////////////////////////////////////////////////////////////////////////



    }
}
