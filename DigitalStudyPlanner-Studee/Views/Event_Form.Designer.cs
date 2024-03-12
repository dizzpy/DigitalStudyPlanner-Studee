namespace DigitalStudyPlanner_Studee.Views
{
    partial class Event_Form
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
            this.Label_Dashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Dashboard
            // 
            this.Label_Dashboard.AutoSize = true;
            this.Label_Dashboard.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dashboard.Location = new System.Drawing.Point(400, 293);
            this.Label_Dashboard.Name = "Label_Dashboard";
            this.Label_Dashboard.Size = new System.Drawing.Size(134, 65);
            this.Label_Dashboard.TabIndex = 2;
            this.Label_Dashboard.Text = "Event";
            // 
            // Event_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 657);
            this.Controls.Add(this.Label_Dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Event_Form";
            this.Text = "Event_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Dashboard;
    }
}