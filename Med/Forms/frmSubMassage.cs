using System;
using System.Data;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubMassage : Form
    {
        private Massage subMassage;

        public frmSubMassage()
        {
            InitializeComponent();
            subMassage = new Massage();
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы
                var frmMass = Owner as frmMassage;
                if (frmMass == null) return;
                // Присваиваем значения переданного класса Massage классу Massage текущей формы
                subMassage = frmMass.Massage;
                if (!this.Text.Contains("Добавление"))
                {
                    dtpDT_Mass.Value = Convert.ToDateTime(subMassage.mass_date);
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
                subMassage.mass_date = dtpDT_Mass.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void frmSubMassage_Load(object sender, EventArgs e)
        {
            ReceivingData();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Massage.Add(subMassage);
            else
                Massage.Edit(subMassage);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
