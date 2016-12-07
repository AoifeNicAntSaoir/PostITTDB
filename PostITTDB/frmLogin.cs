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
    
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Password", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a email", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            using (var context = new PostITTEntities())
            {
                ITTUSER newStudent = new ITTUSER()
                {
                    EMAIL = txtEmail.Text,
                    PASSWORD = txtPassword.Text
                };
                try
                     {
                    var result = context.LOGIN(newStudent.EMAIL, newStudent.PASSWORD);
                    context.SaveChanges();
                    MessageBox.Show("You have been successfully logged in", "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    var surnamequery = (from u in context.ITTUSERs
                                          where u.EMAIL == newStudent.EMAIL
                                          select u.SURNAME);

                    foreach (var u in surnamequery)
                    {
                        CurrentLoginUser.surname = u.ToString();
                    }


                    var firstnamequery = (from u in context.ITTUSERs
                                        where u.EMAIL == newStudent.EMAIL
                                        select u.FIRSTNAME);

                    foreach(var u in firstnamequery)
                    {
                        CurrentLoginUser.firstname = u.ToString();
                    }

                    var useridquery = (from u in context.ITTUSERs
                                          where u.EMAIL == newStudent.EMAIL
                                          select u.USERID);

                    foreach(var u in useridquery)
                    {
                        CurrentLoginUser.userid = u.ToString();
                    }
                                 





                    frmNewsfeed newsFeed = new frmNewsfeed();
                    this.Hide();
                    newsFeed.Show();

                }
                catch (Exception ex)
                {
                    lblError.Visible = true;
                    MessageBox.Show(ex.GetBaseException().ToString());
                    return;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
