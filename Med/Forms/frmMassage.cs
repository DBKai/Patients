using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmMassage : Form
    {
        private readonly BindingSource _bindingSource;
        public Patient PatientMass;
        public Massage Massage;

        public frmMassage()
        {
            InitializeComponent();
            Massage = new Massage();
            PatientMass = new Patient();
            _bindingSource = new BindingSource();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeMassageDGV()
        {
            // Заполняем DataTable значениями из таблицы examination
            DataTable dataTable = Massage.Fill(PatientMass.id_patient).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            _bindingSource.Sort = "mass_date DESC";
            // Привязка заполненого DataSource к DGV
            dgvMassage.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvMassage.Columns[0].Width = 50; //id_mass
            dgvMassage.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //mass_date
            // Установка названия колонок
            dgvMassage.Columns[0].HeaderText = @"ИД"; //id_mass
            dgvMassage.Columns[1].HeaderText = @"Дата"; //mass_date

            lblFio.Text = PatientMass.fio;
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubMassage = new frmSubMassage() { Owner = this, Text = "Редактирование массажа" };
                // Открываем форму в модальном режиме
                frmSubMassage.ShowDialog();
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
                Massage = new Massage();
                // Если в DGV есть выделенные ячейки
                if (dgvMassage.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvMassage.CurrentRow != null)
                    {
                        Massage.pat_id = PatientMass.id_patient;
                        Massage.id_mass = dgvMassage.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvMassage.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Massage.mass_date = Convert.ToDateTime(dgvMassage.CurrentRow.Cells[1].Value);
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

        private void frmMassage_Load(object sender, EventArgs e)
        {
            var frmAppointment = Owner as frmAppointment;
            if (frmAppointment == null) return;
            PatientMass = frmAppointment.PatientApp;
            InitializeMassageDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Massage.pat_id = PatientMass.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmSubMassage = new frmSubMassage { Owner = this, Text = "Добавление массажа" };
            // Открываем форму в модальном режиме
            frmSubMassage.ShowDialog();
            InitializeMassageDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeMassageDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить массаж за дату {0} по пациенту {1}?",
                                  Massage.mass_date.ToShortDateString(), PatientMass.fio), @"Удаление массажа",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Massage.Delete(Massage.id_mass);
            }
            InitializeMassageDGV();
        }

        private void dgvMassage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeMassageDGV();
            }
        }

        private void dgvMassage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeMassageDGV();
        }
    }
}
