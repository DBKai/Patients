using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubVaccination : Form
    {
        public Vaccination SubVaccination;
        private DataSet _dataSet;

        public frmSubVaccination()
        {
            InitializeComponent();
            SubVaccination = new Vaccination();
            _dataSet = new DataSet();
        }

        // Заполняем ComboBox значениями из справочника
        private void FillCombobox()
        {
            _dataSet = Handbook.Fill("vac_name");
            cmbVac_name.DataSource = _dataSet.Tables[0];
            cmbVac_name.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbVac_name.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Vaccination.Add(SubVaccination);
            else
                Vaccination.Edit(SubVaccination);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы frmSubCard
                var frmVac = Owner as frmVaccination;
                if (frmVac == null) return;
                // Присваиваем значения переданного класса Card классу Card текущей формы
                SubVaccination = frmVac.Vaccination;
                if (!this.Text.Contains("Добавление"))
                {
                    dtpDT_Vacc.Value = SubVaccination.vaccine_date;
                    cmbVac_name.SelectedValue = SubVaccination.vac_name_id;
                    mtbDose.Text = SubVaccination.dose.ToString();
                    txbSeries.Text = SubVaccination.series;
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
                SubVaccination.vaccine_date = dtpDT_Vacc.Value;
                SubVaccination.vac_id = Convert.ToInt32(cmbVac_name.SelectedValue);
                SubVaccination.dose = mtbDose.Text.Replace(',',' ').Trim(' ') != "" ? Convert.ToDouble(mtbDose.Text) : 0;
                SubVaccination.series = txbSeries.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void frmSubAppointment_Load(object sender, EventArgs e)
        {
            FillCombobox();
            ReceivingData();
        }
    }
}
