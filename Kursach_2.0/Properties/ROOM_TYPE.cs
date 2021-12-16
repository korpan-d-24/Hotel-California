using System;
using MySql.Data.MySqlClient;
using System.Data;
namespace Kursach_2._0.Properties
{
    class ROOM_TYPE
    {
        FUNC func = new FUNC();
        // Додавання нового типу
        public Boolean insertType(string type, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `room_type`(`type`, `description`) VALUES (@typ,@dscr)");

            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

            return func.ExecQuery(command);
        }
        // Змінення вибраного типу
        public Boolean editType(int id, string type, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `room_type` SET `type`=@typ, `description`=@dscr WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

            return func.ExecQuery(command);
        }
        // Видалення вибраного типу
        public Boolean deleteType(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `room_type` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return func.ExecQuery(command);
        }
        // Отримання всіх типів
        public DataTable getAllTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `room_type`");

            return func.getData(command);
        }
    }
}
