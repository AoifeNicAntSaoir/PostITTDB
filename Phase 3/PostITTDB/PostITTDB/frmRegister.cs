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
                MessageBox.Show("Please enter in a Firstname", "Field Empty",
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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
       

        }
    }
}
