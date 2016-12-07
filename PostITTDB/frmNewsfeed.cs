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
        private frmLogin loginDetails;
        public frmNewsfeed()
        {
            InitializeComponent();
            loginDetails = new frmLogin();
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
            txtFirstname.Text = CurrentLoginUser.firstname;
            lblSurnameLog.Text = CurrentLoginUser.surname;

            // TODO: This line of code loads data into the 'viewPosts.VIEWPOSTS' table. You can move, or remove it, as needed.
            this.vIEWPOSTSTableAdapter.Fill(this.viewPosts.VIEWPOSTS);

       

        }

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStatus updateStatus = new frmUpdateStatus();
            this.Hide();
            updateStatus.Show();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            int selectedrowindex = vIEWPOSTSDataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = vIEWPOSTSDataGridView.Rows[selectedrowindex];

            //Get selected cells from row selected
            String selectedPostID = Convert.ToString(selectedRow.Cells[0].Value);
            int selectedPost = Convert.ToInt32(selectedPostID);
            using (var context = new PostITTEntities())
            {
                try
                {
                    context.RANKPOST(selectedPost);
                    MessageBox.Show("Post has ben ranked!", "Ranked", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }

        }
    }
}
