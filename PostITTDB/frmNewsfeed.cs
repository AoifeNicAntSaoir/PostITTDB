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
    public partial class frmNewsfeed : Form
    {
        public frmNewsfeed()
        {
            InitializeComponent();
        }

        private void newsfeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewsfeed newsfeed = new frmNewsfeed();
            this.Hide();
            newsfeed.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUsers viewProf = new frmViewUsers();
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
            frmChangePassword chgPassword = new frmChangePassword();
            this.Hide();
            chgPassword.Show();
        }

        private void frmNewsfeed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewPosts.VIEWPOSTS' table. You can move, or remove it, as needed.
            this.vIEWPOSTSTableAdapter.Fill(this.viewPosts.VIEWPOSTS);

        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStatus updateStatus = new frmUpdateStatus();
            this.Hide();
            updateStatus.Show();
        }
    }
}
