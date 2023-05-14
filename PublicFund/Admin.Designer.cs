namespace PublicFund
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewVolunteersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVolunteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewSponsorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSponsorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewAllEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btFund = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.BtnLogout = new System.Windows.Forms.ToolStripButton();
            this.eventManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendInvitationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripLabel2,
            this.toolStripDropDownButton2,
            this.toolStripLabel3,
            this.toolStripDropDownButton3,
            this.toolStripLabel4,
            this.btFund,
            this.toolStripLabel5,
            this.BtnLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 59);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(149, 54);
            this.toolStripLabel1.Text = " Volunteer";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVolunteersListToolStripMenuItem,
            this.deleteVolunteerToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendInvitationToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(68, 54);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // viewVolunteersListToolStripMenuItem
            // 
            this.viewVolunteersListToolStripMenuItem.Name = "viewVolunteersListToolStripMenuItem";
            this.viewVolunteersListToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewVolunteersListToolStripMenuItem.Text = "View Volunteers List";
            this.viewVolunteersListToolStripMenuItem.Click += new System.EventHandler(this.viewVolunteersListToolStripMenuItem_Click);
            // 
            // deleteVolunteerToolStripMenuItem
            // 
            this.deleteVolunteerToolStripMenuItem.Name = "deleteVolunteerToolStripMenuItem";
            this.deleteVolunteerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteVolunteerToolStripMenuItem.Text = "Delete Volunteer";
            this.deleteVolunteerToolStripMenuItem.Click += new System.EventHandler(this.deleteVolunteerToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(140, 54);
            this.toolStripLabel2.Text = "   Sopnsor";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSponsorsListToolStripMenuItem,
            this.deleteSponsorToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(68, 54);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // viewSponsorsListToolStripMenuItem
            // 
            this.viewSponsorsListToolStripMenuItem.Name = "viewSponsorsListToolStripMenuItem";
            this.viewSponsorsListToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewSponsorsListToolStripMenuItem.Text = "View Sponsors List";
            this.viewSponsorsListToolStripMenuItem.Click += new System.EventHandler(this.viewSponsorsListToolStripMenuItem_Click);
            // 
            // deleteSponsorToolStripMenuItem
            // 
            this.deleteSponsorToolStripMenuItem.Name = "deleteSponsorToolStripMenuItem";
            this.deleteSponsorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteSponsorToolStripMenuItem.Text = "Delete Sponsor";
            this.deleteSponsorToolStripMenuItem.Click += new System.EventHandler(this.deleteSponsorToolStripMenuItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(115, 54);
            this.toolStripLabel3.Text = "   Event";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllEventsToolStripMenuItem,
            this.createNewEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.updateEventToolStripMenuItem,
            this.eventManagementToolStripMenuItem,
            this.eventStatisticsToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(68, 54);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // viewAllEventsToolStripMenuItem
            // 
            this.viewAllEventsToolStripMenuItem.Name = "viewAllEventsToolStripMenuItem";
            this.viewAllEventsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewAllEventsToolStripMenuItem.Text = "View All Events";
            this.viewAllEventsToolStripMenuItem.Click += new System.EventHandler(this.viewAllEventsToolStripMenuItem_Click);
            // 
            // createNewEventToolStripMenuItem
            // 
            this.createNewEventToolStripMenuItem.Name = "createNewEventToolStripMenuItem";
            this.createNewEventToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.createNewEventToolStripMenuItem.Text = "Create New Event";
            this.createNewEventToolStripMenuItem.Click += new System.EventHandler(this.createNewEventToolStripMenuItem_Click);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteEventToolStripMenuItem.Text = "Delete Event";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
            // 
            // updateEventToolStripMenuItem
            // 
            this.updateEventToolStripMenuItem.Name = "updateEventToolStripMenuItem";
            this.updateEventToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateEventToolStripMenuItem.Text = "Update Event";
            this.updateEventToolStripMenuItem.Click += new System.EventHandler(this.updateEventToolStripMenuItem_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(108, 54);
            this.toolStripLabel4.Text = "   Fund";
            // 
            // btFund
            // 
            this.btFund.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFund.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFund.Image = ((System.Drawing.Image)(resources.GetObject("btFund.Image")));
            this.btFund.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btFund.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFund.Name = "btFund";
            this.btFund.Size = new System.Drawing.Size(54, 54);
            this.btFund.Text = "toolStripButton1";
            this.btFund.Click += new System.EventHandler(this.btFund_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(342, 54);
            this.toolStripLabel5.Text = "                         Log Out";
            // 
            // BtnLogout
            // 
            this.BtnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(34, 24);
            this.BtnLogout.Text = "toolStripButton2";
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click_1);
            // 
            // eventManagementToolStripMenuItem
            // 
            this.eventManagementToolStripMenuItem.Name = "eventManagementToolStripMenuItem";
            this.eventManagementToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eventManagementToolStripMenuItem.Text = "Event Management";
            this.eventManagementToolStripMenuItem.Click += new System.EventHandler(this.eventManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // sendInvitationToolStripMenuItem
            // 
            this.sendInvitationToolStripMenuItem.Name = "sendInvitationToolStripMenuItem";
            this.sendInvitationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sendInvitationToolStripMenuItem.Text = "Send Invitation";
            this.sendInvitationToolStripMenuItem.Click += new System.EventHandler(this.sendInvitationToolStripMenuItem_Click);
            // 
            // eventStatisticsToolStripMenuItem
            // 
            this.eventStatisticsToolStripMenuItem.Name = "eventStatisticsToolStripMenuItem";
            this.eventStatisticsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eventStatisticsToolStripMenuItem.Text = "Event Statistics";
            this.eventStatisticsToolStripMenuItem.Click += new System.EventHandler(this.eventStatisticsToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1185, 622);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem viewVolunteersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVolunteerToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem viewSponsorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSponsorToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem viewAllEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton BtnLogout;
        private System.Windows.Forms.ToolStripButton btFund;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendInvitationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventStatisticsToolStripMenuItem;
    }
}