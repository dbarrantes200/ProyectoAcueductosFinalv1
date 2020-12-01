
namespace ProyectoFinal
{
    partial class MostrarFuncionariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFuncionariosForm));
            this.gOTADataSet = new ProyectoFinal.GOTADataSet();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new ProyectoFinal.GOTADataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager();
            this.fUNCIONARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fUNCIONARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fUNCIONARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingNavigator)).BeginInit();
            this.fUNCIONARIOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gOTADataSet
            // 
            this.gOTADataSet.DataSetName = "GOTADataSet";
            this.gOTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.gOTADataSet;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIASTableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = this.fUNCIONARIOSTableAdapter;
            this.tableAdapterManager.HIDROMETROSTableAdapter = null;
            this.tableAdapterManager.HISTORIALCONSUMOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fUNCIONARIOSBindingNavigator
            // 
            this.fUNCIONARIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fUNCIONARIOSBindingNavigator.BindingSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fUNCIONARIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fUNCIONARIOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fUNCIONARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fUNCIONARIOSBindingNavigatorSaveItem});
            this.fUNCIONARIOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fUNCIONARIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fUNCIONARIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fUNCIONARIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fUNCIONARIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fUNCIONARIOSBindingNavigator.Name = "fUNCIONARIOSBindingNavigator";
            this.fUNCIONARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fUNCIONARIOSBindingNavigator.Size = new System.Drawing.Size(1451, 50);
            this.fUNCIONARIOSBindingNavigator.TabIndex = 0;
            this.fUNCIONARIOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(81, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // fUNCIONARIOSBindingNavigatorSaveItem
            // 
            this.fUNCIONARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fUNCIONARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fUNCIONARIOSBindingNavigatorSaveItem.Image")));
            this.fUNCIONARIOSBindingNavigatorSaveItem.Name = "fUNCIONARIOSBindingNavigatorSaveItem";
            this.fUNCIONARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.fUNCIONARIOSBindingNavigatorSaveItem.Text = "Save Data";
            this.fUNCIONARIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.fUNCIONARIOSBindingNavigatorSaveItem_Click);
            // 
            // fUNCIONARIOSDataGridView
            // 
            this.fUNCIONARIOSDataGridView.AutoGenerateColumns = false;
            this.fUNCIONARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCIONARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.fUNCIONARIOSDataGridView.DataSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSDataGridView.Location = new System.Drawing.Point(139, 229);
            this.fUNCIONARIOSDataGridView.Name = "fUNCIONARIOSDataGridView";
            this.fUNCIONARIOSDataGridView.RowHeadersWidth = 82;
            this.fUNCIONARIOSDataGridView.RowTemplate.Height = 33;
            this.fUNCIONARIOSDataGridView.Size = new System.Drawing.Size(1140, 220);
            this.fUNCIONARIOSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO1";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDO1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "APELLIDO2";
            this.dataGridViewTextBoxColumn4.HeaderText = "APELLIDO2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(516, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Funcionarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(221, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acueductos y Alcantarillados la Gota";
            // 
            // MostrarFuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1451, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fUNCIONARIOSDataGridView);
            this.Controls.Add(this.fUNCIONARIOSBindingNavigator);
            this.Name = "MostrarFuncionariosForm";
            this.Text = "MostrarFuncionariosForm";
            this.Load += new System.EventHandler(this.MostrarFuncionariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingNavigator)).EndInit();
            this.fUNCIONARIOSBindingNavigator.ResumeLayout(false);
            this.fUNCIONARIOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GOTADataSet gOTADataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private GOTADataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private GOTADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fUNCIONARIOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fUNCIONARIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fUNCIONARIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}