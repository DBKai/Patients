using System;
using System.Windows.Forms;

namespace Med
{
    public partial class frmHandbook : Form
    {
        private readonly BindingSource _bindingSource;
        public string CurrentTable = "subdivision";
        public Handbook Handbook;

        public frmHandbook()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            Handbook = new Handbook();
        }

        // Инициализация DataGridView (DGV)
        private void InitializeHandbookDGV()
        {
            // Заполняем DataTable
            var dataTable = Handbook.Fill(CurrentTable).Tables[0];
            // Привязываем полученную таблицу к BindingSource
            _bindingSource.DataSource = dataTable;
            // Привязка заполненого DataSource к DGV
            dgvHandbook.DataSource = _bindingSource;
            // Установка ширины колонок
            dgvHandbook.Columns[0].Width = 50; //id
            dgvHandbook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // name
            // Установка названия колонок
            dgvHandbook.Columns[0].HeaderText = @"ИД"; //id
            dgvHandbook.Columns[1].HeaderText = @"Наименование"; //name
        }

        // Отправка данных
        private void SendData()
        {
            try
            {
                if (!ReceivingData()) return;
                // Создаем экземпляр формы, инициализируем 
                var frmSubHandbook = new frmSubHandbook { Owner = this, Text = "Редактирование записи" };
                // Открываем форму в модальном режиме
                frmSubHandbook.ShowDialog();
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
                Handbook = new Handbook();
                // Если в DGV есть выделенные ячейки
                if (dgvHandbook.SelectedCells.Count > 0)
                {
                    // то заполняем класс значениями из DGV
                    if (dgvHandbook.CurrentRow != null)
                    {
                        Handbook.id = dgvHandbook.CurrentRow.Cells[0].Value.ToString() != ""
                                                 ? Convert.ToInt32(dgvHandbook.CurrentRow.Cells[0].Value.ToString())
                                                 : 0;
                        Handbook.name = dgvHandbook.CurrentRow.Cells[1].Value.ToString();
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

        private void ShowHandookName(Control control)
        {
            lblHandbookName.Text = toolTip1.GetToolTip(control);
        }

        private void btnVaccination_Click(object sender, EventArgs e)
        {
            CurrentTable = "vac_name";
            InitializeHandbookDGV();
            ShowHandookName(btnVaccination);
        }

        private void btnRoetgen_Click(object sender, EventArgs e)
        {
            CurrentTable = "roet_name";
            InitializeHandbookDGV();
            ShowHandookName(btnRoetgen);
        }
        
        private void btnMedinst_Click(object sender, EventArgs e)
        {
            CurrentTable = "medinst";
            InitializeHandbookDGV();
            ShowHandookName(btnMedinst);
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            CurrentTable = "place";
            InitializeHandbookDGV();
            ShowHandookName(btnPlace);
        }

        private void btnStreet_Click(object sender, EventArgs e)
        {
            CurrentTable = "street";
            InitializeHandbookDGV();
            ShowHandookName(btnStreet);
        }

        private void btnSubdivision_Click(object sender, EventArgs e)
        {
            CurrentTable = "subdivision";
            InitializeHandbookDGV();
            ShowHandookName(btnSubdivision);
        }

        private void btnProfession_Click(object sender, EventArgs e)
        {
            CurrentTable = "profession";
            InitializeHandbookDGV();
            ShowHandookName(btnProfession);
        }

        private void dgvHandbook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendData();
                InitializeHandbookDGV();
            }
        }

        private void dgvHandbook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SendData();
            InitializeHandbookDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы, инициализируем 
            var frmSubHandbook = new frmSubHandbook { Owner = this, Text = "Добавление записи" };
            // Открываем форму в модальном режиме
            frmSubHandbook.ShowDialog();
            InitializeHandbookDGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SendData();
            InitializeHandbookDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалять записи из справочников нельзя!");
            /*
            if (!ReceivingData()) return;
            if (MessageBox.Show(
                    string.Format("Хотите удалить запись с ИД '{0}' и именем '{1}'?",
                                  Handbook.id, Handbook.name), @"Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Handbook.Delete(CurrentTable, Handbook.id);
            }
            InitializeHandbookDGV();*/
        }

        private void frmHandbook_Load(object sender, EventArgs e)
        {
            InitializeHandbookDGV();
        }
    }
}
