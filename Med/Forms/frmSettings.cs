using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Med
{
    public partial class frmSettings : Form
    {
        private XmlReader xmlReader;
        public frmSettings()
        {
            InitializeComponent();
            xmlReader = new XmlReader();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            xmlReader.CreateXmlDocument();
            MessageBox.Show("Настройки успешно сохранены");
            Close();
        }
    }
}
