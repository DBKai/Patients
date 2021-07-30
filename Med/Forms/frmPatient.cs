using System;
using System.Data;
using System.Windows.Forms;
using FastReport;

namespace Med
{
    public partial class frmPatient : Form
    {
        private readonly BindingSource _bindingSource;
        public static Patient Patient;

        public frmPatient()
        {
            _bindingSource = new BindingSource();
            InitializeComponent();
        }
        
        // Инициализация DataGridView (DGV)
        private void InitializePatientDGV()
        {
            const bool showDismissed = false;
            // Заполняем DataTable значениями из таблицы patient
            DataTable dataTable = Patient.Fill(showDismissed).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            _bindingSource.Sort = "fio";
            // Привязка заполненого DataSource к DGV
            dgvPatient.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvPatient.Columns[0].Width = 50; //id_patient
            dgvPatient.Columns[1].Width = 300; //fio
            dgvPatient.Columns[2].Width = 90; //birthday
            dgvPatient.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // subdiv
            dgvPatient.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // prof
            dgvPatient.Columns[5].Width = 90; // initdate
            dgvPatient.Columns[6].Width = 90; // dismisdate
            dgvPatient.Columns[7].Width = 100; // polis
            dgvPatient.Columns[8].Width = 100; // snils
            // Установка названия колонок
            dgvPatient.Columns[0].HeaderText = @"ИД"; //id_patient
            dgvPatient.Columns[1].HeaderText = @"ФИО"; //fio
            dgvPatient.Columns[2].HeaderText = @"ДеньРожд"; //birthday
            dgvPatient.Columns[3].HeaderText = @"Подразделение"; //subdiv_id
            dgvPatient.Columns[4].HeaderText = @"Профессия"; // prof_id
            dgvPatient.Columns[5].HeaderText = @"ДатаПринят"; //initdate
            dgvPatient.Columns[7].HeaderText = @"Полис"; //polis
            dgvPatient.Columns[8].HeaderText = @"СНИЛС"; //snils
            // Скрытие столбца с subdiv_id, prof_id
            dgvPatient.Columns[6].Visible = false; //dismisdate
            dgvPatient.Columns[9].Visible = false;
            dgvPatient.Columns[10].Visible = false;
            dgvPatient.Columns[11].Visible = false; //place_id
            dgvPatient.Columns[12].Visible = false; //street_id
            dgvPatient.Columns[13].Visible = false; //house
            dgvPatient.Columns[14].Visible = false; //hull
            dgvPatient.Columns[15].Visible = false; //apartment
            this.Text = RecordCount();
        }

        private string RecordCount()
        {
            return string.Format("Пациенты - Записей в картотеке: {0}", _bindingSource.Count);
        }
        
        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmAppointment = new frmAppointment {Owner = this};
                // Открываем форму в модальном режиме
                frmAppointment.ShowDialog();
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
                Patient = new Patient();
                // Если в DGV есть выделенные ячейки
                if (dgvPatient.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvPatient.CurrentRow != null)
                    {
                        Patient.id_patient = dgvPatient.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvPatient.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Patient.fio = dgvPatient.CurrentRow.Cells[1].Value.ToString();
                        Patient.birthday = Convert.ToDateTime(dgvPatient.CurrentRow.Cells[2].Value);
                        Patient.subdiv_name = dgvPatient.CurrentRow.Cells[3].Value.ToString();
                        Patient.prof_name = dgvPatient.CurrentRow.Cells[4].Value.ToString();
                        Patient.initdate = Convert.ToDateTime(dgvPatient.CurrentRow.Cells[5].Value);
                        Patient.dismisdate = dgvPatient.CurrentRow.Cells[6].Value.ToString() != ""
                                               ? Convert.ToDateTime(dgvPatient.CurrentRow.Cells[6].Value)
                                               : (DateTime?) null;
                        Patient.polis = dgvPatient.CurrentRow.Cells[7].Value.ToString();
                        Patient.snils = dgvPatient.CurrentRow.Cells[8].Value.ToString();
                        Patient.subdiv_id = dgvPatient.CurrentRow.Cells[9].Value.ToString() != ""
                                                ? Convert.ToInt32(dgvPatient.CurrentRow.Cells[9].Value.ToString())
                                                : 0;
                        Patient.prof_id = dgvPatient.CurrentRow.Cells[10].Value.ToString() != ""
                                              ? Convert.ToInt32(dgvPatient.CurrentRow.Cells[10].Value.ToString())
                                              : 0;
                        Patient.place_id = dgvPatient.CurrentRow.Cells[11].Value.ToString() != ""
                                              ? Convert.ToInt32(dgvPatient.CurrentRow.Cells[11].Value.ToString())
                                              : 0;
                        Patient.street_id = dgvPatient.CurrentRow.Cells[12].Value.ToString() != ""
                                              ? Convert.ToInt32(dgvPatient.CurrentRow.Cells[12].Value.ToString())
                                              : 0;
                        Patient.house = dgvPatient.CurrentRow.Cells[13].Value.ToString();
                        Patient.hull = dgvPatient.CurrentRow.Cells[14].Value.ToString();
                        Patient.apartment = dgvPatient.CurrentRow.Cells[15].Value.ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"При считывании данных произошла ошибка: " + ex.Message);
            }
            return false;
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            InitializePatientDGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bindingSource.Filter = Filter.txbFilter_TextChanged(panel1);
            this.Text = RecordCount();
        }

        private void dgvPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (panel1.Visible) txbFilterFio.Clear();
            panel1.Visible = !panel1.Visible;
        }

        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmSubPatient = new frmSubPatient { Text = @"Добавление пациента" };
            frmSubPatient.ShowDialog();
            InitializePatientDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            var frmSubPatient = new frmSubPatient { Owner = this, Text = @"Редактирование пациента" };
            frmSubPatient.ShowDialog();
            InitializePatientDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить пациента {0} и все связанные с ним данные?", Patient.fio), @"Удаление пациента",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Patient.Delete(Patient.id_patient);
            }
            InitializePatientDGV();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void btnHandbook_Click(object sender, EventArgs e)
        {
            var frmHandbook = new frmHandbook();
            frmHandbook.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            // Загружаем отчет в объект FastReport
            report.Load(Application.StartupPath + "\\Report.frx");
            // Отправляем строку подключения к БД в отчет
            report.Dictionary.Connections[0].ConnectionString = Properties.Settings.Default.ReportConnectionString;
            report.Show();
        }
    }
}
