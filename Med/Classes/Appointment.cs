using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Appointment
    {
        public int id_appoint { get; set; }
        public int pat_id { get; set; }
        public DateTime appointdate { get; set; }
        public string diagnosis { get; set; }
        public string treatment { get; set; }

        public static DataSet Fill(int patId)
        {
            return Connect.Fill(string.Format("SELECT id_appoint, appointdate, diagnosis, treatment FROM " +
                                                "appointment WHERE pat_id = {0}", patId != 0 ? patId : 0));
        }

        public void Delete(int id)
        {
            Connect.Delete("appointment", "id_appoint", id);
        }

        public static void Add(Appointment subAppointment)
        {
            string[] rowName =
                {
                    "pat_id", "appointdate", "diagnosis", "treatment"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.String, MySqlDbType.String
                };
            object[] app = 
                {
                    subAppointment.pat_id, subAppointment.appointdate, subAppointment.diagnosis, subAppointment.treatment
                };
            Connect.Add("appointment", rowName, dbType, app);
        }

        public static void Edit(Appointment subAppointment)
        {
            string[] rowName =
                {
                    "pat_id", "appointdate", "diagnosis", "treatment", "id_appoint"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.String, MySqlDbType.String, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subAppointment.pat_id, subAppointment.appointdate, subAppointment.diagnosis, 
                    subAppointment.treatment, subAppointment.id_appoint
                };
            Connect.Edit("appointment", rowName, dbType, app);
        }
    }
}
