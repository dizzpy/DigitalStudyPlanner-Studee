namespace DigitalStudyPlanner_Studee.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_goodMorning = new System.Windows.Forms.Label();
            this.label_hello = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_noteLibrary = new System.Windows.Forms.Button();
            this.btn_timer = new System.Windows.Forms.Button();
            this.btn_events = new System.Windows.Forms.Button();
            this.btn_toDoList = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_goodMorning = new System.Windows.Forms.Label();
            this.label_hello = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
=======
            this.timerView1 = new DigitalStudyPlanner_Studee.Views.TimerView();
            this.eventsView1 = new DigitalStudyPlanner_Studee.Views.EventsView();
            this.toDoListView2 = new DigitalStudyPlanner_Studee.Views.ToDoListView();
            this.dashboardView1 = new DigitalStudyPlanner_Studee.Views.DashboardView();
            this.toDoListView1 = new DigitalStudyPlanner_Studee.Views.ToDoListView();
            this.noteLibraryView1 = new DigitalStudyPlanner_Studee.Views.NoteLibraryView();
>>>>>>> Stashed changes
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 696);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_logout);
            this.panel5.Controls.Add(this.btn_setting);
            this.panel5.Controls.Add(this.btn_profile);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 520);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 176);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 431);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 64);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_noteLibrary);
            this.panel3.Controls.Add(this.btn_timer);
            this.panel3.Controls.Add(this.btn_events);
            this.panel3.Controls.Add(this.btn_toDoList);
            this.panel3.Controls.Add(this.btn_dashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 287);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_goodMorning);
            this.panel2.Controls.Add(this.label_hello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 144);
            this.panel2.TabIndex = 1;
            // 
            // label_goodMorning
            // 
            this.label_goodMorning.AutoSize = true;
            this.label_goodMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goodMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_goodMorning.Location = new System.Drawing.Point(33, 87);
            this.label_goodMorning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_goodMorning.Name = "label_goodMorning";
            this.label_goodMorning.Size = new System.Drawing.Size(156, 24);
            this.label_goodMorning.TabIndex = 2;
            this.label_goodMorning.Text = "Good Morning !";
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_hello.Location = new System.Drawing.Point(28, 37);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(242, 44);
            this.label_hello.TabIndex = 1;
            this.label_hello.Text = "Hello Dizzpy";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.noteLibraryView1);
            this.panel4.Controls.Add(this.timerView1);
            this.panel4.Controls.Add(this.eventsView1);
            this.panel4.Controls.Add(this.toDoListView2);
            this.panel4.Controls.Add(this.dashboardView1);
            this.panel4.Controls.Add(this.toDoListView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(302, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(974, 696);
            this.panel4.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_logout.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 114);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(302, 57);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.btn_setting.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.settings;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 57);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_setting.Size = new System.Drawing.Size(302, 57);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "Settings";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.btn_profile.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.profile;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(0, 0);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_profile.Size = new System.Drawing.Size(302, 57);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
<<<<<<< Updated upstream
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 405);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 64);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_noteLibrary);
            this.panel3.Controls.Add(this.btn_timer);
            this.panel3.Controls.Add(this.btn_events);
            this.panel3.Controls.Add(this.btn_toDoList);
            this.panel3.Controls.Add(this.btn_dashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 287);
            this.panel3.TabIndex = 2;
            // 
=======
>>>>>>> Stashed changes
            // btn_noteLibrary
            // 
            this.btn_noteLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_noteLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_noteLibrary.FlatAppearance.BorderSize = 0;
            this.btn_noteLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_noteLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_noteLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noteLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noteLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_noteLibrary.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.notes;
            this.btn_noteLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noteLibrary.Location = new System.Drawing.Point(0, 228);
            this.btn_noteLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.btn_noteLibrary.Name = "btn_noteLibrary";
            this.btn_noteLibrary.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_noteLibrary.Size = new System.Drawing.Size(302, 57);
            this.btn_noteLibrary.TabIndex = 5;
            this.btn_noteLibrary.Text = "Note Library";
            this.btn_noteLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noteLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_noteLibrary.UseVisualStyleBackColor = true;
            this.btn_noteLibrary.Click += new System.EventHandler(this.btn_noteLibrary_Click);
            // 
            // btn_timer
            // 
            this.btn_timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_timer.FlatAppearance.BorderSize = 0;
            this.btn_timer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_timer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_timer.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.timer;
            this.btn_timer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timer.Location = new System.Drawing.Point(0, 171);
            this.btn_timer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timer.Name = "btn_timer";
            this.btn_timer.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_timer.Size = new System.Drawing.Size(302, 57);
            this.btn_timer.TabIndex = 4;
            this.btn_timer.Text = "Timer";
            this.btn_timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timer.UseVisualStyleBackColor = true;
            this.btn_timer.Click += new System.EventHandler(this.btn_timer_Click);
            // 
            // btn_events
            // 
            this.btn_events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_events.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_events.FlatAppearance.BorderSize = 0;
            this.btn_events.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_events.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_events.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.events;
            this.btn_events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.Location = new System.Drawing.Point(0, 114);
            this.btn_events.Margin = new System.Windows.Forms.Padding(2);
            this.btn_events.Name = "btn_events";
            this.btn_events.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_events.Size = new System.Drawing.Size(302, 57);
            this.btn_events.TabIndex = 3;
            this.btn_events.Text = "Events";
            this.btn_events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_events.UseVisualStyleBackColor = true;
            this.btn_events.Click += new System.EventHandler(this.btn_events_Click);
            // 
            // btn_toDoList
            // 
            this.btn_toDoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toDoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_toDoList.FlatAppearance.BorderSize = 0;
            this.btn_toDoList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_toDoList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_toDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toDoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_toDoList.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.task1;
            this.btn_toDoList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toDoList.Location = new System.Drawing.Point(0, 57);
            this.btn_toDoList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toDoList.Name = "btn_toDoList";
            this.btn_toDoList.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_toDoList.Size = new System.Drawing.Size(302, 57);
            this.btn_toDoList.TabIndex = 2;
            this.btn_toDoList.Text = "To Do List";
            this.btn_toDoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toDoList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_toDoList.UseVisualStyleBackColor = true;
            this.btn_toDoList.Click += new System.EventHandler(this.btn_toDoList_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_dashboard.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.home1;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(302, 57);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // timerView1
            // 
<<<<<<< Updated upstream
            this.panel2.Controls.Add(this.label_goodMorning);
            this.panel2.Controls.Add(this.label_hello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 118);
            this.panel2.TabIndex = 1;
=======
            this.timerView1.BackColor = System.Drawing.Color.White;
            this.timerView1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerView1.Location = new System.Drawing.Point(0, 0);
            this.timerView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timerView1.Name = "timerView1";
            this.timerView1.Size = new System.Drawing.Size(974, 696);
            this.timerView1.TabIndex = 4;
>>>>>>> Stashed changes
            // 
            // eventsView1
            // 
<<<<<<< Updated upstream
            this.label_goodMorning.AutoSize = true;
            this.label_goodMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goodMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_goodMorning.Location = new System.Drawing.Point(29, 67);
            this.label_goodMorning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_goodMorning.Name = "label_goodMorning";
            this.label_goodMorning.Size = new System.Drawing.Size(156, 24);
            this.label_goodMorning.TabIndex = 2;
            this.label_goodMorning.Text = "Good Morning !";
=======
            this.eventsView1.BackColor = System.Drawing.Color.White;
            this.eventsView1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsView1.Location = new System.Drawing.Point(0, 0);
            this.eventsView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventsView1.Name = "eventsView1";
            this.eventsView1.Size = new System.Drawing.Size(974, 696);
            this.eventsView1.TabIndex = 3;
>>>>>>> Stashed changes
            // 
            // toDoListView2
            // 
<<<<<<< Updated upstream
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_hello.Location = new System.Drawing.Point(20, 14);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(242, 44);
            this.label_hello.TabIndex = 1;
            this.label_hello.Text = "Hello Dizzpy";
=======
            this.toDoListView2.BackColor = System.Drawing.Color.White;
            this.toDoListView2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListView2.Location = new System.Drawing.Point(0, 0);
            this.toDoListView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toDoListView2.Name = "toDoListView2";
            this.toDoListView2.Size = new System.Drawing.Size(974, 696);
            this.toDoListView2.TabIndex = 2;
>>>>>>> Stashed changes
            // 
            // dashboardView1
            // 
<<<<<<< Updated upstream
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(302, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(974, 696);
            this.panel4.TabIndex = 1;
            // 
=======
            this.dashboardView1.BackColor = System.Drawing.Color.White;
            this.dashboardView1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardView1.Location = new System.Drawing.Point(0, 0);
            this.dashboardView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dashboardView1.Name = "dashboardView1";
            this.dashboardView1.Size = new System.Drawing.Size(974, 696);
            this.dashboardView1.TabIndex = 1;
            // 
            // toDoListView1
            // 
            this.toDoListView1.BackColor = System.Drawing.Color.White;
            this.toDoListView1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoListView1.Location = new System.Drawing.Point(296, -439);
            this.toDoListView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toDoListView1.Name = "toDoListView1";
            this.toDoListView1.Size = new System.Drawing.Size(974, 696);
            this.toDoListView1.TabIndex = 1;
            // 
            // noteLibraryView1
            // 
            this.noteLibraryView1.BackColor = System.Drawing.Color.White;
            this.noteLibraryView1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLibraryView1.Location = new System.Drawing.Point(0, 0);
            this.noteLibraryView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noteLibraryView1.Name = "noteLibraryView1";
            this.noteLibraryView1.Size = new System.Drawing.Size(974, 696);
            this.noteLibraryView1.TabIndex = 0;
            // 
>>>>>>> Stashed changes
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 696);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
<<<<<<< Updated upstream
=======
            this.panel4.ResumeLayout(false);
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_goodMorning;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_timer;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_toDoList;
        private System.Windows.Forms.Button btn_noteLibrary;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Panel panel6;
<<<<<<< Updated upstream
=======
        private DashboardView dashboardView1;
        private TimerView timerView1;
        private EventsView eventsView1;
        private ToDoListView toDoListView2;
        private ToDoListView toDoListView1;
        private NoteLibraryView noteLibraryView1;
>>>>>>> Stashed changes
    }
}