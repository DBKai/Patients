using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmExamination : Form
    {
        private readonly BindingSource _bindingSource;
        public Examination Examination;
        public Patient PatientExam;

        public frmExamination()
        {
            InitializeComponent();
            Examination = new Examination();
            PatientExam = new Patient();
            _bindingSource = new BindingSource();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeExaminationDGV()
        {
            // Заполняем DataTable значениями из таблицы examination
            DataTable dataTable = Examination.Fill(PatientExam.id_patient).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            _bindingSource.Sort = "exam_date DESC";
            // Привязка заполненого DataSource к DGV
            dgvExamination.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvExamination.Columns[0].Width = 50; //id_exam
            dgvExamination.Columns[1].Width = 90; //exam_date
            dgvExamination.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //medin_name
            dgvExamination.Columns[3].Width = 50; //id_exam
            // Установка названия колонок
            dgvExamination.Columns[0].HeaderText = @"ИД"; //id_exam
            dgvExamination.Columns[1].HeaderText = @"Дата"; //exam_date
            dgvExamination.Columns[2].HeaderText = @"Наименование учреждения"; //medin_name
            // Скрытие столбца с medin_id
            dgvExamination.Columns[3].Visible = false;

            lblFio.Text = PatientExam.fio;
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubExamination = new frmSubExamination { Owner = this, Text = "Редактирование профосмотра" };
                // Открываем форму в модальном режиме
                frmSubExamination.ShowDialog();
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
                Examination = new Examination();
                // Если в DGV есть выделенные ячейки
                if (dgvExamination.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvExamination.CurrentRow != null)
                    {
                        Examination.pat_id = PatientExam.id_patient;
                        Examination.id_exam = dgvExamination.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvExamination.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Examination.exam_date = Convert.ToDateTime(dgvExamination.CurrentRow.Cells[1].Value);
                        Examination.medin_name = dgvExamination.CurrentRow.Cells[2].Value.ToString();
                        Examination.medin_id = Convert.ToInt32(dgvExamination.CurrentRow.Cells[3].Value.ToString());
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
            PatientExam = frmAppointment.PatientApp;
            InitializeExaminationDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Examination.pat_id = PatientExam.id_patient;
            // Создаем экземпляр формы, инициализируем 
            var frmSubExamination = new frmSubExamination { Owner = this, Text = "Добавление профосмотра" };
            // Открываем форму в модальном режиме
            frmSubExamination.ShowDialog();
            InitializeExaminationDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeExaminationDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить профосмотр за дату {0} по пациенту {1}?",
                                  Examination.exam_date.ToShortDateString(), PatientExam.fio), @"Удаление профосмотра",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Examination.Delete(Examination.id_exam);
            }
            InitializeExaminationDGV();
        }

        private void dgvExamination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeExaminationDGV();
            }
        }

        private void dgvExamination_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeExaminationDGV();
        }
    }
}
