namespace Med
{
    partial class frmSubVaccination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubVaccination));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDT_Vacc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVac_name = new System.Windows.Forms.ComboBox();
            this.mtbDose = new System.Windows.Forms.MaskedTextBox();
            this.txbSeries = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Med.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 141);
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
            this.btnApply.Location = new System.Drawing.Point(211, 141);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(40, 40);
            this.btnApply.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnApply, "Подтвердить");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            // dtpDT_Vacc
            // 
            this.dtpDT_Vacc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Vacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDT_Vacc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDT_Vacc.Location = new System.Drawing.Point(75, 12);
            this.dtpDT_Vacc.Name = "dtpDT_Vacc";
            this.dtpDT_Vacc.Size = new System.Drawing.Size(92, 23);
            this.dtpDT_Vacc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прививка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Доза";
            // 
            // cmbVac_name
            // 
            this.cmbVac_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVac_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbVac_name.FormattingEnabled = true;
            this.cmbVac_name.Location = new System.Drawing.Point(75, 41);
            this.cmbVac_name.Name = "cmbVac_name";
            this.cmbVac_name.Size = new System.Drawing.Size(212, 24);
            this.cmbVac_name.TabIndex = 8;
            // 
            // mtbDose
            // 
            this.mtbDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbDose.Location = new System.Drawing.Point(75, 71);
            this.mtbDose.Mask = "0.0";
            this.mtbDose.Name = "mtbDose";
            this.mtbDose.Size = new System.Drawing.Size(44, 23);
            this.mtbDose.TabIndex = 9;
            // 
            // txbSeries
            // 
            this.txbSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSeries.Location = new System.Drawing.Point(75, 100);
            this.txbSeries.MaxLength = 20;
            this.txbSeries.Name = "txbSeries";
            this.txbSeries.Size = new System.Drawing.Size(100, 23);
            this.txbSeries.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Серия";
            // 
            // frmSubVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSeries);
            this.Controls.Add(this.mtbDose);
            this.Controls.Add(this.cmbVac_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDT_Vacc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubVaccination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubVaccination";
            this.Load += new System.EventHandler(this.frmSubAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDT_Vacc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVac_name;
        private System.Windows.Forms.MaskedTextBox mtbDose;
        private System.Windows.Forms.TextBox txbSeries;
        private System.Windows.Forms.Label label4;
    }
}