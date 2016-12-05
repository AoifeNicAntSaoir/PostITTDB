using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostITTDB
{
    public partial class frmUpdateStatus : Form
    {
        public frmUpdateStatus()
        {
            InitializeComponent();
        }

        private void frmUpdateStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postITTDS.TAG' table. You can move, or remove it, as needed.
            this.tAGTableAdapter.Fill(this.postITTDS.TAG);
            // TODO: This line of code loads data into the 'postITTDS.POSTTYPEDESCVIEW' table. You can move, or remove it, as needed.
            this.pOSTTYPEDESCVIEWTableAdapter.Fill(this.postITTDS.POSTTYPEDESCVIEW);
            // TODO: This line of code loads data into the 'postITTDS.CATEGORYVIEW' table. You can move, or remove it, as needed.
            this.cATEGORYVIEWTableAdapter.Fill(this.postITTDS.CATEGORYVIEW);
    



        }

     
    private void btnPost_Click(object sender, EventArgs e)
        {
            /*int catId = categoryComboBoxItem();
            int postTypeId = postTypeComboBoxItem();*/

        }

      
       public int postTypeComboBoxItem()
        {
           
           if(pOSTTYPEDESCVIEWComboBox.SelectedValue.Equals("Informative")){
                return 1;
            }
            else if (pOSTTYPEDESCVIEWComboBox.SelectedValue.Equals("Reply"))
            {
                return 2;
            }
           else if (pOSTTYPEDESCVIEWComboBox.SelectedValue.Equals("Question"))
            {
                return 3;
            }
           else if (pOSTTYPEDESCVIEWComboBox.SelectedValue.Equals("Answer"))
            {
                return 4;
            }
            return 1;
        }

        public int categoryComboBoxItem()
        {
            if (cATEGORYVIEWComboBox.SelectedValue.Equals("Computing"))
            {
                return 1;
            }
            else if (cATEGORYVIEWComboBox.SelectedValue.Equals("Business"))
            {
                return 2;
            }
            else if (cATEGORYVIEWComboBox.SelectedValue.Equals("Creative Media"))
            {
                return 3;
            }
            else if (cATEGORYVIEWComboBox.SelectedValue.Equals("Engineering"))
            {
                return 4;
            }
            else if (cATEGORYVIEWComboBox.SelectedValue.Equals("Nursing"))
            {
                return 5;

            }
            return 1;

        }

      

        private void btnPost_Click_1(object sender, EventArgs e)
        {
            if(txtPost.Text == "")
            {
                MessageBox.Show("Message cannot be empty...", "Empty Post!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPost.Focus();
                return;
            }
            string text = txtPost.Text.Trim();
            int postTypeID = postTypeComboBoxItem();
            int catid = categoryComboBoxItem();



            using (var context = new PostITTEntities())
            {
               
                POST newPost = new POST();

                newPost.POSTTEXT = text;
                newPost.USERID = 1;
                newPost.POSTTYPEID = (short)postTypeID;
                newPost.CATEGORYID = (short)catid;

                try
                {
                    context.INSERTPOST(newPost.POSTTEXT, newPost.USERID, newPost.POSTTYPEID, newPost.CATEGORYID);
                    MessageBox.Show("Post added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Raw SQL query
                    var lastPost = context.Database.SqlQuery<int>("Select max(postid) from post").FirstOrDefault();
                    if (postTypeID == 1 || postTypeID == 3)
                    {
                        var childPost = lastPost - 1;
                        context.REPLYPOSTPROC(childPost, lastPost);
                        
                    }
                    else if(postTypeID == 2 || postTypeID == 4)
                    {
                        context.INITIALPOST(lastPost.ToString());
                    }
                    
                    context.SaveChanges();
                    return;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.GetBaseException().ToString(), "Error posting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    txtPost.Text = "";
                }

            }

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
            frmViewUsers leaderBoard = new frmViewUsers();
            this.Hide();
            leaderBoard.Show();
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
