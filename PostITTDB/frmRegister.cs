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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Firstname", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Firstname", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if(txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Password", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if(txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a e-mail", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            using (var context = new PostITTEntities())
            {

                ITTUSER newStudent = new ITTUSER()
                {
                    FIRSTNAME = txtFirstName.Text,
                    SURNAME = txtSurname.Text,
                    PASSWORD = txtPassword.Text,
                    EMAIL = txtEmail.Text
                };
                try
                {
                    var result = context.CREATEITTUSER(newStudent.FIRSTNAME, newStudent.SURNAME, newStudent.PASSWORD, newStudent.EMAIL);
                    context.SaveChanges();
                    MessageBox.Show(newStudent.FIRSTNAME + " " + newStudent.SURNAME + " account has been created", "Account Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Text = "";
                    txtFirstName.Text = "";
                    txtPassword.Text = "";
                    txtSurname.Text = "";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Visible = true;
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
            viewProf.Hide();
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
    }
}
