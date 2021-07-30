namespace Med
{
    partial class frmHandbook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandbook));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubdivision = new System.Windows.Forms.Button();
            this.btnStreet = new System.Windows.Forms.Button();
            this.btnProfession = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnMedinst = new System.Windows.Forms.Button();
            this.btnVaccination = new System.Windows.Forms.Button();
            this.btnRoetgen = new System.Windows.Forms.Button();
            this.lblHandbookName = new System.Windows.Forms.Label();
            this.dgvHandbook = new Med.CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandbook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Med.Properties.Resources.remove;
            this.btnDelete.Location = new System.Drawing.Point(98, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnDelete, "Удалить");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Image = global::Med.Properties.Resources.pencil;
            this.btnEdit.Location = new System.Drawing.Point(52, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnEdit, "Редактировать");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = global::Med.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(6, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubdivision
            // 
            this.btnSubdivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubdivision.Image = global::Med.Properties.Resources.subdiv;
            this.btnSubdivision.Location = new System.Drawing.Point(514, 12);
            this.btnSubdivision.Name = "btnSubdivision";
            this.btnSubdivision.Size = new System.Drawing.Size(40, 40);
            this.btnSubdivision.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSubdivision, "Подразделения");
            this.btnSubdivision.UseVisualStyleBackColor = true;
            this.btnSubdivision.Click += new System.EventHandler(this.btnSubdivision_Click);
            // 
            // btnStreet
            // 
            this.btnStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStreet.Image = global::Med.Properties.Resources.street;
            this.btnStreet.Location = new System.Drawing.Point(468, 12);
            this.btnStreet.Name = "btnStreet";
            this.btnStreet.Size = new System.Drawing.Size(40, 40);
            this.btnStreet.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnStreet, "Улицы");
            this.btnStreet.UseVisualStyleBackColor = true;
            this.btnStreet.Click += new System.EventHandler(this.btnStreet_Click);
            // 
            // btnProfession
            // 
            this.btnProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfession.Image = global::Med.Properties.Resources.prof;
            this.btnProfession.Location = new System.Drawing.Point(560, 12);
            this.btnProfession.Name = "btnProfession";
            this.btnProfession.Size = new System.Drawing.Size(40, 40);
            this.btnProfession.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnProfession, "Профессии");
            this.btnProfession.UseVisualStyleBackColor = true;
            this.btnProfession.Click += new System.EventHandler(this.btnProfession_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlace.Image = global::Med.Properties.Resources.place;
            this.btnPlace.Location = new System.Drawing.Point(422, 12);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(40, 40);
            this.btnPlace.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnPlace, "Город");
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnMedinst
            // 
            this.btnMedinst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedinst.Image = global::Med.Properties.Resources.hospital;
            this.btnMedinst.Location = new System.Drawing.Point(376, 12);
            this.btnMedinst.Name = "btnMedinst";
            this.btnMedinst.Size = new System.Drawing.Size(40, 40);
            this.btnMedinst.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnMedinst, "Лечебные учреждения");
            this.btnMedinst.UseVisualStyleBackColor = true;
            this.btnMedinst.Click += new System.EventHandler(this.btnMedinst_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaccination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVaccination.Image = global::Med.Properties.Resources.injection;
            this.btnVaccination.Location = new System.Drawing.Point(284, 12);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(40, 40);
            this.btnVaccination.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnVaccination, "Прививки");
            this.btnVaccination.UseVisualStyleBackColor = true;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // btnRoetgen
            // 
            this.btnRoetgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoetgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoetgen.Image = global::Med.Properties.Resources.nuclear;
            this.btnRoetgen.Location = new System.Drawing.Point(330, 12);
            this.btnRoetgen.Name = "btnRoetgen";
            this.btnRoetgen.Size = new System.Drawing.Size(40, 40);
            this.btnRoetgen.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnRoetgen, "Рентген");
            this.btnRoetgen.UseVisualStyleBackColor = true;
            this.btnRoetgen.Click += new System.EventHandler(this.btnRoetgen_Click);
            // 
            // lblHandbookName
            // 
            this.lblHandbookName.AutoSize = true;
            this.lblHandbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHandbookName.Location = new System.Drawing.Point(12, 26);
            this.lblHandbookName.Name = "lblHandbookName";
            this.lblHandbookName.Size = new System.Drawing.Size(126, 17);
            this.lblHandbookName.TabIndex = 24;
            this.lblHandbookName.Text = "Подразделения";
            // 
            // dgvHandbook
            // 
            this.dgvHandbook.AllowUserToAddRows = false;
            this.dgvHandbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHandbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHandbook.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHandbook.Location = new System.Drawing.Point(2, 58);
            this.dgvHandbook.MultiSelect = false;
            this.dgvHandbook.Name = "dgvHandbook";
            this.dgvHandbook.ReadOnly = true;
            this.dgvHandbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHandbook.Size = new System.Drawing.Size(603, 251);
            this.dgvHandbook.TabIndex = 0;
            this.dgvHandbook.TabStop = false;
            this.dgvHandbook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHandbook_CellDoubleClick);
            this.dgvHandbook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvHandbook_KeyPress);
            // 
            // frmHandbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 362);
            this.Controls.Add(this.lblHandbookName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubdivision);
            this.Controls.Add(this.btnStreet);
            this.Controls.Add(this.btnProfession);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnMedinst);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.btnRoetgen);
            this.Controls.Add(this.dgvHandbook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHandbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.frmHandbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHandbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgvHandbook;
        private System.Windows.Forms.Button btnVaccination;
        private System.Windows.Forms.Button btnRoetgen;
        private System.Windows.Forms.Button btnMedinst;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnProfession;
        private System.Windows.Forms.Button btnStreet;
        private System.Windows.Forms.Button btnSubdivision;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHandbookName;
    }
}