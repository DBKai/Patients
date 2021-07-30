using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Vaccination
    {
        public int id_vaccin { get; set; }
        public int pat_id { get; set; }
        public DateTime vaccine_date { get; set; }
        public double dose { get; set; }
        public int vac_id { get; set; }
        public int vac_name_id { get; set; }
        public string series { get; set; }
        public string vac_name { get; set; }

        public static DataSet Fill(int patId)
        {
            return Connect.Fill(string.Format("SELECT v1.id_vaccin, v1.vaccine_date, v2.vac_name, v1.dose, v1.series, v1.vac_name_id " +
                                              "FROM vaccination v1 INNER JOIN vac_name v2 ON v1.vac_name_id = v2.id_vac_name " +
                                              "WHERE v1.pat_id = {0}", patId != 0 ? patId : 0));
        }
        
        public void Delete(int id)
        {
            Connect.Delete("vaccination", "id_vaccin", id);
        }

        public static void Add(Vaccination subVaccination)
        {
            string[] rowName =
                {
                    "pat_id", "vaccine_date", "dose", "series", "vac_name_id"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Double, MySqlDbType.String, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subVaccination.pat_id, subVaccination.vaccine_date, subVaccination.dose, 
                    subVaccination.series, subVaccination.vac_id
                };
            Connect.Add("vaccination", rowName, dbType, app);
        }

        public static void Edit(Vaccination subVaccination)
        {
            string[] rowName =
                {
                    "pat_id", "vaccine_date", "dose", "series", "vac_name_id", "id_vaccin"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Double, MySqlDbType.String, 
                    MySqlDbType.Int32, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subVaccination.pat_id, subVaccination.vaccine_date, subVaccination.dose, 
                    subVaccination.series, subVaccination.vac_id, subVaccination.id_vaccin
                };
            Connect.Edit("vaccination", rowName, dbType, app);
        }
    }
}
