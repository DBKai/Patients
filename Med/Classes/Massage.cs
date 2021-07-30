using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Massage
    {
        public int id_mass { get; set; }
        public int pat_id { get; set; }
        public DateTime mass_date { get; set; }

        public static DataSet Fill(int patId)
        {
            return Connect.Fill(string.Format("SELECT id_mass, mass_date FROM massage WHERE pat_id = {0}", patId != 0 ? patId : 0));
        }

        public void Delete(int id)
        {
            Connect.Delete("massage", "id_mass", id);
        }

        public static void Add(Massage subMassage)
        {
            string[] rowName =
                {
                    "pat_id", "mass_date"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date
                };
            object[] app = 
                {
                    subMassage.pat_id, subMassage.mass_date
                };
            Connect.Add("massage", rowName, dbType, app);
        }

        public static void Edit(Massage subMassage)
        {
            string[] rowName =
                {
                    "pat_id", "mass_date", "id_mass"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subMassage.pat_id, subMassage.mass_date, subMassage.id_mass
                };
            Connect.Edit("massage", rowName, dbType, app);
        }
    }
}
