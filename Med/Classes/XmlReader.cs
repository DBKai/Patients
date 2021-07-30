using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Med
{
    class XmlReader
    {
        public readonly string PathConf = Application.StartupPath + "\\config.xml";
        private readonly string[] _settings = new string[2];

        //создание xml
        public void CreateXmlDocument()
        {
            try
            {
                var xw = new XmlTextWriter(PathConf, Encoding.UTF8) {Indentation = 4, Formatting = Formatting.Indented};
                xw.WriteStartDocument();
                xw.WriteStartElement("Settings");
                xw.WriteElementString("ShowDismissed", "true");
                xw.WriteElementString("CreateArchive", "true");
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //загрузка параметров из XML
        public string[] LoadSet()
        {
            XmlTextReader xr = null;
            bool isCommonSection = false;
            
            try
            {
                xr = new XmlTextReader(PathConf) {WhitespaceHandling = WhitespaceHandling.None};
                while (xr.Read())
                {
                    switch (xr.NodeType)
                    {
                        case XmlNodeType.Element:
                            {
                                if (isCommonSection)
                                {
                                    switch (xr.Name)
                                    {
                                        case "ShowDismissed":
                                            {
                                                _settings[0] = xr.ReadString();
                                                break;
                                            }
                                        case "CreateArchive":
                                            {
                                                _settings[1] = xr.ReadString();
                                                break;
                                            }
                                    }
                                }
                                else
                                {
                                    switch (xr.Name)
                                    {
                                        case "Settings":
                                            {
                                                isCommonSection = true;
                                                break;
                                            }
                                    }
                                }
                                break;
                            }
                        case XmlNodeType.EndElement:
                            {
                                switch (xr.Name)
                                {
                                    case "Settings":
                                        {
                                            isCommonSection = false;
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (xr != null)
                    xr.Close();
            }
            return _settings;
        }

        //сохранение параметров XML
        public void SaveSet(string[] newConfig)
        {
            try
            {
                var xw = new XmlTextWriter(PathConf, Encoding.UTF8) { Indentation = 4, Formatting = Formatting.Indented };
                xw.WriteStartDocument();
                xw.WriteStartElement("Settings");
                xw.WriteElementString("ShowDismissed", newConfig[0]);
                xw.WriteElementString("CreateArchive", newConfig[1]);
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateArchive()
        {
            try
            {
                var cmdArch = new System.Diagnostics.Process
                    {
                        StartInfo =
                            {
                                FileName = @"cmd.exe",
                                Arguments = string.Format("/C \"{2}\" a {0}\\Archives\\DB_{1}.7z {0}\\DB.mdb", Application.StartupPath, DateTime.Now.ToShortDateString(), _settings[1])
                            }
                    };
                cmdArch.Start();
                cmdArch.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
