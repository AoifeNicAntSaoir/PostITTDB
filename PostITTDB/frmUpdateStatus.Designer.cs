namespace PostITTDB
{
    partial class frmUpdateStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStatus));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.postITTDS = new PostITTDB.PostITTDS();
            this.cATEGORYVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYVIEWTableAdapter = new PostITTDB.PostITTDSTableAdapters.CATEGORYVIEWTableAdapter();
            this.tableAdapterManager = new PostITTDB.PostITTDSTableAdapters.TableAdapterManager();
            this.cATEGORYVIEWBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORYVIEWBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORYVIEWComboBox = new System.Windows.Forms.ComboBox();
            this.pOSTTYPEDESCVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSTTYPEDESCVIEWTableAdapter = new PostITTDB.PostITTDSTableAdapters.POSTTYPEDESCVIEWTableAdapter();
            this.pOSTTYPEDESCVIEWComboBox = new System.Windows.Forms.ComboBox();
            this.tAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAGTableAdapter = new PostITTDB.PostITTDSTableAdapters.TAGTableAdapter();
            this.btnPost = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newsfeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYVIEWBindingNavigator)).BeginInit();
            this.cATEGORYVIEWBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTTYPEDESCVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAGBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(115, 114);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 25);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "Post Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Post Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Post Category:";
            // 
            // txtPost
            // 
            this.txtPost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.Location = new System.Drawing.Point(284, 107);
            this.txtPost.MaxLength = 50;
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(300, 85);
            this.txtPost.TabIndex = 35;
            // 
            // postITTDS
            // 
            this.postITTDS.DataSetName = "PostITTDS";
            this.postITTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYVIEWBindingSource
            // 
            this.cATEGORYVIEWBindingSource.DataMember = "CATEGORYVIEW";
            this.cATEGORYVIEWBindingSource.DataSource = this.postITTDS;
            // 
            // cATEGORYVIEWTableAdapter
            // 
            this.cATEGORYVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CLUBTableAdapter = null;
            this.tableAdapterManager.ITTUSERTableAdapter = null;
            this.tableAdapterManager.MEDIATableAdapter = null;
            this.tableAdapterManager.MEDIATYPETableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.POSTTYPETableAdapter = null;
            this.tableAdapterManager.RANKTableAdapter = null;
            this.tableAdapterManager.SCHOOLTableAdapter = null;
            this.tableAdapterManager.TAGTableAdapter = this.tAGTableAdapter;
            this.tableAdapterManager.UpdateOrder = PostITTDB.PostITTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTYPETableAdapter = null;
            // 
            // cATEGORYVIEWBindingNavigator
            // 
            this.cATEGORYVIEWBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATEGORYVIEWBindingNavigator.BindingSource = this.cATEGORYVIEWBindingSource;
            this.cATEGORYVIEWBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATEGORYVIEWBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATEGORYVIEWBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cATEGORYVIEWBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cATEGORYVIEWBindingNavigatorSaveItem});
            this.cATEGORYVIEWBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATEGORYVIEWBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATEGORYVIEWBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATEGORYVIEWBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATEGORYVIEWBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATEGORYVIEWBindingNavigator.Name = "cATEGORYVIEWBindingNavigator";
            this.cATEGORYVIEWBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATEGORYVIEWBindingNavigator.Size = new System.Drawing.Size(753, 27);
            this.cATEGORYVIEWBindingNavigator.TabIndex = 38;
            this.cATEGORYVIEWBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cATEGORYVIEWBindingNavigatorSaveItem
            // 
            this.cATEGORYVIEWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATEGORYVIEWBindingNavigatorSaveItem.Enabled = false;
            this.cATEGORYVIEWBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cATEGORYVIEWBindingNavigatorSaveItem.Image")));
            this.cATEGORYVIEWBindingNavigatorSaveItem.Name = "cATEGORYVIEWBindingNavigatorSaveItem";
            this.cATEGORYVIEWBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cATEGORYVIEWBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cATEGORYVIEWComboBox
            // 
            this.cATEGORYVIEWComboBox.DataSource = this.cATEGORYVIEWBindingSource;
            this.cATEGORYVIEWComboBox.DisplayMember = "CATEGORYNAME";
            this.cATEGORYVIEWComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cATEGORYVIEWComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cATEGORYVIEWComboBox.FormattingEnabled = true;
            this.cATEGORYVIEWComboBox.Location = new System.Drawing.Point(284, 291);
            this.cATEGORYVIEWComboBox.Name = "cATEGORYVIEWComboBox";
            this.cATEGORYVIEWComboBox.Size = new System.Drawing.Size(300, 33);
            this.cATEGORYVIEWComboBox.TabIndex = 38;
            this.cATEGORYVIEWComboBox.ValueMember = "CATEGORYNAME";
            // 
            // pOSTTYPEDESCVIEWBindingSource
            // 
            this.pOSTTYPEDESCVIEWBindingSource.DataMember = "POSTTYPEDESCVIEW";
            this.pOSTTYPEDESCVIEWBindingSource.DataSource = this.postITTDS;
            // 
            // pOSTTYPEDESCVIEWTableAdapter
            // 
            this.pOSTTYPEDESCVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // pOSTTYPEDESCVIEWComboBox
            // 
            this.pOSTTYPEDESCVIEWComboBox.DataSource = this.pOSTTYPEDESCVIEWBindingSource;
            this.pOSTTYPEDESCVIEWComboBox.DisplayMember = "POSTTYPEDESC";
            this.pOSTTYPEDESCVIEWComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pOSTTYPEDESCVIEWComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSTTYPEDESCVIEWComboBox.FormattingEnabled = true;
            this.pOSTTYPEDESCVIEWComboBox.Location = new System.Drawing.Point(284, 237);
            this.pOSTTYPEDESCVIEWComboBox.Name = "pOSTTYPEDESCVIEWComboBox";
            this.pOSTTYPEDESCVIEWComboBox.Size = new System.Drawing.Size(300, 33);
            this.pOSTTYPEDESCVIEWComboBox.TabIndex = 38;
            this.pOSTTYPEDESCVIEWComboBox.ValueMember = "POSTTYPEDESC";
            // 
            // tAGBindingSource
            // 
            this.tAGBindingSource.DataMember = "TAG";
            this.tAGBindingSource.DataSource = this.postITTDS;
            // 
            // tAGTableAdapter
            // 
            this.tAGTableAdapter.ClearBeforeFill = true;
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(368, 383);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(131, 45);
            this.btnPost.TabIndex = 39;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsfeedToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.deregisterToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.updateStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 28);
            this.menuStrip1.TabIndex = 48;
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
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // updateStatusToolStripMenuItem
            // 
            this.updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            this.updateStatusToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.updateStatusToolStripMenuItem.Text = "Update Status";
            this.updateStatusToolStripMenuItem.Click += new System.EventHandler(this.updateStatusToolStripMenuItem_Click);
            // 
            // frmUpdateStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 536);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pOSTTYPEDESCVIEWComboBox);
            this.Controls.Add(this.cATEGORYVIEWComboBox);
            this.Controls.Add(this.cATEGORYVIEWBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmUpdateStatus";
            this.Text = "frmUpdateStatus";
            this.Load += new System.EventHandler(this.frmUpdateStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYVIEWBindingNavigator)).EndInit();
            this.cATEGORYVIEWBindingNavigator.ResumeLayout(false);
            this.cATEGORYVIEWBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTTYPEDESCVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAGBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPost;
        private PostITTDS postITTDS;
        private System.Windows.Forms.BindingSource cATEGORYVIEWBindingSource;
        private PostITTDSTableAdapters.CATEGORYVIEWTableAdapter cATEGORYVIEWTableAdapter;
        private PostITTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cATEGORYVIEWBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cATEGORYVIEWBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cATEGORYVIEWComboBox;
        private System.Windows.Forms.BindingSource pOSTTYPEDESCVIEWBindingSource;
        private PostITTDSTableAdapters.POSTTYPEDESCVIEWTableAdapter pOSTTYPEDESCVIEWTableAdapter;
        private PostITTDSTableAdapters.TAGTableAdapter tAGTableAdapter;
        private System.Windows.Forms.ComboBox pOSTTYPEDESCVIEWComboBox;
        private System.Windows.Forms.BindingSource tAGBindingSource;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newsfeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStatusToolStripMenuItem;
    }
}