using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Handbook
    {
        public int id { get; set; }
        public string name { get; set; }

        public static DataSet Fill(string tableName)
        {
            return Connect.Fill(Connect.CreateQuery(tableName, ShortName(tableName)));
        }

        public void Delete(string currentTable, int id)
        {
            Connect.Delete(currentTable, ShortId(currentTable), id);
        }

        public static void Add(Handbook subHandbook, string tableName)
        {
            string[] rowName =
                {
                    ShortName(tableName)
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.String
                };
            object[] app = 
                {
                    subHandbook.name
                };
            Connect.Add(tableName, rowName, dbType, app);
        }

        public static void Edit(Handbook subHandbook, string tableName)
        {
            string[] rowName =
                {
                    ShortName(tableName), ShortId(tableName)
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.String, MySqlDbType.Int32 
                };
            object[] app = 
                {
                    subHandbook.name, subHandbook.id
                };
            Connect.Edit(tableName, rowName, dbType, app);
        }

        private static string ShortName(string tableName)
        {
            string shortname = "subdiv_name";
            switch (tableName)
            {
                case "subdivision": shortname = "subdiv_name"; break;
                case "profession": shortname = "prof_name"; break;
                case "medinst": shortname = "medin_name"; break;
                case "roet_name": shortname = "roet_name"; break;
                case "vac_name": shortname = "vac_name"; break;
                case "place": shortname = "place_name"; break;
                case "street": shortname = "street_name"; break;
            }
            return shortname;
        }

        private static string ShortId(string tableName)
        {
            string shortid = "id_subdiv";
            switch (tableName)
            {
                case "subdivision": shortid = "id_subdiv"; break;
                case "profession": shortid = "id_prof"; break;
                case "medinst": shortid = "id_medin"; break;
                case "roet_name": shortid = "id_roet_name"; break;
                case "vac_name": shortid = "id_vac_name"; break;
                case "place": shortid = "id_place"; break;
                case "street": shortid = "id_street"; break;
            }
            return shortid;
        }
    }
}
