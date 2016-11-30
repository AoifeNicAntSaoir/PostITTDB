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
    }
}
