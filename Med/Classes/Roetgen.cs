using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Roetgen
    {
        public int id_roet { get; set; }
        public int pat_id { get; set; }
        public DateTime roet_date { get; set; }
        public int roet_name_id { get; set; }
        public string roet_name { get; set; }

        public static DataSet Fill(int patId)
        {
            return Connect.Fill(string.Format("SELECT r1.id_roet, r1.roet_date, r2.roet_name, r1.roet_name_id " +
                                              "FROM roetgen r1 INNER JOIN roet_name r2 ON r1.roet_name_id = r2.id_roet_name " +
                                              "WHERE r1.pat_id = {0}", patId != 0 ? patId : 0));
        }

        public void Delete(int id)
        {
            Connect.Delete("roetgen", "id_roet", id);
        }

        public static void Add(Roetgen subRoetgen)
        {
            string[] rowName =
                {
                    "pat_id", "roet_date", "roet_name_id"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subRoetgen.pat_id, subRoetgen.roet_date, subRoetgen.roet_name_id
                };
            Connect.Add("roetgen", rowName, dbType, app);
        }

        public static void Edit(Roetgen subRoetgen)
        {
            string[] rowName =
                {
                    "pat_id", "roet_date", "roet_name_id", "id_roet"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Int32, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subRoetgen.pat_id, subRoetgen.roet_date, subRoetgen.roet_name_id, subRoetgen.id_roet
                };
            Connect.Edit("roetgen", rowName, dbType, app);
        }
    }
}
