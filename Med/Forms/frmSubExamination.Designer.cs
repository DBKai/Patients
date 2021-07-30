namespace Med
{
    partial class frmSubExamination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubExamination));
            this.dtpDT_Exam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedinst = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dtpDT_Exam
            // 
            this.dtpDT_Exam.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Exam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDT_Exam.Location = new System.Drawing.Point(88, 12);
            this.dtpDT_Exam.Name = "dtpDT_Exam";
            this.dtpDT_Exam.Size = new System.Drawing.Size(92, 23);
            this.dtpDT_Exam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Учреждение";
            // 
            // cmbMedinst
            // 
            this.cmbMedinst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedinst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbMedinst.FormattingEnabled = true;
            this.cmbMedinst.Location = new System.Drawing.Point(88, 41);
            this.cmbMedinst.Name = "cmbMedinst";
            this.cmbMedinst.Size = new System.Drawing.Size(263, 24);
            this.cmbMedinst.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Med.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(311, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 40);
            this.btnCancel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCancel, "Отменить");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Image = global::Med.Properties.Resources.apply;
            this.btnApply.Location = new System.Drawing.Point(265, 88);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(40, 40);
            this.btnApply.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnApply, "Подтвердить");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmSubExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 140);
            this.Controls.Add(this.cmbMedinst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDT_Exam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubExamination";
            this.Load += new System.EventHandler(this.frmSubExamination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dtpDT_Exam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedinst;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}