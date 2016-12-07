namespace PostITTDB
{
    partial class frmViewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUsers));
            this.postITTDS = new PostITTDB.PostITTDS();
            this.vIEWUSERPROFILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWUSERPROFILETableAdapter = new PostITTDB.PostITTDSTableAdapters.VIEWUSERPROFILETableAdapter();
            this.tableAdapterManager = new PostITTDB.PostITTDSTableAdapters.TableAdapterManager();
            this.vIEWUSERPROFILEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vIEWUSERPROFILEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWUSERPOSTSTYPECATTAGRANKTableAdapter = new PostITTDB.PostITTDSTableAdapters.VIEWUSERPOSTSTYPECATTAGRANKTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newsfeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWUSERTableAdapter = new PostITTDB.PostITTDSTableAdapters.VIEWUSERTableAdapter();
            this.vIEWUSERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSurnameLog = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingNavigator)).BeginInit();
            this.vIEWUSERPROFILEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // postITTDS
            // 
            this.postITTDS.DataSetName = "PostITTDS";
            this.postITTDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWUSERPROFILEBindingSource
            // 
            this.vIEWUSERPROFILEBindingSource.DataMember = "VIEWUSERPROFILE";
            this.vIEWUSERPROFILEBindingSource.DataSource = this.postITTDS;
            // 
            // vIEWUSERPROFILETableAdapter
            // 
            this.vIEWUSERPROFILETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORYTableAdapter = null;
            this.tableAdapterManager.CLUBTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ITTUSERTableAdapter = null;
            this.tableAdapterManager.MEDIATableAdapter = null;
            this.tableAdapterManager.MEDIATYPETableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.POSTTYPETableAdapter = null;
            this.tableAdapterManager.RANKTableAdapter = null;
            this.tableAdapterManager.SCHOOLTableAdapter = null;
            this.tableAdapterManager.TAGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PostITTDB.PostITTDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTYPETableAdapter = null;
            // 
            // vIEWUSERPROFILEBindingNavigator
            // 
            this.vIEWUSERPROFILEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vIEWUSERPROFILEBindingNavigator.BindingSource = this.vIEWUSERPROFILEBindingSource;
            this.vIEWUSERPROFILEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vIEWUSERPROFILEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vIEWUSERPROFILEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vIEWUSERPROFILEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vIEWUSERPROFILEBindingNavigatorSaveItem});
            this.vIEWUSERPROFILEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vIEWUSERPROFILEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vIEWUSERPROFILEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vIEWUSERPROFILEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vIEWUSERPROFILEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vIEWUSERPROFILEBindingNavigator.Name = "vIEWUSERPROFILEBindingNavigator";
            this.vIEWUSERPROFILEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vIEWUSERPROFILEBindingNavigator.Size = new System.Drawing.Size(1173, 27);
            this.vIEWUSERPROFILEBindingNavigator.TabIndex = 0;
            this.vIEWUSERPROFILEBindingNavigator.Text = "bindingNavigator1";
            this.vIEWUSERPROFILEBindingNavigator.RefreshItems += new System.EventHandler(this.vIEWUSERPROFILEBindingNavigator_RefreshItems);
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
            // vIEWUSERPROFILEBindingNavigatorSaveItem
            // 
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.Enabled = false;
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWUSERPROFILEBindingNavigatorSaveItem.Image")));
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.Name = "vIEWUSERPROFILEBindingNavigatorSaveItem";
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vIEWUSERPROFILEBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // vIEWUSERPOSTSTYPECATTAGRANKBindingSource
            // 
            this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource.DataMember = "VIEWUSERPOSTSTYPECATTAGRANK";
            this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource.DataSource = this.postITTDS;
            // 
            // vIEWUSERPOSTSTYPECATTAGRANKTableAdapter
            // 
            this.vIEWUSERPOSTSTYPECATTAGRANKTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsfeedToolStripMenuItem,
            this.viewProfileToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.deregisterToolStripMenuItem,
            this.updateStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 28);
            this.menuStrip1.TabIndex = 51;
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
            // vIEWUSERBindingSource
            // 
            this.vIEWUSERBindingSource.DataMember = "VIEWUSER";
            this.vIEWUSERBindingSource.DataSource = this.postITTDS;
            // 
            // vIEWUSERTableAdapter
            // 
            this.vIEWUSERTableAdapter.ClearBeforeFill = true;
            // 
            // vIEWUSERDataGridView
            // 
            this.vIEWUSERDataGridView.AutoGenerateColumns = false;
            this.vIEWUSERDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vIEWUSERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vIEWUSERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vIEWUSERDataGridView.DataSource = this.vIEWUSERBindingSource;
            this.vIEWUSERDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.vIEWUSERDataGridView.Location = new System.Drawing.Point(154, 208);
            this.vIEWUSERDataGridView.Name = "vIEWUSERDataGridView";
            this.vIEWUSERDataGridView.RowTemplate.Height = 24;
            this.vIEWUSERDataGridView.Size = new System.Drawing.Size(703, 273);
            this.vIEWUSERDataGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "USERID";
            this.dataGridViewTextBoxColumn1.HeaderText = "USERID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIRSTNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRSTNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SCORE";
            this.dataGridViewTextBoxColumn4.HeaderText = "SCORE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // lblSurnameLog
            // 
            this.lblSurnameLog.AutoSize = true;
            this.lblSurnameLog.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameLog.Location = new System.Drawing.Point(350, 129);
            this.lblSurnameLog.Name = "lblSurnameLog";
            this.lblSurnameLog.Size = new System.Drawing.Size(0, 25);
            this.lblSurnameLog.TabIndex = 62;
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoSize = true;
            this.txtFirstname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(350, 93);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(0, 25);
            this.txtFirstname.TabIndex = 61;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Blue;
            this.lblSurname.Location = new System.Drawing.Point(222, 129);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(119, 25);
            this.lblSurname.TabIndex = 60;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Blue;
            this.lblFirstName.Location = new System.Drawing.Point(204, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(142, 25);
            this.lblFirstName.TabIndex = 59;
            this.lblFirstName.Text = "First Name:";
            // 
            // frmViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 565);
            this.Controls.Add(this.lblSurnameLog);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.vIEWUSERDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vIEWUSERPROFILEBindingNavigator);
            this.Name = "frmViewUsers";
            this.Text = "viewUsers";
            this.Load += new System.EventHandler(this.viewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingNavigator)).EndInit();
            this.vIEWUSERPROFILEBindingNavigator.ResumeLayout(false);
            this.vIEWUSERPROFILEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PostITTDS postITTDS;
        private System.Windows.Forms.BindingSource vIEWUSERPROFILEBindingSource;
        private PostITTDSTableAdapters.VIEWUSERPROFILETableAdapter vIEWUSERPROFILETableAdapter;
        private PostITTDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vIEWUSERPROFILEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vIEWUSERPROFILEBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource vIEWUSERPOSTSTYPECATTAGRANKBindingSource;
        private PostITTDSTableAdapters.VIEWUSERPOSTSTYPECATTAGRANKTableAdapter vIEWUSERPOSTSTYPECATTAGRANKTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newsfeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterToolStripMenuItem;
        private System.Windows.Forms.BindingSource vIEWUSERBindingSource;
        private PostITTDSTableAdapters.VIEWUSERTableAdapter vIEWUSERTableAdapter;
        private System.Windows.Forms.DataGridView vIEWUSERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem updateStatusToolStripMenuItem;
        private System.Windows.Forms.Label lblSurnameLog;
        private System.Windows.Forms.Label txtFirstname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
    }
}