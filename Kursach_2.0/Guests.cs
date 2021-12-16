using MySql.Data.MySqlClient;

namespace Kursach_2._0
{
    class Guests
    {
        FUNC func = new FUNC();

        // Функція для додавання нового гостя до бази даних
        public bool insertGuests(int num, string fname, string lname, string phone, int sum, int days)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `guests`(`number`, `first_name`, `last_name`, `phone`, `sum`, `days`) VALUES (@num, @fnm, @lnm, @phn, @sum, @day)");
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = num;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = sum;
            command.Parameters.Add("@day", MySqlDbType.Int32).Value = days;

            return func.ExecQuery(command);
        }

        // Функція для зміни данних про гостя до бази даних
        public bool updateGuests(int id, int num, string fname, string lname, string phone, int sum, int days)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `guests` SET `number`=@num,`first_name`=@fnm," +
                "`last_name`=@lnm,`phone`=@phn,`sum`=@sum, `days`=@day WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = num;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = sum;
            command.Parameters.Add("@day", MySqlDbType.Int32).Value = days;

            return func.ExecQuery(command);
        }
        // Функція для видалення данних про гостя з бази даних
        public bool deleteGuests(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `guests` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);
        }

        public bool IsFreeRoom(int id, string isfree)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET `isfree`=@isfr WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@isfr", MySqlDbType.VarChar).Value = isfree;

            return func.ExecQuery(command);
        }
    }
}
