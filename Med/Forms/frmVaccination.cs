using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmVaccination : Form
    {
        private readonly BindingSource _bindingSource;
        public Vaccination Vaccination;
        public Patient PatientVacc;

        public frmVaccination()
        {
            InitializeComponent();
            Vaccination = new Vaccination();
            PatientVacc = new Patient();
            _bindingSource = new BindingSource();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeVaccinationDGV()
        {
            // Заполняем DataTable значениями из таблицы examination
            DataTable dataTable = Vaccination.Fill(PatientVacc.id_patient).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            _bindingSource.Sort = "vaccine_date DESC";
            // Привязка заполненого DataSource к DGV
            dgvVaccination.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvVaccination.Columns[0].Width = 50; //id_vaccin
            dgvVaccination.Columns[1].Width = 90; //vaccine_date
            dgvVaccination.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //vac_name
            dgvVaccination.Columns[3].Width = 90; //dose
            dgvVaccination.Columns[4].Width = 90; //series
            // Установка названия колонок
            dgvVaccination.Columns[0].HeaderText = @"ИД"; //id_vaccin
            dgvVaccination.Columns[1].HeaderText = @"Дата"; //vaccine_date
            dgvVaccination.Columns[2].HeaderText = @"Название прививки"; //vac_name
            dgvVaccination.Columns[3].HeaderText = @"Доза"; //dose
            dgvVaccination.Columns[4].HeaderText = @"Серия"; //series
            // Скрытие столбца с medin_id
            dgvVaccination.Columns[5].Visible = false;

            lblFio.Text = PatientVacc.fio;
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubVaccination = new frmSubVaccination { Owner = this, Text = "Редактирование прививки" };
                // Открываем форму в модальном режиме
                frmSubVaccination.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Получение данных
        private bool ReceivingData()
        {
            try
            {
                Vaccination = new Vaccination();
                // Если в DGV есть выделенные ячейки
                if (dgvVaccination.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvVaccination.CurrentRow != null)
                    {
                        Vaccination.pat_id = PatientVacc.id_patient;
                        Vaccination.id_vaccin = dgvVaccination.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvVaccination.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Vaccination.vaccine_date = Convert.ToDateTime(dgvVaccination.CurrentRow.Cells[1].Value);
                        Vaccination.vac_name = dgvVaccination.CurrentRow.Cells[2].Value.ToString();
                        Vaccination.dose = Convert.ToDouble(dgvVaccination.CurrentRow.Cells[3].Value.ToString());
                        Vaccination.series = dgvVaccination.CurrentRow.Cells[4].Value.ToString();
                        Vaccination.vac_name_id = Convert.ToInt32(dgvVaccination.CurrentRow.Cells[5].Value.ToString());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"При считывании данных произошла ошибка:\n" + ex.Message);
            }
            return false;
        }

        private void frmVaccination_Load(object sender, EventArgs e)
        {
            var frmAppointment = Owner as frmAppointment;
            if (frmAppointment == null) return;
            PatientVacc = frmAppointment.PatientApp;
            InitializeVaccinationDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vaccination.pat_id = PatientVacc.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmSubVaccination = new frmSubVaccination { Owner = this, Text = "Добавление прививки" };
            // Открываем форму в модальном режиме
            frmSubVaccination.ShowDialog();
            InitializeVaccinationDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeVaccinationDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить прививку за дату {0} по пациенту {1}?",
                                  Vaccination.vaccine_date.ToShortDateString(), PatientVacc.fio), @"Удаление прививки",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Vaccination.Delete(Vaccination.id_vaccin);
            }
            InitializeVaccinationDGV();
        }

        private void dgvVaccination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeVaccinationDGV();
            }
        }

        private void dgvVaccination_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeVaccinationDGV();
        }
    }
}
