namespace BP_VGK.VerwaltungGentechKonstrukte
{
    partial class ManageReceptorsForm
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
            this.btDeleteSelectedEntry = new System.Windows.Forms.Button();
            this.lbAddREc = new System.Windows.Forms.Label();
            this.tbNewReceptorName = new System.Windows.Forms.TextBox();
            this.btAddNewReceptor = new System.Windows.Forms.Button();
            this.dgvAvailableReceptors = new System.Windows.Forms.DataGridView();
            this._BP_VGK_DatabaseDataSet2 = new BP_VGK.VerwaltungGentechKonstrukte._BP_VGK_DatabaseDataSet2();
            this.receptorsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptorsTableTableAdapter = new BP_VGK.VerwaltungGentechKonstrukte._BP_VGK_DatabaseDataSet2TableAdapters.ReceptorsTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUpdateSelectedReceptor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableReceptors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BP_VGK_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptorsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btDeleteSelectedEntry
            // 
            this.btDeleteSelectedEntry.Location = new System.Drawing.Point(104, 335);
            this.btDeleteSelectedEntry.Name = "btDeleteSelectedEntry";
            this.btDeleteSelectedEntry.Size = new System.Drawing.Size(144, 23);
            this.btDeleteSelectedEntry.TabIndex = 1;
            this.btDeleteSelectedEntry.Text = "Delete selected entry";
            this.btDeleteSelectedEntry.UseVisualStyleBackColor = true;
            this.btDeleteSelectedEntry.Click += new System.EventHandler(this.btDeleteSelectedEntry_Click);
            // 
            // lbAddREc
            // 
            this.lbAddREc.AutoSize = true;
            this.lbAddREc.Location = new System.Drawing.Point(9, 29);
            this.lbAddREc.Name = "lbAddREc";
            this.lbAddREc.Size = new System.Drawing.Size(91, 13);
            this.lbAddREc.TabIndex = 2;
            this.lbAddREc.Text = "Add new receptor";
            // 
            // tbNewReceptorName
            // 
            this.tbNewReceptorName.Location = new System.Drawing.Point(106, 26);
            this.tbNewReceptorName.Name = "tbNewReceptorName";
            this.tbNewReceptorName.Size = new System.Drawing.Size(249, 20);
            this.tbNewReceptorName.TabIndex = 3;
            // 
            // btAddNewReceptor
            // 
            this.btAddNewReceptor.Location = new System.Drawing.Point(12, 52);
            this.btAddNewReceptor.Name = "btAddNewReceptor";
            this.btAddNewReceptor.Size = new System.Drawing.Size(168, 23);
            this.btAddNewReceptor.TabIndex = 4;
            this.btAddNewReceptor.Text = "Add new receptor!";
            this.btAddNewReceptor.UseVisualStyleBackColor = true;
            this.btAddNewReceptor.Click += new System.EventHandler(this.btAddNewReceptor_Click);
            // 
            // dgvAvailableReceptors
            // 
            this.dgvAvailableReceptors.AllowUserToAddRows = false;
            this.dgvAvailableReceptors.AllowUserToDeleteRows = false;
            this.dgvAvailableReceptors.AllowUserToResizeColumns = false;
            this.dgvAvailableReceptors.AllowUserToResizeRows = false;
            this.dgvAvailableReceptors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailableReceptors.AutoGenerateColumns = false;
            this.dgvAvailableReceptors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableReceptors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.receptorNameDataGridViewTextBoxColumn});
            this.dgvAvailableReceptors.DataSource = this.receptorsTableBindingSource;
            this.dgvAvailableReceptors.Location = new System.Drawing.Point(8, 81);
            this.dgvAvailableReceptors.MultiSelect = false;
            this.dgvAvailableReceptors.Name = "dgvAvailableReceptors";
            this.dgvAvailableReceptors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableReceptors.Size = new System.Drawing.Size(347, 248);
            this.dgvAvailableReceptors.TabIndex = 5;
            // 
            // _BP_VGK_DatabaseDataSet2
            // 
            this._BP_VGK_DatabaseDataSet2.DataSetName = "_BP_VGK_DatabaseDataSet2";
            this._BP_VGK_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptorsTableBindingSource
            // 
            this.receptorsTableBindingSource.DataMember = "ReceptorsTable";
            this.receptorsTableBindingSource.DataSource = this._BP_VGK_DatabaseDataSet2;
            // 
            // receptorsTableTableAdapter
            // 
            this.receptorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptorNameDataGridViewTextBoxColumn
            // 
            this.receptorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptorNameDataGridViewTextBoxColumn.DataPropertyName = "ReceptorName";
            this.receptorNameDataGridViewTextBoxColumn.HeaderText = "ReceptorName";
            this.receptorNameDataGridViewTextBoxColumn.Name = "receptorNameDataGridViewTextBoxColumn";
            // 
            // btUpdateSelectedReceptor
            // 
            this.btUpdateSelectedReceptor.Location = new System.Drawing.Point(187, 52);
            this.btUpdateSelectedReceptor.Name = "btUpdateSelectedReceptor";
            this.btUpdateSelectedReceptor.Size = new System.Drawing.Size(168, 23);
            this.btUpdateSelectedReceptor.TabIndex = 6;
            this.btUpdateSelectedReceptor.Text = "Update selected receptor";
            this.btUpdateSelectedReceptor.UseVisualStyleBackColor = true;
            this.btUpdateSelectedReceptor.Click += new System.EventHandler(this.btUpdateSelectedReceptor_Click);
            // 
            // ManageReceptorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 385);
            this.Controls.Add(this.btUpdateSelectedReceptor);
            this.Controls.Add(this.dgvAvailableReceptors);
            this.Controls.Add(this.btAddNewReceptor);
            this.Controls.Add(this.tbNewReceptorName);
            this.Controls.Add(this.lbAddREc);
            this.Controls.Add(this.btDeleteSelectedEntry);
            this.Name = "ManageReceptorsForm";
            this.Text = "ManageReceptorsForm";
            this.Load += new System.EventHandler(this.ManageReceptorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableReceptors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BP_VGK_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptorsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeleteSelectedEntry;
        private System.Windows.Forms.Label lbAddREc;
        private System.Windows.Forms.TextBox tbNewReceptorName;
        private System.Windows.Forms.Button btAddNewReceptor;
        private System.Windows.Forms.DataGridView dgvAvailableReceptors;
        private _BP_VGK_DatabaseDataSet2 _BP_VGK_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource receptorsTableBindingSource;
        private _BP_VGK_DatabaseDataSet2TableAdapters.ReceptorsTableTableAdapter receptorsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btUpdateSelectedReceptor;
    }
}