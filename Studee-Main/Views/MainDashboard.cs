using Studee_Main.Views.UserControlsForms;
using System;
using System.Windows.Forms;

namespace Studee_Main.Views
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            dashboardUC1.Show();
            eventsUC1.Hide();
            toDoListUC1.Hide();
            timerUC1.Hide();
            noteLibraryUC1.Hide();
            dashboardUC1.BringToFront();
        }


        private void DoToListButton_Click(object sender, EventArgs e)
        {
            dashboardUC1.Hide();
            eventsUC1.Hide();
            toDoListUC1.Show();
            timerUC1.Hide();
            noteLibraryUC1.Hide();
            toDoListUC1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.Show();
            eventsUC1.Hide();
            toDoListUC1.Hide();
            timerUC1.Hide();
            noteLibraryUC1.Hide();
            dashboardUC1.BringToFront();
        }
    }
}
