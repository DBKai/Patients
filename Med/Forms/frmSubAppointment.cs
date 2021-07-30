using System;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSubAppointment : Form
    {
        public Appointment subAppointment;

        public frmSubAppointment()
        {
            InitializeComponent();
            subAppointment = new Appointment();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!SendData()) return;
            if (this.Text.Contains("Добавление"))
                Appointment.Add(subAppointment);
            else
                Appointment.Edit(subAppointment);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Получение данных
        private void ReceivingData()
        {
            try
            {
                // Объявляем владельца формы frmSubCard
                var frmApp = Owner as frmAppointment;
                if (frmApp == null) return;
                // Присваиваем значения переданного класса Card классу Card текущей формы
                subAppointment = frmApp.Appointment;
                if (!this.Text.Contains("Добавление"))
                {
                    dtpDT_Appoint.Value = Convert.ToDateTime(subAppointment.appointdate);
                    txbDiagnosis.Text = subAppointment.diagnosis;
                    txbTreatment.Text = subAppointment.treatment;
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
                subAppointment.appointdate = dtpDT_Appoint.Value;
                subAppointment.diagnosis = txbDiagnosis.Text;
                subAppointment.treatment = txbTreatment.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void frmSubAppointment_Load(object sender, EventArgs e)
        {
            ReceivingData();
        }
    }
}
