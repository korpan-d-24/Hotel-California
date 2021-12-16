using MySql.Data.MySqlClient;
using System.IO;

namespace Kursach_2._0
{
    class Personal
    {
        FUNC func = new FUNC();

        // Створюємо функцію для додавання нового працівника до бази даних
        public bool insertWorker(string fname, string lname, string mname, string login, string pass, string phone, string position, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `personal`(`first_name`, `last_name`, `middle_name`, `login`, `password`, `phone`, `position`, `photo`) VALUES (@fn,@ln,@mn,@log,@pass,@ph,@pos,@pic)");
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pos", MySqlDbType.Text).Value = position;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();

            return func.ExecQuery(command);
        }
    }
}
