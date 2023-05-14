using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicFund
{
    public partial class VolunteersPrticipation : Form
    {
        function fn = new function();
        public VolunteersPrticipation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvitedVoluteers_Load(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "SELECT * FROM EVENT_MANAGEMENT";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = true;
            txtID.Visible = true;
            btnSearch.Visible = true;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "select VID As [Volunteer ID],COUNT(VID) AS [Total Participation] from EVENT_MANAGEMENT where STATUS LIKE 'YES' Group by vID";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtForID.Visible = false;
            txtID.Visible = false;
            btnSearch.Visible = false;
            string query = "select VID As [Volunteer ID],COUNT(VID) AS [Total Participation] from EVENT_MANAGEMENT where STATUS LIKE 'YES' Group By vID ORDER By COUNT(VID) desc";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true )
            {
                Int64 id = Int64.Parse(txtID.Text.ToString());
                string query = "select Eid As [Event ID],COUNT(VID) AS [Total Volunteer] from EVENT_MANAGEMENT where eID = " + id + " Group by eID";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
