using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Patient
    {
        public int id_patient { get; set; }
        public string fio { get; set; }
        public DateTime birthday { get; set; }
        public int subdiv_id { get; set; }
        public string subdiv_name { get; set; }
        public int prof_id { get; set; }
        public string prof_name { get; set; }
        public DateTime initdate { get; set; }
        public DateTime? dismisdate { get; set; }
        public string polis { get; set; }
        public string snils { get; set; }
        public int place_id { get; set; }
        public int street_id { get; set; }
        public string house { get; set; }
        public string hull { get; set; }
        public string apartment { get; set; }

        public static DataSet Fill(bool showDismissed)
        {
            return Connect.Fill("SELECT id_patient, fio, birthday, subdiv_name, prof_name, " +
                                "initdate, dismisdate, polis, snils, subdiv_id, prof_id, place_id, street_id, " +
                                "house, hull, apartment FROM subdivision RIGHT JOIN (profession RIGHT JOIN " +
                                "patient ON prof_id=id_prof) ON subdiv_id=id_subdiv" + 
                                (!showDismissed ? " WHERE dismisdate IS NULL" : ""));
        }

        public static void Add(Patient patient)
        {
            string[] rowName =
                {
                    "fio", "birthday", "subdiv_id", "prof_id", "initdate", "dismisdate", 
                    "polis", "snils", "place_id", "street_id", "house", "hull", "apartment"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.String, MySqlDbType.Date, MySqlDbType.Int32, MySqlDbType.Int32, MySqlDbType.Date, 
                    MySqlDbType.Date, MySqlDbType.String, MySqlDbType.String, MySqlDbType.Int32, MySqlDbType.Int32, 
                    MySqlDbType.String, MySqlDbType.String, MySqlDbType.String
                };
            object[] pat = 
                {
                    patient.fio, patient.birthday, patient.subdiv_id, patient.prof_id, patient.initdate, 
                    patient.dismisdate, patient.polis, patient.snils, patient.place_id, patient.street_id,
                    patient.house, patient.hull, patient.apartment
                };
            Connect.Add("patient", rowName, dbType, pat);
        }

        public static void Edit(Patient patient)
        {
            string[] rowName =
                {
                    "fio", "birthday", "subdiv_id", "prof_id", "initdate", "dismisdate", 
                    "polis", "snils", "place_id", "street_id", "house", "hull", "apartment", "id_patient"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.String, MySqlDbType.Date, MySqlDbType.Int32, MySqlDbType.Int32, MySqlDbType.Date, 
                    MySqlDbType.Date, MySqlDbType.String, MySqlDbType.String, MySqlDbType.Int32, MySqlDbType.Int32, 
                    MySqlDbType.String, MySqlDbType.String, MySqlDbType.String, MySqlDbType.Int32
                };
            object[] pat = 
                {
                    patient.fio, patient.birthday, patient.subdiv_id, patient.prof_id, patient.initdate, 
                    patient.dismisdate, patient.polis, patient.snils, patient.place_id, patient.street_id,
                    patient.house, patient.hull, patient.apartment, patient.id_patient
                };
            Connect.Edit("patient", rowName, dbType, pat);
        }

        public void Delete(int idPatient)
        {
            Connect.Delete("appointment", "pat_id", idPatient);
            Connect.Delete("vaccination", "pat_id", idPatient);
            Connect.Delete("examination", "pat_id", idPatient);
            Connect.Delete("massage", "pat_id", idPatient);
            Connect.Delete("roetgen", "pat_id", idPatient);
            Connect.Delete("patient", "id_patient", idPatient);
        }
    }
}
