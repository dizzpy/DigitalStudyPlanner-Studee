﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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



        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard_Form());
        }

        private void btn_toDoList_Click(object sender, EventArgs e)
        {
            loadform(new TodoList_Form());
        }


        private void btn_events_Click(object sender, EventArgs e)
        {
            loadform(new EventMain());
        }

        private void btn_noteLibrary_Click(object sender, EventArgs e)
        {
            loadform(new NoteLibraryMain());
        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            loadform(new TimerMain());
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (profile_Form uu = new profile_Form())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;

                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose ();
            }
        }
    }
}

