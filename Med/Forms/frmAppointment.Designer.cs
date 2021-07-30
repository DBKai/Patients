namespace Med
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.btnExamination = new System.Windows.Forms.Button();
            this.dgvAppoint = new Med.CustomDataGridView();
            this.lblFio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVaccination = new System.Windows.Forms.Button();
            this.btnRoetgen = new System.Windows.Forms.Button();
            this.btnMassage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExamination
            // 
            this.btnExamination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExamination.Image = global::Med.Properties.Resources.doctor;
            this.btnExamination.Location = new System.Drawing.Point(746, 346);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(40, 40);
            this.btnExamination.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnExamination, "Профосмотр");
            this.btnExamination.UseVisualStyleBackColor = true;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // dgvAppoint
            // 
            this.dgvAppoint.AllowUserToAddRows = false;
            this.dgvAppoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppoint.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppoint.Location = new System.Drawing.Point(2, 40);
            this.dgvAppoint.MultiSelect = false;
            this.dgvAppoint.Name = "dgvAppoint";
            this.dgvAppoint.ReadOnly = true;
            this.dgvAppoint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppoint.Size = new System.Drawing.Size(788, 300);
            this.dgvAppoint.TabIndex = 0;
            this.dgvAppoint.TabStop = false;
            this.dgvAppoint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppoint_CellDoubleClick);
            this.dgvAppoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvAppoint_KeyPress);
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFio.Location = new System.Drawing.Point(83, 9);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(181, 17);
            this.lblFio.TabIndex = 7;
            this.lblFio.Text = "Иванов Иван Иванович";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пациент";
            // 
            // btnVaccination
            // 
            this.btnVaccination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaccination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVaccination.Image = global::Med.Properties.Resources.injection;
            this.btnVaccination.Location = new System.Drawing.Point(608, 346);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(40, 40);
            this.btnVaccination.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnVaccination, "Прививки");
            this.btnVaccination.UseVisualStyleBackColor = true;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // btnRoetgen
            // 
            this.btnRoetgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoetgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoetgen.Image = global::Med.Properties.Resources.nuclear;
            this.btnRoetgen.Location = new System.Drawing.Point(654, 346);
            this.btnRoetgen.Name = "btnRoetgen";
            this.btnRoetgen.Size = new System.Drawing.Size(40, 40);
            this.btnRoetgen.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnRoetgen, "Рентген");
            this.btnRoetgen.UseVisualStyleBackColor = true;
            this.btnRoetgen.Click += new System.EventHandler(this.btnRoetgen_Click);
            // 
            // btnMassage
            // 
            this.btnMassage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMassage.Image = global::Med.Properties.Resources.doctor_2;
            this.btnMassage.Location = new System.Drawing.Point(700, 346);
            this.btnMassage.Name = "btnMassage";
            this.btnMassage.Size = new System.Drawing.Size(40, 40);
            this.btnMassage.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnMassage, "Массаж");
            this.btnMassage.UseVisualStyleBackColor = true;
            this.btnMassage.Click += new System.EventHandler(this.btnMassage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Med.Properties.Resources.remove;
            this.btnDelete.Location = new System.Drawing.Point(98, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnDelete, "Удалить");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Image = global::Med.Properties.Resources.pencil;
            this.btnEdit.Location = new System.Drawing.Point(52, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEdit, "Редактировать");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = global::Med.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(6, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 391);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.btnRoetgen);
            this.Controls.Add(this.btnMassage);
            this.Controls.Add(this.lblFio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppoint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExamination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прием";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private CustomDataGridView dgvAppoint;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMassage;
        private System.Windows.Forms.Button btnRoetgen;
        private System.Windows.Forms.Button btnVaccination;
    }
}