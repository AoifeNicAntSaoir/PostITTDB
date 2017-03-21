using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostITTDB
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        private void viewUsers_Load(object sender, EventArgs e)
        {

            txtFirstname.Text = CurrentLoginUser.firstname;
            lblSurnameLog.Text = CurrentLoginUser.surname;

            // TODO: This line of code loads data into the 'postITTDS.VIEWUSER' table. You can move, or remove it, as needed.
            this.vIEWUSERTableAdapter.Fill(this.postITTDS.VIEWUSER);

            // TODO: This line of code loads data into the 'postITTDS.VIEWUSERPROFILE' table. You can move, or remove it, as needed.
            this.vIEWUSERPROFILETableAdapter.Fill(this.postITTDS.VIEWUSERPROFILE);

            vIEWUSERDataGridView.Update();
            vIEWUSERDataGridView.Refresh();

        }

        private void newsfeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewsfeed newsFeed = new frmNewsfeed();
            this.Hide();
            newsFeed.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewProfile viewProfile = new frmViewProfile();
            this.Hide();
            viewProfile.Show();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUsers users = new frmViewUsers();
            this.Hide();
            users.Show();
        }

        private void deregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeregister dereg = new frmDeregister();
            this.Hide();
            dereg.Show();
        }

        private void vIEWUSERPROFILEBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
          
        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStatus updateStatus = new frmUpdateStatus();
            this.Hide();
            updateStatus.Show();
        }
    }
}
