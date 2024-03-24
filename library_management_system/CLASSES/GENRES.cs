using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_management_system.CLASSES
{
    class GENRES
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean addGenre(string name)
        {
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)";
            
            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            if(db.setData(query, paramters) == 1)
            {
                return true;
            }
            else { return false; }

        }

        public Boolean editGenre(int id, string name)
        {
            string query = "UPDATE `genres` SET `name`= @genre_name WHERE `id`= @id";

            MySqlParameter[] paramters = new MySqlParameter[2];
            paramters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            paramters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[1].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public Boolean removeGenre(int id)
        {
            string query = "DELETE FROM `genres` WHERE `id` = @id";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else { return false; }
        }

        public DataTable GenresList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `genres`", null);
            return table;
        }
    }
}
