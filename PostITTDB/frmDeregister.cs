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
    public partial class frmDeregister : Form
    {
        public frmDeregister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var context = new PostITTEntities())
            {

                ITTUSER newStudent = new ITTUSER()
                {
                    FIRSTNAME = txtFirstName.Text,
                    SURNAME = txtSurname.Text,
                    PASSWORD = txtPassword.Text
                };
                try
                {
                  DialogResult res =  MessageBox.Show("Are you sure you want to De-reigister " + newStudent.FIRSTNAME + " " + newStudent.SURNAME +
                                    "?", "Delete User",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        var result = context.DEREGISTERITTUSER(newStudent.FIRSTNAME, newStudent.SURNAME, newStudent.PASSWORD);
                        context.SaveChanges();
                        MessageBox.Show(newStudent.FIRSTNAME + " " + newStudent.SURNAME + " account has been deleted", "Account De-Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }

        private void newsfeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewsfeed newsfeed = new frmNewsfeed();
            this.Hide();
            newsfeed.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewProfile prof = new frmViewProfile();
            this.Hide();
            prof.Show();
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

        private void updateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStatus updateStatus = new frmUpdateStatus();
            this.Hide();
            updateStatus.Show();
        }
    }
}
