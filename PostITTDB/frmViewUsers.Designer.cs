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
            this.vIEWUSERPROFILEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWUSERPOSTSTYPECATTAGRANKTableAdapter = new PostITTDB.PostITTDSTableAdapters.VIEWUSERPOSTSTYPECATTAGRANKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingNavigator)).BeginInit();
            this.vIEWUSERPROFILEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource)).BeginInit();
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
            this.vIEWUSERPROFILEBindingNavigator.Size = new System.Drawing.Size(1155, 27);
            this.vIEWUSERPROFILEBindingNavigator.TabIndex = 0;
            this.vIEWUSERPROFILEBindingNavigator.Text = "bindingNavigator1";
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
            // vIEWUSERPROFILEDataGridView
            // 
            this.vIEWUSERPROFILEDataGridView.AutoGenerateColumns = false;
            this.vIEWUSERPROFILEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vIEWUSERPROFILEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vIEWUSERPROFILEDataGridView.DataSource = this.vIEWUSERPROFILEBindingSource;
            this.vIEWUSERPROFILEDataGridView.Enabled = false;
            this.vIEWUSERPROFILEDataGridView.Location = new System.Drawing.Point(31, 94);
            this.vIEWUSERPROFILEDataGridView.Name = "vIEWUSERPROFILEDataGridView";
            this.vIEWUSERPROFILEDataGridView.RowTemplate.Height = 24;
            this.vIEWUSERPROFILEDataGridView.Size = new System.Drawing.Size(890, 220);
            this.vIEWUSERPROFILEDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SCORE";
            this.dataGridViewTextBoxColumn5.HeaderText = "SCORE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PROFILEPIC";
            this.dataGridViewTextBoxColumn6.HeaderText = "PROFILEPIC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // frmViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 379);
            this.Controls.Add(this.vIEWUSERPROFILEDataGridView);
            this.Controls.Add(this.vIEWUSERPROFILEBindingNavigator);
            this.Name = "frmViewUsers";
            this.Text = "viewUsers";
            this.Load += new System.EventHandler(this.viewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postITTDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEBindingNavigator)).EndInit();
            this.vIEWUSERPROFILEBindingNavigator.ResumeLayout(false);
            this.vIEWUSERPROFILEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPROFILEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWUSERPOSTSTYPECATTAGRANKBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView vIEWUSERPROFILEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource vIEWUSERPOSTSTYPECATTAGRANKBindingSource;
        private PostITTDSTableAdapters.VIEWUSERPOSTSTYPECATTAGRANKTableAdapter vIEWUSERPOSTSTYPECATTAGRANKTableAdapter;
    }
}