using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIP_APP
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            LoadingTimer.Start();
        }






        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private int _sec = 0;
        //////////////////////////////////////////////////////////////////////////////////////////
        ///
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            _sec++;
            if (_sec == 4)
            {
                new TripForm().Show();
                LoadingTimer.Stop();
                Hide();
            }
        }







        private void LoadingForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void LoadingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void LoadingForm_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;
    }
}
