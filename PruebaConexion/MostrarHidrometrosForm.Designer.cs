
namespace ProyectoFinal
{
    partial class MostrarHidrometrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarHidrometrosForm));
            this.hidrometrosTableAdapter1 = new ProyectoFinal.GOTADataSetTableAdapters.HIDROMETROSTableAdapter();
            this.gOTADataSet = new ProyectoFinal.GOTADataSet();
            this.hIDROMETROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager();
            this.hIDROMETROSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hIDROMETROSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hIDROMETROSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSBindingNavigator)).BeginInit();
            this.hIDROMETROSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hidrometrosTableAdapter1
            // 
            this.hidrometrosTableAdapter1.ClearBeforeFill = true;
            // 
            // gOTADataSet
            // 
            this.gOTADataSet.DataSetName = "GOTADataSet";
            this.gOTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hIDROMETROSBindingSource
            // 
            this.hIDROMETROSBindingSource.DataMember = "HIDROMETROS";
            this.hIDROMETROSBindingSource.DataSource = this.gOTADataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIASTableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.HIDROMETROSTableAdapter = this.hidrometrosTableAdapter1;
            this.tableAdapterManager.HISTORIALCONSUMOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hIDROMETROSBindingNavigator
            // 
            this.hIDROMETROSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hIDROMETROSBindingNavigator.BindingSource = this.hIDROMETROSBindingSource;
            this.hIDROMETROSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hIDROMETROSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hIDROMETROSBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.hIDROMETROSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hIDROMETROSBindingNavigatorSaveItem,
            this.toolStripDropDownButton1});
            this.hIDROMETROSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hIDROMETROSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hIDROMETROSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hIDROMETROSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hIDROMETROSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hIDROMETROSBindingNavigator.Name = "hIDROMETROSBindingNavigator";
            this.hIDROMETROSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hIDROMETROSBindingNavigator.Size = new System.Drawing.Size(1266, 45);
            this.hIDROMETROSBindingNavigator.TabIndex = 0;
            this.hIDROMETROSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(81, 39);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 45);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 39);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // hIDROMETROSBindingNavigatorSaveItem
            // 
            this.hIDROMETROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hIDROMETROSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hIDROMETROSBindingNavigatorSaveItem.Image")));
            this.hIDROMETROSBindingNavigatorSaveItem.Name = "hIDROMETROSBindingNavigatorSaveItem";
            this.hIDROMETROSBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 39);
            this.hIDROMETROSBindingNavigatorSaveItem.Text = "Save Data";
            this.hIDROMETROSBindingNavigatorSaveItem.Click += new System.EventHandler(this.hIDROMETROSBindingNavigatorSaveItem_Click);
            // 
            // hIDROMETROSDataGridView
            // 
            this.hIDROMETROSDataGridView.AutoGenerateColumns = false;
            this.hIDROMETROSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hIDROMETROSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hIDROMETROSDataGridView.DataSource = this.hIDROMETROSBindingSource;
            this.hIDROMETROSDataGridView.Location = new System.Drawing.Point(60, 210);
            this.hIDROMETROSDataGridView.Name = "hIDROMETROSDataGridView";
            this.hIDROMETROSDataGridView.RowHeadersWidth = 82;
            this.hIDROMETROSDataGridView.RowTemplate.Height = 33;
            this.hIDROMETROSDataGridView.Size = new System.Drawing.Size(1120, 220);
            this.hIDROMETROSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NIS";
            this.dataGridViewTextBoxColumn1.HeaderText = "NIS";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MARCA";
            this.dataGridViewTextBoxColumn2.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NUMSERIE";
            this.dataGridViewTextBoxColumn3.HeaderText = "NUMSERIE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CODCATEGORIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "CODCATEGORIA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(369, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Hidrometros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(128, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acueductos y Alcantarillados la Gota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 39);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // MostrarHidrometrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hIDROMETROSDataGridView);
            this.Controls.Add(this.hIDROMETROSBindingNavigator);
            this.Name = "MostrarHidrometrosForm";
            this.Text = "MostrarHidrometrosForm";
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSBindingNavigator)).EndInit();
            this.hIDROMETROSBindingNavigator.ResumeLayout(false);
            this.hIDROMETROSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hIDROMETROSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GOTADataSetTableAdapters.HIDROMETROSTableAdapter hidrometrosTableAdapter1;
        private GOTADataSet gOTADataSet;
        private System.Windows.Forms.BindingSource hIDROMETROSBindingSource;
        private GOTADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hIDROMETROSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hIDROMETROSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hIDROMETROSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}