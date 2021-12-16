using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace Kursach_2._0
{
    class ROOM_IMAGE
    {
        FUNC func = new FUNC();

        // Додаємо фото кімнати
        public bool insertImage(int roomId, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `room_image`(`room_id`, `images`) VALUES (@rid, @im)");
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = roomId;
            command.Parameters.Add("@im", MySqlDbType.LongBlob).Value = picture.ToArray();

            return func.ExecQuery(command);
        }
        // Видаляємо існуюче фото кімнати
        public bool deleteImage(int roomId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `room_image` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = roomId;

            return func.ExecQuery(command);
        }

        // Отримати фото номера за id
        public MemoryStream getImageById(int imageId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `room_image` WHERE `id`=@id");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = imageId;
            DataTable table = func.getData(command);

            MemoryStream picture = new MemoryStream((byte[])table.Rows[0]["images"]);

            return picture;
        }

        // Отримати фото вибраної кімнати
        public DataTable getRoomImages(int roomId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `room_image` WHERE `room_id`=@rmid");
            command.Parameters.Add("@rmid", MySqlDbType.Int32).Value = roomId;
            return func.getData(command);
        }
    }
}
