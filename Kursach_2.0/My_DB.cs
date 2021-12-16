using MySql.Data.MySqlClient;
using System.Data;


namespace Kursach_2._0
{
    /*
     * у цьому класі ми створимо зв'язок між нашим додатком і базою даних mysql
     * нам потрібно додати до проекту конектор mysql
     * нам потрібно створити базу даних mysql
     */
    class My_DB
    {
        // підключаємось
        private MySqlConnection con = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=root;database=kursach");

        // створюємо функцію, для отримання з'єднання
        public MySqlConnection getConnection
        {
            get { return con; }
        }

        // створюємо функцію для відкриття з'єднання
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        // створюємо функцію для закриття з'єднання
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
