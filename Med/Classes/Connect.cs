using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Med
{
    class Connect
    {
        private static readonly MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.ConnectionString);
        private static MySqlDataAdapter _dataAdapter;
        private static MySqlCommand _command;
        private static DataSet _dataSet;

        public static DataSet Fill(string query)
        {
            try
            {
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                _dataAdapter = new MySqlDataAdapter(_command); // Передаем команду в MySqlDataAdapter
                _dataAdapter.Fill(_dataSet = new DataSet(), "Table"); // Инициализируем и заполняем DataSet данными из DataAdapter
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _dataSet;
        }

        public static string CreateQuery(string tableName, string shortName)
        {
            return string.Format("SELECT * FROM {1} ORDER BY {0} ASC", shortName, tableName);
        }

        public static void Add(string tableName, string[] rowNames, MySqlDbType[] dbTypes, object[] valuesObjects)
        {
            try
            {
                string query = string.Format("INSERT INTO {0}({1}) VALUES({2})", tableName, CreateFields(rowNames), CreateParameters(dbTypes.Length));
                
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                for (int i = 0; i < dbTypes.Length; i++)
                {
                    var parameter = new MySqlParameter("@param" + i, dbTypes[i]) {Value = valuesObjects[i]};
                    _command.Parameters.Add(parameter);
                }

                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Edit(string tableName, string[] rowNames, MySqlDbType[] dbTypes, object[] valuesObjects)
        {
            try
            {
                string query = string.Format("UPDATE {0} SET {1} ", tableName, CreateFieldsAndParameters(rowNames, dbTypes.Length-1));
                
                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                for (int i = 0; i < dbTypes.Length; i++)
                {
                    var parameter = new MySqlParameter("@param" + i, dbTypes[i]) { Value = valuesObjects[i] };
                    _command.Parameters.Add(parameter);
                }

                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private static string CreateFieldsAndParameters(string[] rowNames, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += i + 1 == count ? rowNames[i] + "=@param" + i : rowNames[i] + "=@param" + i + ", ";
            }
            return result + (" WHERE " + rowNames[count] + "=@param" + count);
        }

        private static string CreateFields(string[] rowNames)
        {
            string rowName = "";
            for (int index = 0; index < rowNames.Length; index++)
            {
                rowName += (index + 1) == rowNames.Length ? rowNames[index] : rowNames[index] + ", ";
            }
            return rowName;
        }

        private static string CreateParameters(int count)
        {
            string parString = "";
            for (int index = 0; index < count; index++)
            {
                parString += (index + 1) == count ? "@param" + index : "@param" + index + ", ";
            }
            return parString;
        }

        public static void Delete(string tableName, string conditionName, int condition)
        { //condition - условие для удаления
            try
            {
                string query = string.Format("DELETE FROM {0} WHERE {1}=@parameter", tableName, conditionName);

                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand

                var parameter = new MySqlParameter("@parameter", MySqlDbType.Int32) {Value = condition};
                _command.Parameters.Add(parameter);
                
                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Delete(string tableName)
        {
            try
            {
                string query = string.Format("DELETE FROM {0}", tableName);

                Connection.Open(); // Открываем подключение к БД
                _command = new MySqlCommand(query, Connection); // Инициализируем MySqlCommand
                _command.ExecuteNonQuery(); // Выполняем переданный запрос query без возврата результата
                Connection.Close(); // Закрываем подключение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
