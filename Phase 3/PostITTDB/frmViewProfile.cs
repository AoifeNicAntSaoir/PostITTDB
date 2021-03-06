﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace PostITTDB
{
    public partial class frmViewProfile : Form
    {
        public frmViewProfile()
        {
            InitializeComponent();
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


        private void frmUpdateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStatus updateStatus = new frmUpdateStatus();
            this.Hide();
            updateStatus.Show();
        }

        private void frmViewProfile_Load(object sender, EventArgs e)
        {
            txtFirstname.Text = CurrentLoginUser.firstname;
            lblSurnameLog.Text = CurrentLoginUser.surname;

            POST newpost = new POST();
            newpost.USERID = (short)Convert.ToInt16(CurrentLoginUser.userid);
            using (var context = new PostITTDS())
            {
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = (from r in context.POST
                                             where (r.USERID == newpost.USERID)
                                             select new { r.POSTDATE, r.POSTTEXT }).ToList();

                dataGridProfilePosts.DataSource = bindingSource1;
            }


            dataGridProfilePosts.Update();
            dataGridProfilePosts.Refresh();


        }
    }
}
