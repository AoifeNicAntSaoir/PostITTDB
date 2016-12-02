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
            // TODO: This line of code loads data into the 'postITTDS.VIEWUSERPOSTSTYPECATTAGRANK' table. You can move, or remove it, as needed.
            this.vIEWUSERPOSTSTYPECATTAGRANKTableAdapter.Fill(this.postITTDS.VIEWUSERPOSTSTYPECATTAGRANK);
            // TODO: This line of code loads data into the 'postITTDS.VIEWUSERPROFILE' table. You can move, or remove it, as needed.
            this.vIEWUSERPROFILETableAdapter.Fill(this.postITTDS.VIEWUSERPROFILE);

        }

        private void newsfeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewsfeed newsFeed = new frmNewsfeed();
            this.Hide();
            newsFeed.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewProfile viewProf = new frmViewProfile();
            this.Hide();
            viewProf.Show();
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword chgPass = new frmChangePassword();
            this.Hide();
            chgPass.Show();
        }
    }
}
