using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubRoetgen : Form
    {
        private Roetgen subRoetgen;
        private DataSet _dataSet;

        public frmSubRoetgen()
        {
            InitializeComponent();
            subRoetgen = new Roetgen();
        }

        // Заполняем ComboBox значениями из справочника
        private void FillCombobox()
        {
            _dataSet = Handbook.Fill("roet_name");
            cmbRoetgen.DataSource = _dataSet.Tables[0];
            cmbRoetgen.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbRoetgen.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы
                var frmRoet = Owner as frmRoetgen;
                if (frmRoet == null) return;
                // Присваиваем значения переданного класса Roetgen классу Roetgen текущей формы
                subRoetgen = frmRoet.Roetgen;
                if (!this.Text.Contains("Добавление"))
                {
                    dtpDT_Roet.Value = Convert.ToDateTime(subRoetgen.roet_date);
                    cmbRoetgen.SelectedValue = subRoetgen.roet_name_id;
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
                subRoetgen.roet_date = dtpDT_Roet.Value;
                subRoetgen.roet_name_id = Convert.ToInt32(cmbRoetgen.SelectedValue);
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
                Roetgen.Add(subRoetgen);
            else
                Roetgen.Edit(subRoetgen);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
