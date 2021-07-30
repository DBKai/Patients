using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmAppointment : Form
    {
        private readonly BindingSource _bindingSource;
        public Appointment Appointment;
        public Patient PatientApp;

        public frmAppointment()
        {
            InitializeComponent();
            Appointment = new Appointment();
            PatientApp = new Patient();
            _bindingSource = new BindingSource();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeAppointmentDGV()
        {
            // Заполняем DataTable значениями из таблицы appointment
            DataTable dataTable = Appointment.Fill(PatientApp.id_patient).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            // Привязка заполненого DataSource к DGV
            dgvAppoint.DataSource = _bindingSource;
            _bindingSource.Sort = "appointdate DESC";
            // Установка ширины колонок
            dgvAppoint.Columns[0].Width = 50; //id_appoint
            dgvAppoint.Columns[1].Width = 90; //appointdate
            dgvAppoint.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //diagnosis
            dgvAppoint.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // treatment
            // Установка названия колонок
            dgvAppoint.Columns[0].HeaderText = @"ИД"; //id_appoint
            dgvAppoint.Columns[1].HeaderText = @"Дата"; //appointdate
            dgvAppoint.Columns[2].HeaderText = @"Диагноз"; //diagnosis
            dgvAppoint.Columns[3].HeaderText = @"Лечение"; //treatment

            lblFio.Text = PatientApp.fio;
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubAppointment = new frmSubAppointment { Owner = this, Text = "Редактирование приема" };
                // Открываем форму в модальном режиме
                frmSubAppointment.ShowDialog();
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
                Appointment = new Appointment();
                // Если в DGV есть выделенные ячейки
                if (dgvAppoint.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvAppoint.CurrentRow != null)
                    {
                        Appointment.pat_id = PatientApp.id_patient;
                        Appointment.id_appoint = dgvAppoint.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvAppoint.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Appointment.appointdate = Convert.ToDateTime(dgvAppoint.CurrentRow.Cells[1].Value);
                        Appointment.diagnosis = dgvAppoint.CurrentRow.Cells[2].Value.ToString();
                        Appointment.treatment = dgvAppoint.CurrentRow.Cells[3].Value.ToString();
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

        private void dgvAppoint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeAppointmentDGV();
        }

        private void dgvAppoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeAppointmentDGV();
            }
        }

        private void frmAppointment_Load(object sender, System.EventArgs e)
        {
            var frmPatient = Owner as frmPatient;
            if (frmPatient == null) return;
            PatientApp = frmPatient.Patient;
            //this.Width = Convert.ToInt32(Screen.GetBounds(this).Width*0.97); this.CenterToParent();
            InitializeAppointmentDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Appointment.pat_id = PatientApp.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmSubAppointment = new frmSubAppointment { Owner = this, Text = "Добавление приема" };
            // Открываем форму в модальном режиме
            frmSubAppointment.ShowDialog();
            InitializeAppointmentDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeAppointmentDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить прием за дату {0} по пациенту {1}?",
                                  Appointment.appointdate.ToShortDateString(), PatientApp.fio), @"Удаление приема",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Appointment.Delete(Appointment.id_appoint);
            }
            InitializeAppointmentDGV();
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            Appointment.pat_id = PatientApp.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmVaccination = new frmVaccination { Owner = this };
            // Открываем форму в модальном режиме
            frmVaccination.ShowDialog();
        }
        
        private void btnRoetgen_Click(object sender, EventArgs e)
        {
            Appointment.pat_id = PatientApp.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmRoetgen = new frmRoetgen { Owner = this };
            // Открываем форму в модальном режиме
            frmRoetgen.ShowDialog();
        }
        
        private void btnMassage_Click(object sender, EventArgs e)
        {
            Appointment.pat_id = PatientApp.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmMassage = new frmMassage { Owner = this };
            // Открываем форму в модальном режиме
            frmMassage.ShowDialog();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Appointment.pat_id = PatientApp.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmExamination = new frmExamination { Owner = this };
            // Открываем форму в модальном режиме
            frmExamination.ShowDialog();
        }
    }
}
