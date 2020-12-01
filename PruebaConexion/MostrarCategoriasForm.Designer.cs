
namespace ProyectoFinal
{
    partial class MostrarCategoriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarCategoriasForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gOTADataSet = new ProyectoFinal.GOTADataSet();
            this.cATEGORIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIASTableAdapter = new ProyectoFinal.GOTADataSetTableAdapters.CATEGORIASTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager();
            this.cATEGORIASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cATEGORIASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORIASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASBindingNavigator)).BeginInit();
            this.cATEGORIASBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(292, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista de Categorias Registradas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Acueductos y Alcantarillados la Gota";
            // 
            // gOTADataSet
            // 
            this.gOTADataSet.DataSetName = "GOTADataSet";
            this.gOTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORIASBindingSource
            // 
            this.cATEGORIASBindingSource.DataMember = "CATEGORIAS";
            this.cATEGORIASBindingSource.DataSource = this.gOTADataSet;
            // 
            // cATEGORIASTableAdapter
            // 
            this.cATEGORIASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIASTableAdapter = this.cATEGORIASTableAdapter;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.HIDROMETROSTableAdapter = null;
            this.tableAdapterManager.HISTORIALCONSUMOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.GOTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cATEGORIASBindingNavigator
            // 
            this.cATEGORIASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATEGORIASBindingNavigator.BindingSource = this.cATEGORIASBindingSource;
            this.cATEGORIASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATEGORIASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATEGORIASBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cATEGORIASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cATEGORIASBindingNavigatorSaveItem});
            this.cATEGORIASBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATEGORIASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATEGORIASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATEGORIASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATEGORIASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATEGORIASBindingNavigator.Name = "cATEGORIASBindingNavigator";
            this.cATEGORIASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATEGORIASBindingNavigator.Size = new System.Drawing.Size(1352, 50);
            this.cATEGORIASBindingNavigator.TabIndex = 11;
            this.cATEGORIASBindingNavigator.Text = "bindingNavigator1";
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
            // cATEGORIASBindingNavigatorSaveItem
            // 
            this.cATEGORIASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATEGORIASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cATEGORIASBindingNavigatorSaveItem.Image")));
            this.cATEGORIASBindingNavigatorSaveItem.Name = "cATEGORIASBindingNavigatorSaveItem";
            this.cATEGORIASBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.cATEGORIASBindingNavigatorSaveItem.Text = "Save Data";
            this.cATEGORIASBindingNavigatorSaveItem.Click += new System.EventHandler(this.cATEGORIASBindingNavigatorSaveItem_Click);
            // 
            // cATEGORIASDataGridView
            // 
            this.cATEGORIASDataGridView.AutoGenerateColumns = false;
            this.cATEGORIASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cATEGORIASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cATEGORIASDataGridView.DataSource = this.cATEGORIASBindingSource;
            this.cATEGORIASDataGridView.Location = new System.Drawing.Point(107, 266);
            this.cATEGORIASDataGridView.Name = "cATEGORIASDataGridView";
            this.cATEGORIASDataGridView.RowHeadersWidth = 82;
            this.cATEGORIASDataGridView.RowTemplate.Height = 33;
            this.cATEGORIASDataGridView.Size = new System.Drawing.Size(803, 220);
            this.cATEGORIASDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCATEGORIA";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODCATEGORIA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarCategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cATEGORIASDataGridView);
            this.Controls.Add(this.cATEGORIASBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MostrarCategoriasForm";
            this.Text = "MostrarCategoriasForm";
            this.Load += new System.EventHandler(this.MostrarCategoriasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gOTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASBindingNavigator)).EndInit();
            this.cATEGORIASBindingNavigator.ResumeLayout(false);
            this.cATEGORIASBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIASDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GOTADataSet gOTADataSet;
        private System.Windows.Forms.BindingSource cATEGORIASBindingSource;
        private GOTADataSetTableAdapters.CATEGORIASTableAdapter cATEGORIASTableAdapter;
        private GOTADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cATEGORIASBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cATEGORIASBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cATEGORIASDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}