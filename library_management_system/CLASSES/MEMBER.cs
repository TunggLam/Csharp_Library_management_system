using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_management_system.CLASSES
{
    internal class MEMBER
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public Boolean addMember(string name, string gender, string phone, string email, byte[] picture)
        {
            string query = "INSERT INTO `members`(`name`, `gender`, `phone`, `email`, `picture`) VALUES (@name,@gender,@phone,@email,@pic)";

            MySqlParameter[] paramters = new MySqlParameter[5];

            paramters[0] = new MySqlParameter("@name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            paramters[1] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            paramters[1].Value = gender;

            paramters[2] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            paramters[2].Value = phone;

            paramters[3] = new MySqlParameter("@email", MySqlDbType.VarChar);
            paramters[3].Value = email;

            paramters[4] = new MySqlParameter("@pic", MySqlDbType.Blob);
            paramters[4].Value = picture;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Boolean editMember(int id, string name, string gender, string phone, string email, byte[] picture)
        {
            string query = "UPDATE members SET name=@name, gender=@gender, phone=@phone, email=@email, picture=@pic WHERE id=@id";

            MySqlParameter[] parameters = new MySqlParameter[6];

            parameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            parameters[1].Value = gender;

            parameters[2] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameters[2].Value = phone;

            parameters[3] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[3].Value = email;

            parameters[4] = new MySqlParameter("@pic", MySqlDbType.Blob);
            parameters[4].Value = picture;

            parameters[5] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[5].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean removeMember(int id)
        {
            string query = "DELETE FROM members WHERE id =@id ";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable MembersList(Boolean display_fullname)
        {
            string query = "SELECT * FROM members ";

            if (display_fullname)
            {
                query = "SELECT 'id' ,'name', 'gender', 'phone', 'email', 'picture' FROM 'members' ";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }


        public DataRow getMemberById(int memberID)
        {
            string query = "SELECT * FROM `members` WHERE `id`=@id";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = memberID;

            DataTable table = new DataTable();
            table = db.getData(query, paramters);

            DataRow dr = null;

            if (table.Rows.Count > 0)
            {
                dr = table.Rows[0];
            }

            return dr;
        }


    }
}
