using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Med
{
    public class Examination
    {
        public int id_exam { get; set; }
        public int pat_id { get; set; }
        public DateTime exam_date { get; set; }
        public int medin_id { get; set; }
        public string medin_name { get; set; }

        public static DataSet Fill(int patId)
        {
            return Connect.Fill(string.Format("SELECT e.id_exam, e.exam_date, m.medin_name, e.medin_id " +
                                              "FROM examination e INNER JOIN medinst m ON e.medin_id = m.id_medin " +
                                              "WHERE e.pat_id = {0}", patId != 0 ? patId : 0));
        }

        public void Delete(int id)
        {
            Connect.Delete("examination", "id_exam", id);
        }

        public static void Add(Examination subExamination)
        {
            string[] rowName =
                {
                    "pat_id", "exam_date", "medin_id"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subExamination.pat_id, subExamination.exam_date, subExamination.medin_id
                };
            Connect.Add("examination", rowName, dbType, app);
        }

        public static void Edit(Examination subExamination)
        {
            string[] rowName =
                {
                    "pat_id", "exam_date", "medin_id", "id_exam"
                };
            MySqlDbType[] dbType =
                {
                    MySqlDbType.Int32, MySqlDbType.Date, MySqlDbType.Int32, MySqlDbType.Int32
                };
            object[] app = 
                {
                    subExamination.pat_id, subExamination.exam_date, subExamination.medin_id, subExamination.id_exam
                };
            Connect.Edit("examination", rowName, dbType, app);
        }
    }
}
