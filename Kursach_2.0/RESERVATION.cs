using MySql.Data.MySqlClient;
using System;

namespace Kursach_2._0
{
    class RESERVATION
    {
        FUNC func = new FUNC();

        // Функція для додавання нового бронювання до бази даних
        public bool insertReservatoin(int num, string fname, string lname, string phone, DateTime dataIn, DateTime dataOut)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `reservation`(`number`, `first_name`, `last_name`, `phone`, `datain`, `dataout`) VALUES (@num, @fnm, @lnm, @phn, @din, @dout)");
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = num;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@din", MySqlDbType.DateTime).Value = dataIn;
            command.Parameters.Add("@dout", MySqlDbType.DateTime).Value = dataOut;

            return func.ExecQuery(command);
        }

        // Функція для зміни данних про бронювання в базі даних
        public bool updateReservatoin(int id, int num, string fname, string lname, string phone, DateTime dataIn, DateTime dataOut)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `reservation` SET `number`=@num,`first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`datain`=@din,`dataout`=@dout WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = num;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@din", MySqlDbType.DateTime).Value = dataIn;
            command.Parameters.Add("@dout", MySqlDbType.DateTime).Value = dataOut;

            return func.ExecQuery(command);
        }
        // Функція для видалення данних про бронювання з бази даних
        public bool deleteReservatoin(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `reservation` WHERE `id`=@id");
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
