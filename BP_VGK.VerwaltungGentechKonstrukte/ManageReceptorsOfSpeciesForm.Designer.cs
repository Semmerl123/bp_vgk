namespace BP_VGK.VerwaltungGentechKonstrukte
{
    partial class ManageReceptorsOfSpeciesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSaveNewReceptors = new System.Windows.Forms.Button();
            this.dgvAvailableReceptors = new System.Windows.Forms.DataGridView();
            this.nameOfReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvaiableOnSpecies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbNoEntryFound = new System.Windows.Forms.Label();
            this.lbTrivial = new System.Windows.Forms.Label();
            this.lbScientificNme = new System.Windows.Forms.Label();
            this.tbTrivialName = new System.Windows.Forms.TextBox();
            this.tbScientificName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableReceptors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbScientificName);
            this.groupBox1.Controls.Add(this.tbTrivialName);
            this.groupBox1.Controls.Add(this.lbScientificNme);
            this.groupBox1.Controls.Add(this.lbTrivial);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ausgewählte Spezies";
            // 
            // btSaveNewReceptors
            // 
            this.btSaveNewReceptors.Location = new System.Drawing.Point(118, 325);
            this.btSaveNewReceptors.Name = "btSaveNewReceptors";
            this.btSaveNewReceptors.Size = new System.Drawing.Size(260, 23);
            this.btSaveNewReceptors.TabIndex = 2;
            this.btSaveNewReceptors.Text = "Save";
            this.btSaveNewReceptors.UseVisualStyleBackColor = true;
            this.btSaveNewReceptors.Click += new System.EventHandler(this.btSaveNewReceptors_Click);
            // 
            // dgvAvailableReceptors
            // 
            this.dgvAvailableReceptors.AllowUserToAddRows = false;
            this.dgvAvailableReceptors.AllowUserToDeleteRows = false;
            this.dgvAvailableReceptors.AllowUserToResizeRows = false;
            this.dgvAvailableReceptors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableReceptors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfReceptor,
            this.isAvaiableOnSpecies});
            this.dgvAvailableReceptors.Location = new System.Drawing.Point(28, 166);
            this.dgvAvailableReceptors.Name = "dgvAvailableReceptors";
            this.dgvAvailableReceptors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableReceptors.Size = new System.Drawing.Size(419, 150);
            this.dgvAvailableReceptors.TabIndex = 3;
            // 
            // nameOfReceptor
            // 
            this.nameOfReceptor.Frozen = true;
            this.nameOfReceptor.HeaderText = "Receptor name";
            this.nameOfReceptor.Name = "nameOfReceptor";
            this.nameOfReceptor.ReadOnly = true;
            this.nameOfReceptor.Width = 200;
            // 
            // isAvaiableOnSpecies
            // 
            this.isAvaiableOnSpecies.HeaderText = "Available?";
            this.isAvaiableOnSpecies.Name = "isAvaiableOnSpecies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(73, 139);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(193, 20);
            this.tbFilter.TabIndex = 5;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lbNoEntryFound
            // 
            this.lbNoEntryFound.AutoSize = true;
            this.lbNoEntryFound.Location = new System.Drawing.Point(301, 142);
            this.lbNoEntryFound.Name = "lbNoEntryFound";
            this.lbNoEntryFound.Size = new System.Drawing.Size(77, 13);
            this.lbNoEntryFound.TabIndex = 6;
            this.lbNoEntryFound.Text = "No entry found";
            // 
            // lbTrivial
            // 
            this.lbTrivial.AutoSize = true;
            this.lbTrivial.Location = new System.Drawing.Point(6, 33);
            this.lbTrivial.Name = "lbTrivial";
            this.lbTrivial.Size = new System.Drawing.Size(64, 13);
            this.lbTrivial.TabIndex = 0;
            this.lbTrivial.Text = "Trivial name";
            // 
            // lbScientificNme
            // 
            this.lbScientificNme.AutoSize = true;
            this.lbScientificNme.Location = new System.Drawing.Point(10, 64);
            this.lbScientificNme.Name = "lbScientificNme";
            this.lbScientificNme.Size = new System.Drawing.Size(79, 13);
            this.lbScientificNme.TabIndex = 1;
            this.lbScientificNme.Text = "Scientific name";
            // 
            // tbTrivialName
            // 
            this.tbTrivialName.Location = new System.Drawing.Point(103, 30);
            this.tbTrivialName.Name = "tbTrivialName";
            this.tbTrivialName.Size = new System.Drawing.Size(295, 20);
            this.tbTrivialName.TabIndex = 2;
            // 
            // tbScientificName
            // 
            this.tbScientificName.Location = new System.Drawing.Point(103, 61);
            this.tbScientificName.Name = "tbScientificName";
            this.tbScientificName.Size = new System.Drawing.Size(295, 20);
            this.tbScientificName.TabIndex = 3;
            // 
            // UpdateReceptorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 423);
            this.Controls.Add(this.lbNoEntryFound);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAvailableReceptors);
            this.Controls.Add(this.btSaveNewReceptors);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateReceptorsForm";
            this.Text = "UpdateReceptorsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableReceptors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSaveNewReceptors;
        private System.Windows.Forms.DataGridView dgvAvailableReceptors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfReceptor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvaiableOnSpecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lbNoEntryFound;
        private System.Windows.Forms.TextBox tbScientificName;
        private System.Windows.Forms.TextBox tbTrivialName;
        private System.Windows.Forms.Label lbScientificNme;
        private System.Windows.Forms.Label lbTrivial;
    }
}