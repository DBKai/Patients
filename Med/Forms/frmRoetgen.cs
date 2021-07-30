using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmRoetgen : Form
    {
        private readonly BindingSource _bindingSource;
        public Roetgen Roetgen;
        public Patient PatientRoet;

        public frmRoetgen()
        {
            InitializeComponent();
            Roetgen = new Roetgen();
            PatientRoet = new Patient();
            _bindingSource = new BindingSource();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeRoetgenDGV()
        {
            // Заполняем DataTable значениями из таблицы examination
            DataTable dataTable = Roetgen.Fill(PatientRoet.id_patient).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            _bindingSource.Sort = "roet_date DESC";
            // Привязка заполненого DataSource к DGV
            dgvRoetgen.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvRoetgen.Columns[0].Width = 50; //id_roet
            dgvRoetgen.Columns[1].Width = 90; //roet_date
            dgvRoetgen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //roet_name
            dgvRoetgen.Columns[3].Width = 50; //roet_name_id
            // Установка названия колонок
            dgvRoetgen.Columns[0].HeaderText = @"ИД"; //id_roet
            dgvRoetgen.Columns[1].HeaderText = @"Дата"; //roet_date
            dgvRoetgen.Columns[2].HeaderText = @"Наименование снимка"; //roet_name
            // Скрытие столбца с roet_name_id
            dgvRoetgen.Columns[3].Visible = false;

            lblFio.Text = PatientRoet.fio;
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubRoetgen = new frmSubRoetgen { Owner = this, Text = "Редактирование снимка" };
                // Открываем форму в модальном режиме
                frmSubRoetgen.ShowDialog();
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
                Roetgen = new Roetgen();
                // Если в DGV есть выделенные ячейки
                if (dgvRoetgen.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvRoetgen.CurrentRow != null)
                    {
                        Roetgen.pat_id = PatientRoet.id_patient;
                        Roetgen.id_roet = dgvRoetgen.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvRoetgen.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Roetgen.roet_date = Convert.ToDateTime(dgvRoetgen.CurrentRow.Cells[1].Value);
                        Roetgen.roet_name = dgvRoetgen.CurrentRow.Cells[2].Value.ToString();
                        Roetgen.roet_name_id = Convert.ToInt32(dgvRoetgen.CurrentRow.Cells[3].Value.ToString());
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

        private void frmExamination_Load(object sender, EventArgs e)
        {
            var frmAppointment = Owner as frmAppointment;
            if (frmAppointment == null) return;
            PatientRoet = frmAppointment.PatientApp;
            InitializeRoetgenDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Roetgen.pat_id = PatientRoet.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmSubRoetgen = new frmSubRoetgen { Owner = this, Text = "Добавление снимка" };
            // Открываем форму в модальном режиме
            frmSubRoetgen.ShowDialog();
            InitializeRoetgenDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeRoetgenDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить снимок за дату {0} по пациенту {1}?",
                                  Roetgen.roet_date.ToShortDateString(), PatientRoet.fio), @"Удаление снимка",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Roetgen.Delete(Roetgen.id_roet);
            }
            InitializeRoetgenDGV();
        }

        private void dgvRoetgen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeRoetgenDGV();
            }
        }

        private void dgvRoetgen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeRoetgenDGV();
        }
    }
}
