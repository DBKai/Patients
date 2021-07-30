using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubPatient : Form
    {
        private DataSet _dataSet;
        public Patient SubPatient;

        public frmSubPatient()
        {
            InitializeComponent();
            SubPatient = new Patient();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Patient.Add(SubPatient);
            else
                Patient.Edit(SubPatient);
            Close();
            /*MessageBox.Show(string.Format("1:{0}\n2:{1}\n3:{2}\n4:{3}\n5:{4}\n6:{5}\n7:{6}\n8:{7}",
                                          txbFio.Text, dtpDT_Birthday.Value,
                                          cmbSubdivision.SelectedValue, cmbProfession.SelectedValue, dtpDT_Init.Value,
                                          dtpDT_Dismis.Checked ? dtpDT_Dismis.Value : (DateTime?) null, txbPolis.Text,
                                          mtxbSnils.Text));*/
        }

        // Заполняем ComboBox значениями из справочника
        private void FillCombobox()
        {
            _dataSet = Handbook.Fill("subdivision");
            cmbSubdivision.DataSource = _dataSet.Tables[0];
            cmbSubdivision.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbSubdivision.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;

            _dataSet = Handbook.Fill("profession");
            cmbProfession.DataSource = _dataSet.Tables[0];
            cmbProfession.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbProfession.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;

            _dataSet = Handbook.Fill("place");
            cmbPlace.DataSource = _dataSet.Tables[0];
            cmbPlace.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbPlace.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;

            _dataSet = Handbook.Fill("street");
            cmbStreet.DataSource = _dataSet.Tables[0];
            cmbStreet.DisplayMember = _dataSet.Tables[0].Columns[1].ColumnName;
            cmbStreet.ValueMember = _dataSet.Tables[0].Columns[0].ColumnName;
        }

        private void frmSubPatient_Load(object sender, EventArgs e)
        {
            FillCombobox();
            ReceivingData();
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы frmSubPatient
                var frmSubPatient = Owner as frmPatient;
                if (frmSubPatient == null) return;
                // Присваиваем значения переданного класса Patient классу Patient текущей формы
                SubPatient = frmPatient.Patient;
                // Заполняем контролы значениями переданного класса Patient
                txbFio.Text = SubPatient.fio;
                dtpDT_Birthday.Value = SubPatient.birthday;
                cmbSubdivision.SelectedValue = SubPatient.subdiv_id;
                cmbProfession.SelectedValue = SubPatient.prof_id;
                dtpDT_Init.Value = SubPatient.initdate;
                if (SubPatient.dismisdate != null)
                {
                    dtpDT_Dismis.Checked = true;
                    dtpDT_Dismis.Value = Convert.ToDateTime(SubPatient.dismisdate);
                }
                else
                {
                    dtpDT_Dismis.Checked = false;
                }
                txbPolis.Text = SubPatient.polis;
                mtxbSnils.Text = SubPatient.snils;
                cmbPlace.SelectedValue = SubPatient.place_id;
                cmbStreet.SelectedValue = SubPatient.street_id;
                txbHouse.Text = SubPatient.house;
                txbHull.Text = SubPatient.hull;
                txbApartment.Text = SubPatient.apartment;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Отправка данных
        private bool SendData()
        {
            try
            {
                if (txbFio.Text.Trim(' ') == "")
                {
                    MessageBox.Show(@"Не заполнено поле 'ФИО'");
                    txbFio.Focus();
                    return false;
                }
                SubPatient.fio = !string.IsNullOrWhiteSpace(txbFio.Text) ? txbFio.Text : "ФИО";
                SubPatient.birthday = dtpDT_Birthday.Value;
                SubPatient.subdiv_id = Convert.ToInt32(cmbSubdivision.SelectedValue);
                SubPatient.prof_id = Convert.ToInt32(cmbProfession.SelectedValue);
                SubPatient.initdate = dtpDT_Init.Value;
                SubPatient.dismisdate = dtpDT_Dismis.Checked ? dtpDT_Dismis.Value : (DateTime?)null;
                SubPatient.polis = txbPolis.Text.Trim(' ');
                SubPatient.snils = mtxbSnils.Text.Replace('-',' ').Trim(' ') != "" ? mtxbSnils.Text : "";
                SubPatient.place_id = Convert.ToInt32(cmbPlace.SelectedValue);
                SubPatient.street_id = Convert.ToInt32(cmbStreet.SelectedValue);
                SubPatient.house = txbHouse.Text.Trim(' ');
                SubPatient.hull = txbHull.Text.Trim(' ');
                SubPatient.apartment = txbApartment.Text.Trim(' ');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
