using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Kursach_2._0
{
    class ROOMS
    {
        private int id;
        private int type;
        private string isfree;
        private int size;
        private int bathrooms;
        private int bedrooms;
        private int rooms;
        private string price;
        private string address;
        private string description;
        private bool balcony;
        private bool mini_bar;
        private bool work_zone;
        private bool conditioner;
        private bool tv;

        FUNC func = new FUNC();

        public ROOMS() { }

        public ROOMS(int ID, int TYPE, string ISFREE, int SIZE, int BATHROOM, int BEDROOM, int ROOMS, string PRICE, string ADDRESS,
                        string DESCRIPTION, bool BALCONY, bool MINI_BAR, bool WORK_ZONE, bool CONDITIONER, bool TV)
        {
            this.id = ID;
            this.type = TYPE;
            this.isfree = ISFREE;
            this.size = SIZE;
            this.bathrooms = BATHROOM;
            this.bedrooms = BEDROOM;
            this.rooms = ROOMS;
            this.price = PRICE;
            this.address = ADDRESS;
            this.description = DESCRIPTION;
            this.balcony = BALCONY;
            this.mini_bar = MINI_BAR;
            this.work_zone = WORK_ZONE;
            this.conditioner = CONDITIONER;
            this.tv = TV;
        }

        // Додаємо нову кімнату
        public Boolean insertRoom(ROOMS rooms)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `rooms`(`type`,`isfree`, `size`, `price`, `address`, `bedrooms`, `bathrooms`, `room`, `description`, `balcony`, `mbar`, `workzone`, `conditioner`, `TV`)" +
                " VALUES (@typ, @isfr, @siz, @pric, @addr, @bedr, @bathr, @room, @descr, @bal, @mbar, @wzone, @cond, @tv)");

            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = rooms.type;
            command.Parameters.Add("@isfr", MySqlDbType.VarChar).Value = rooms.isfree;
            command.Parameters.Add("@siz", MySqlDbType.VarChar).Value = rooms.size;
            command.Parameters.Add("@pric", MySqlDbType.VarChar).Value = rooms.price;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = rooms.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = rooms.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = rooms.bathrooms;
            command.Parameters.Add("@room", MySqlDbType.Int32).Value = rooms.rooms;
            command.Parameters.Add("@descr", MySqlDbType.Text).Value = rooms.description;
            command.Parameters.AddWithValue("@bal", rooms.balcony);
            command.Parameters.AddWithValue("@mbar", rooms.mini_bar);
            command.Parameters.AddWithValue("@wzone", rooms.work_zone);
            command.Parameters.AddWithValue("@cond", rooms.conditioner);
            command.Parameters.AddWithValue("@tv", rooms.tv);

            return func.ExecQuery(command);
        }

        // Змінюємо існуючу кімнату
        public Boolean updateRoom(ROOMS rooms)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET `type`=@typ,`isfree`=@isfr,`size`=@siz,`price`=@pric,`address`=@addr,`bedrooms`=@bedr,`bathrooms`=@bathr,`room`=@room,`description`=@descr,`balcony`=@bal,`mbar`=@mbar,`workzone`=@wzone,`conditioner`=@cond,`TV`=@tv WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = rooms.id;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = rooms.type;
            command.Parameters.Add("@isfr", MySqlDbType.VarChar).Value = rooms.isfree;
            command.Parameters.Add("@siz", MySqlDbType.VarChar).Value = rooms.size;
            command.Parameters.Add("@pric", MySqlDbType.VarChar).Value = rooms.price;
            command.Parameters.Add("@addr", MySqlDbType.Text).Value = rooms.address;
            command.Parameters.Add("@bedr", MySqlDbType.Int32).Value = rooms.bedrooms;
            command.Parameters.Add("@bathr", MySqlDbType.Int32).Value = rooms.bathrooms;
            command.Parameters.Add("@room", MySqlDbType.Int32).Value = rooms.rooms;
            command.Parameters.Add("@descr", MySqlDbType.Text).Value = rooms.description;
            command.Parameters.AddWithValue("@bal", rooms.balcony);
            command.Parameters.AddWithValue("@mbar", rooms.mini_bar);
            command.Parameters.AddWithValue("@wzone", rooms.work_zone);
            command.Parameters.AddWithValue("@cond", rooms.conditioner);
            command.Parameters.AddWithValue("@tv", rooms.tv);

            return func.ExecQuery(command);
        }

        // Видаляємо існуючу кімнату
        public Boolean deleteRoom(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `rooms` WHERE `id`=@id");

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);
        }

        // Отримати дані про кімнату за номером
        public DataTable getRoomsById(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            return func.getData(command);
        }

    }
}
