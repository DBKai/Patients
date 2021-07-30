using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubExamination : Form
    {
        private Examination subExamination;
        private DataSet _dataSet;

        public frmSubExamination()
        {
            InitializeComponent();
            subExamination = new Examination();
        }

        // Заполняем ComboBox значениями из справочника
        private void FillCombobox()
        {
            _dataSet = Handbook.Fill("medinst");
            cmbMedinst.DataSource = _dataSet.Tables[0];
            cmbMedinst.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbMedinst.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы
                var frmExam = Owner as frmExamination;
                if (frmExam == null) return;
                // Присваиваем значения переданного класса Examination классу Examination текущей формы
                subExamination = frmExam.Examination;
                if (!this.Text.Contains("Добавление"))
                {
                    dtpDT_Exam.Value = Convert.ToDateTime(subExamination.exam_date);
                    cmbMedinst.SelectedValue = subExamination.medin_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Отправка данных
        private bool SendData()
        {
            try
            {
                subExamination.exam_date = dtpDT_Exam.Value;
                subExamination.medin_id = Convert.ToInt32(cmbMedinst.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void frmSubExamination_Load(object sender, EventArgs e)
        {
            FillCombobox();
            ReceivingData();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Examination.Add(subExamination);
            else
                Examination.Edit(subExamination);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
