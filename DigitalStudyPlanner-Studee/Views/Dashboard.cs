using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DigitalStudyPlanner_Studee.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


<<<<<<< Updated upstream
        //creating border radius

        private void SetRoundedCorners(Panel control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }






        //==============================================================
        //Multiple Forma load in a same pannel
        public void loadform(object form)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);

            Form f = (form) as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(f);
            this.panel4.Tag = f;
            f.Show();
        }


        //dashboard Loadform
=======

>>>>>>> Stashed changes
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            dashboardView1.Show();
            dashboardView1.BringToFront();
            toDoListView1.Hide();   
            eventsView1.Hide();
            timerView1.Hide();
            noteLibraryView1.Hide();

        }

        //Todo List Loadform
        private void btn_toDoList_Click(object sender, EventArgs e)
        {
            toDoListView1.Show();
            toDoListView1.BringToFront();
            dashboardView1.Hide();
            eventsView1.Hide();
            timerView1.Hide();
            noteLibraryView1.Hide();
        }

<<<<<<< Updated upstream
        //Event Loadform
=======
>>>>>>> Stashed changes
        private void btn_events_Click(object sender, EventArgs e)
        {
            eventsView1.Show();
            eventsView1.BringToFront();
            dashboardView1.Hide();
            toDoListView1.Hide();
            timerView1.Hide();
            noteLibraryView1.Hide();
        }

        //Note Library Loadform
        private void btn_noteLibrary_Click(object sender, EventArgs e)
        {
            noteLibraryView1.Show();
            noteLibraryView1.BringToFront();
            dashboardView1.Hide();
            eventsView1.Hide();
            timerView1.Hide();
            toDoListView1.Hide();
        }

        //Timer Loadform
        private void btn_timer_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            loadform(new TimerMain());
        }



        //Application Close button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
=======
            timerView1.Show();
            timerView1.BringToFront();
            dashboardView1.Hide();
            eventsView1.Hide();
            toDoListView1.Hide();
            noteLibraryView1.Hide();
>>>>>>> Stashed changes
        }



        ////Profile popup Loadform
        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form form1 = new profile_Form();
            form1.Show();
        }

        //Settings popup Loadform
        private void btn_setting_Click(object sender, EventArgs e)
        {
            Form form2 = new Settings_Form();
            form2.Show();
        }

<<<<<<< Updated upstream

        //==============================================================




=======
        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardView1.Show();
            dashboardView1.BringToFront();
            toDoListView1.Hide();
            eventsView1.Hide();
            timerView1.Hide();
            noteLibraryView1.Hide();
        }
>>>>>>> Stashed changes
    }
}

