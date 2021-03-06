﻿namespace PostITTDB
{
    partial class frmNewsfeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewsfeed));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newsfeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPosts = new PostITTDB.viewPosts();
            this.vIEWPOSTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWPOSTSTableAdapter = new PostITTDB.viewPostsTableAdapters.VIEWPOSTSTableAdapter();
            this.tableAdapterManager = new PostITTDB.viewPostsTableAdapters.TableAdapterManager();
            this.vIEWPOSTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.btnRank = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.Label();
            this.lblSurnameLog = new System.Windows.Forms.Label();
            this.viewPostsDS = new PostITTDB.ViewPostsDS();
            this.viewPostsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWPOSTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingNavigator)).BeginInit();
            this.vIEWPOSTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPostsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPostsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsfeedToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.deregisterToolStripMenuItem,
            this.updateStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 28);
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
            // updateStatusToolStripMenuItem
            // 
            this.updateStatusToolStripMenuItem.Name = "updateStatusToolStripMenuItem";
            this.updateStatusToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.updateStatusToolStripMenuItem.Text = "Update Status";
            this.updateStatusToolStripMenuItem.Click += new System.EventHandler(this.updateStatusToolStripMenuItem_Click);
            // 
            // viewPosts
            // 
            this.viewPosts.DataSetName = "viewPosts";
            this.viewPosts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWPOSTSBindingSource
            // 
            this.vIEWPOSTSBindingSource.DataMember = "VIEWPOSTS";
            this.vIEWPOSTSBindingSource.DataSource = this.viewPosts;
            // 
            // vIEWPOSTSTableAdapter
            // 
            this.vIEWPOSTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PostITTDB.viewPostsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.vIEWPOSTSBindingNavigator.Size = new System.Drawing.Size(1272, 27);
            this.vIEWPOSTSBindingNavigator.TabIndex = 49;
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
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRank.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.White;
            this.btnRank.Location = new System.Drawing.Point(471, 386);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(170, 63);
            this.btnRank.TabIndex = 50;
            this.btnRank.Text = "Rank Post";
            this.btnRank.UseVisualStyleBackColor = false;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Blue;
            this.lblSurname.Location = new System.Drawing.Point(79, 109);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(119, 25);
            this.lblSurname.TabIndex = 52;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Blue;
            this.lblFirstName.Location = new System.Drawing.Point(56, 73);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(142, 25);
            this.lblFirstName.TabIndex = 51;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoSize = true;
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(207, 73);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(0, 25);
            this.txtFirstname.TabIndex = 53;
            // 
            // lblSurnameLog
            // 
            this.lblSurnameLog.AutoSize = true;
            this.lblSurnameLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameLog.Location = new System.Drawing.Point(209, 117);
            this.lblSurnameLog.Name = "lblSurnameLog";
            this.lblSurnameLog.Size = new System.Drawing.Size(0, 25);
            this.lblSurnameLog.TabIndex = 54;
            // 
            // viewPostsDS
            // 
            this.viewPostsDS.DataSetName = "ViewPostsDS";
            this.viewPostsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPostsDSBindingSource
            // 
            this.viewPostsDSBindingSource.DataSource = this.viewPostsDS;
            this.viewPostsDSBindingSource.Position = 0;
            // 
            // vIEWPOSTSDataGridView
            // 
            this.vIEWPOSTSDataGridView.AutoGenerateColumns = false;
            this.vIEWPOSTSDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vIEWPOSTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vIEWPOSTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vIEWPOSTSDataGridView.DataSource = this.vIEWPOSTSBindingSource;
            this.vIEWPOSTSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.vIEWPOSTSDataGridView.Location = new System.Drawing.Point(12, 160);
            this.vIEWPOSTSDataGridView.Name = "vIEWPOSTSDataGridView";
            this.vIEWPOSTSDataGridView.RowTemplate.Height = 24;
            this.vIEWPOSTSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vIEWPOSTSDataGridView.Size = new System.Drawing.Size(1061, 220);
            this.vIEWPOSTSDataGridView.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "POSTID";
            this.dataGridViewTextBoxColumn1.HeaderText = "POSTID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PARENTID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PARENTID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "POSTDATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "POSTDATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "POSTTEXT";
            this.dataGridViewTextBoxColumn4.HeaderText = "POSTTEXT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FIRSTNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "FIRSTNAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "POSTTYPEDESC";
            this.dataGridViewTextBoxColumn7.HeaderText = "POSTTYPEDESC";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CATEGORYNAME";
            this.dataGridViewTextBoxColumn8.HeaderText = "CATEGORYNAME";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "URL";
            this.dataGridViewTextBoxColumn9.HeaderText = "URL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "POSTRANK";
            this.dataGridViewTextBoxColumn10.HeaderText = "POSTRANK";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // frmNewsfeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 524);
            this.Controls.Add(this.vIEWPOSTSDataGridView);
            this.Controls.Add(this.lblSurnameLog);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.vIEWPOSTSBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmNewsfeed";
            this.Text = "PostITT - Newsfeed";
            this.Load += new System.EventHandler(this.frmNewsfeed_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSBindingNavigator)).EndInit();
            this.vIEWPOSTSBindingNavigator.ResumeLayout(false);
            this.vIEWPOSTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPostsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPostsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWPOSTSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newsfeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterToolStripMenuItem;
        private viewPosts viewPosts;
        private System.Windows.Forms.BindingSource vIEWPOSTSBindingSource;
        private viewPostsTableAdapters.VIEWPOSTSTableAdapter vIEWPOSTSTableAdapter;
        private viewPostsTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.ToolStripMenuItem updateStatusToolStripMenuItem;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label txtFirstname;
        private System.Windows.Forms.Label lblSurnameLog;
        private System.Windows.Forms.BindingSource viewPostsDSBindingSource;
        private ViewPostsDS viewPostsDS;
        private System.Windows.Forms.DataGridView vIEWPOSTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}