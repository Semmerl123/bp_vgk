namespace BP_VGK.VerwaltungGentechKonstrukte
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSpecies = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationTrivialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationScientificDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Species = new System.Windows.Forms.BindingSource(this.components);
            this._BP_VGK_DatabaseDataSet = new BP_VGK.VerwaltungGentechKonstrukte._BP_VGK_DatabaseDataSet();
            this.speciesTableTableAdapter = new BP_VGK.VerwaltungGentechKonstrukte._BP_VGK_DatabaseDataSetTableAdapters.SpeciesTableTableAdapter();
            this.btEditSpecies = new System.Windows.Forms.Button();
            this.btUpdateReceptors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Species)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BP_VGK_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecies
            // 
            this.dgvSpecies.AllowUserToAddRows = false;
            this.dgvSpecies.AllowUserToDeleteRows = false;
            this.dgvSpecies.AllowUserToResizeRows = false;
            this.dgvSpecies.AutoGenerateColumns = false;
            this.dgvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.designationTrivialDataGridViewTextBoxColumn,
            this.designationScientificDataGridViewTextBoxColumn});
            this.dgvSpecies.DataSource = this.bindingSource_Species;
            this.dgvSpecies.Location = new System.Drawing.Point(104, 53);
            this.dgvSpecies.MultiSelect = false;
            this.dgvSpecies.Name = "dgvSpecies";
            this.dgvSpecies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecies.Size = new System.Drawing.Size(556, 157);
            this.dgvSpecies.TabIndex = 0;
            this.dgvSpecies.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpecies_RowEnter);
            this.dgvSpecies.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // designationTrivialDataGridViewTextBoxColumn
            // 
            this.designationTrivialDataGridViewTextBoxColumn.DataPropertyName = "DesignationTrivial";
            this.designationTrivialDataGridViewTextBoxColumn.HeaderText = "Designation trivial";
            this.designationTrivialDataGridViewTextBoxColumn.Name = "designationTrivialDataGridViewTextBoxColumn";
            this.designationTrivialDataGridViewTextBoxColumn.Width = 240;
            // 
            // designationScientificDataGridViewTextBoxColumn
            // 
            this.designationScientificDataGridViewTextBoxColumn.DataPropertyName = "DesignationScientific";
            this.designationScientificDataGridViewTextBoxColumn.HeaderText = "Designation scientific";
            this.designationScientificDataGridViewTextBoxColumn.Name = "designationScientificDataGridViewTextBoxColumn";
            this.designationScientificDataGridViewTextBoxColumn.Width = 250;
            // 
            // bindingSource_Species
            // 
            this.bindingSource_Species.DataMember = "SpeciesTable";
            this.bindingSource_Species.DataSource = this._BP_VGK_DatabaseDataSet;
            // 
            // _BP_VGK_DatabaseDataSet
            // 
            this._BP_VGK_DatabaseDataSet.DataSetName = "_BP_VGK_DatabaseDataSet";
            this._BP_VGK_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // speciesTableTableAdapter
            // 
            this.speciesTableTableAdapter.ClearBeforeFill = true;
            // 
            // btEditSpecies
            // 
            this.btEditSpecies.Location = new System.Drawing.Point(104, 216);
            this.btEditSpecies.Name = "btEditSpecies";
            this.btEditSpecies.Size = new System.Drawing.Size(129, 79);
            this.btEditSpecies.TabIndex = 1;
            this.btEditSpecies.Text = "Edit Species and their Receptors";
            this.btEditSpecies.UseVisualStyleBackColor = true;
            this.btEditSpecies.Click += new System.EventHandler(this.button1_Click);
            // 
            // btUpdateReceptors
            // 
            this.btUpdateReceptors.Location = new System.Drawing.Point(511, 222);
            this.btUpdateReceptors.Name = "btUpdateReceptors";
            this.btUpdateReceptors.Size = new System.Drawing.Size(149, 73);
            this.btUpdateReceptors.TabIndex = 2;
            this.btUpdateReceptors.Text = "Manage receptor list";
            this.btUpdateReceptors.UseVisualStyleBackColor = true;
            this.btUpdateReceptors.Click += new System.EventHandler(this.btUpdateReceptors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 430);
            this.Controls.Add(this.btUpdateReceptors);
            this.Controls.Add(this.btEditSpecies);
            this.Controls.Add(this.dgvSpecies);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Species)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BP_VGK_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_Species;
        private System.Windows.Forms.DataGridView dgvSpecies;
        private _BP_VGK_DatabaseDataSet _BP_VGK_DatabaseDataSet;
        private _BP_VGK_DatabaseDataSetTableAdapters.SpeciesTableTableAdapter speciesTableTableAdapter;
        private System.Windows.Forms.Button btEditSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationTrivialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationScientificDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btUpdateReceptors;
    }
}

