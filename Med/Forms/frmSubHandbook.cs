using System;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubHandbook : Form
    {
        public Handbook subHandbook;
        public string tableName = "subdivision";

        public frmSubHandbook()
        {
            InitializeComponent();
            subHandbook = new Handbook();
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы frmSubCard
                var frmHand = Owner as frmHandbook;
                if (frmHand == null) return;
                // Присваиваем значения переданного класса Card классу Card текущей формы
                subHandbook = frmHand.Handbook;
                tableName = frmHand.CurrentTable;
                if (!this.Text.Contains("Добавление"))
                {
                    txbName.Text = subHandbook.name;
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
                subHandbook.name = txbName.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Handbook.Add(subHandbook, tableName);
            else
                Handbook.Edit(subHandbook, tableName);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSubHandbook_Load(object sender, EventArgs e)
        {
            ReceivingData();
        }
    }
}
