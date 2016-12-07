namespace PostITTDB
{
    partial class frmViewProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProfile));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newsfeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmUpdateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWPOSTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vIEWPOSTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postITTDS = new PostITTDB.PostITTDS();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vIEWPOSTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.viewpostsTableAdapter1 = new PostITTDB.PostITTDSTableAdapters.VIEWPOSTSTableAdapter();
            this.postTableAdapter1 = new PostITTDB.PostITTDSTableAdapters.POSTTableAdapter();
            this.tableAdapterManager = new PostITTDB.PostITTDSTableAdapters.TableAdapterManager();
            this.usertypeTableAdapter1 = new PostITTDB.PostITTDSTableAdapters.USERTYPETableAdapter();
            this.lblSurnameLog = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dataGridProfilePosts = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingNavigator)).BeginInit();
            this.vIEWPOSTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfilePosts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsfeedToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.deregisterToolStripMenuItem,
            this.frmUpdateStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newsfeedToolStripMenuItem
            // 
            this.newsfeedToolStripMenuItem.Name = "newsfeedToolStripMenuItem";
            this.newsfeedToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.newsfeedToolStripMenuItem.Text = "Newsfeed";
            this.newsfeedToolStripMenuItem.Click += new System.EventHandler(this.newsfeedToolStripMenuItem_Click);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.viewUsersToolStripMenuItem.Text = "View Leaderboard";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // deregisterToolStripMenuItem
            // 
            this.deregisterToolStripMenuItem.Name = "deregisterToolStripMenuItem";
            this.deregisterToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.deregisterToolStripMenuItem.Text = "Deregister";
            this.deregisterToolStripMenuItem.Click += new System.EventHandler(this.deregisterToolStripMenuItem_Click);
            // 
            // frmUpdateStatusToolStripMenuItem
            // 
            this.frmUpdateStatusToolStripMenuItem.Name = "frmUpdateStatusToolStripMenuItem";
            this.frmUpdateStatusToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.frmUpdateStatusToolStripMenuItem.Text = "Update Status";
            this.frmUpdateStatusToolStripMenuItem.Click += new System.EventHandler(this.frmUpdateStatusToolStripMenuItem_Click);
            // 
            // vIEWPOSTSBindingNavigator
            // 
            this.vIEWPOSTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vIEWPOSTSBindingNavigator.BindingSource = this.vIEWPOSTSBindingSource;
            this.vIEWPOSTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vIEWPOSTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vIEWPOSTSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vIEWPOSTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vIEWPOSTSBindingNavigatorSaveItem});
            this.vIEWPOSTSBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.vIEWPOSTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vIEWPOSTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vIEWPOSTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vIEWPOSTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vIEWPOSTSBindingNavigator.Name = "vIEWPOSTSBindingNavigator";
            this.vIEWPOSTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vIEWPOSTSBindingNavigator.Size = new System.Drawing.Size(1046, 27);
            this.vIEWPOSTSBindingNavigator.TabIndex = 51;
            this.vIEWPOSTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // vIEWPOSTSBindingSource
            // 
            this.vIEWPOSTSBindingSource.DataMember = "VIEWPOSTS";
            this.vIEWPOSTSBindingSource.DataSource = this.postITTDS;
            // 
            // postITTDS
            // 
            this.postITTDS.DataSetName = "PostITTDS";
            this.postITTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // vIEWPOSTSBindingNavigatorSaveItem
            // 
            this.vIEWPOSTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vIEWPOSTSBindingNavigatorSaveItem.Enabled = false;
            this.vIEWPOSTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWPOSTSBindingNavigatorSaveItem.Image")));
            this.vIEWPOSTSBindingNavigatorSaveItem.Name = "vIEWPOSTSBindingNavigatorSaveItem";
            this.vIEWPOSTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vIEWPOSTSBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // viewpostsTableAdapter1
            // 
            this.viewpostsTableAdapter1.ClearBeforeFill = true;
            // 
            // postTableAdapter1
            // 
            this.postTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CLUBTableAdapter = null;
            this.tableAdapterManager.ITTUSERTableAdapter = null;
            this.tableAdapterManager.MEDIATableAdapter = null;
            this.tableAdapterManager.MEDIATYPETableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = this.postTableAdapter1;
            this.tableAdapterManager.POSTTYPETableAdapter = null;
            this.tableAdapterManager.RANKTableAdapter = null;
            this.tableAdapterManager.SCHOOLTableAdapter = null;
            this.tableAdapterManager.TAGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PostITTDB.PostITTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTYPETableAdapter = null;
            // 
            // usertypeTableAdapter1
            // 
            this.usertypeTableAdapter1.ClearBeforeFill = true;
            // 
            // lblSurnameLog
            // 
            this.lblSurnameLog.AutoSize = true;
            this.lblSurnameLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameLog.Location = new System.Drawing.Point(194, 141);
            this.lblSurnameLog.Name = "lblSurnameLog";
            this.lblSurnameLog.Size = new System.Drawing.Size(0, 25);
            this.lblSurnameLog.TabIndex = 58;
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoSize = true;
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(192, 97);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(0, 25);
            this.txtFirstname.TabIndex = 57;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(64, 133);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(113, 25);
            this.lblSurname.TabIndex = 56;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(55, 97);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(131, 25);
            this.lblFirstName.TabIndex = 55;
            this.lblFirstName.Text = "First Name:";
            // 
            // dataGridProfilePosts
            // 
            this.dataGridProfilePosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfilePosts.Location = new System.Drawing.Point(88, 214);
            this.dataGridProfilePosts.Name = "dataGridProfilePosts";
            this.dataGridProfilePosts.RowTemplate.Height = 24;
            this.dataGridProfilePosts.Size = new System.Drawing.Size(843, 150);
            this.dataGridProfilePosts.TabIndex = 59;
            // 
            // frmViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 482);
            this.Controls.Add(this.dataGridProfilePosts);
            this.Controls.Add(this.lblSurnameLog);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.vIEWPOSTSBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmViewProfile";
            this.Text = "frmViewProfile";
            this.Load += new System.EventHandler(this.frmViewProfile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingNavigator)).EndInit();
            this.vIEWPOSTSBindingNavigator.ResumeLayout(false);
            this.vIEWPOSTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfilePosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newsfeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterToolStripMenuItem;
        private PostITTDSTableAdapters.VIEWPOSTSTableAdapter viewpostsTableAdapter1;
        private PostITTDSTableAdapters.POSTTableAdapter postTableAdapter1;
        private PostITTDS postITTDS;
        private System.Windows.Forms.BindingSource vIEWPOSTSBindingSource;
        private PostITTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vIEWPOSTSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vIEWPOSTSBindingNavigatorSaveItem;
        private PostITTDSTableAdapters.USERTYPETableAdapter usertypeTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem frmUpdateStatusToolStripMenuItem;
        private System.Windows.Forms.Label lblSurnameLog;
        private System.Windows.Forms.Label txtFirstname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridView dataGridProfilePosts;
    }
}