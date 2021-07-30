namespace Med
{
    partial class frmSubAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubAppointment));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txbDiagnosis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDT_Appoint = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTreatment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Med.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 40);
            this.btnCancel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCancel, "Отменить");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Image = global::Med.Properties.Resources.apply;
            this.btnApply.Location = new System.Drawing.Point(370, 213);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(40, 40);
            this.btnApply.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnApply, "Подтвердить");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txbDiagnosis
            // 
            this.txbDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbDiagnosis.Location = new System.Drawing.Point(67, 41);
            this.txbDiagnosis.MaxLength = 255;
            this.txbDiagnosis.Multiline = true;
            this.txbDiagnosis.Name = "txbDiagnosis";
            this.txbDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDiagnosis.Size = new System.Drawing.Size(389, 79);
            this.txbDiagnosis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата";
            // 
            // dtpDT_Appoint
            // 
            this.dtpDT_Appoint.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Appoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Appoint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDT_Appoint.Location = new System.Drawing.Point(67, 12);
            this.dtpDT_Appoint.Name = "dtpDT_Appoint";
            this.dtpDT_Appoint.Size = new System.Drawing.Size(92, 23);
            this.dtpDT_Appoint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Диагноз";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Лечение";
            // 
            // txbTreatment
            // 
            this.txbTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTreatment.Location = new System.Drawing.Point(67, 126);
            this.txbTreatment.MaxLength = 255;
            this.txbTreatment.Multiline = true;
            this.txbTreatment.Name = "txbTreatment";
            this.txbTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTreatment.Size = new System.Drawing.Size(389, 79);
            this.txbTreatment.TabIndex = 6;
            // 
            // frmSubAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTreatment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDT_Appoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDiagnosis);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubAppointment";
            this.Load += new System.EventHandler(this.frmSubAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbDiagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDT_Appoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTreatment;
    }
}