using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace library_management_system.CLASSES
{
    internal class BOOKS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        // create a function to add a new book
        public Boolean addBook(string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_received, string description, byte[] cover)
        {
            string query = "INSERT INTO `books`(`isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_received`, `description`, `cover`) VALUES (@isbn,@title,@author,@genre,@qty,@price,@publisher,@d_recv,@descrp,@img)";

            MySqlParameter[] paramters = new MySqlParameter[10];
            paramters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            paramters[0].Value = isbn;
            paramters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            paramters[1].Value = title;
            paramters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            paramters[2].Value = author_id;
            paramters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            paramters[3].Value = genre_id;
            paramters[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            paramters[4].Value = quantity;
            paramters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            paramters[5].Value = price;
            paramters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            paramters[6].Value = publisher;
            paramters[7] = new MySqlParameter("@d_recv", MySqlDbType.Date);
            paramters[7].Value = date_received;
            paramters[8] = new MySqlParameter("@descrp", MySqlDbType.VarChar);
            paramters[8].Value = description;
            paramters[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            paramters[9].Value = cover;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // create a function to edit the selected book
        public Boolean editBook(int id, string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_received, string description, byte[] cover)
        {
            string query = "UPDATE `books` SET `isbn`=@isbn,`title`=@title,`author_id`=@author,`genre_id`=@genre,`quantity`=@qty,`price`=@price,`publisher`=@publisher,`date_received`=@d_recv,`description`=@descrp,`cover`=@img WHERE `id` = @id";

            MySqlParameter[] paramters = new MySqlParameter[11];
            paramters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            paramters[0].Value = isbn;
            paramters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            paramters[1].Value = title;
            paramters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            paramters[2].Value = author_id;
            paramters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            paramters[3].Value = genre_id;

            paramters[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            paramters[4].Value = quantity;
            paramters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            paramters[5].Value = price;
            paramters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            paramters[6].Value = publisher;
            paramters[7] = new MySqlParameter("@d_recv", MySqlDbType.Date);
            paramters[7].Value = date_received;
            paramters[8] = new MySqlParameter("@descrp", MySqlDbType.VarChar);
            paramters[8].Value = description;
            paramters[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            paramters[9].Value = cover;
            paramters[10] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[10].Value = id;
            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to remove the selected book
        public Boolean removeBook(int id)
        {
            string query = "DELETE FROM `books` WHERE `id`=@id";
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
        // create a function to edit book quantity
        // this function will be used when we set an issued copy of this book to losted
        // the new book quantity = book quantity - the lostb copy
        public Boolean bookQuantityMinusOne(int bookId)
        {
            string query = "UPDATE `books` SET `quantity`=quantity-1 WHERE `id`=@bId";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;
            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // create a function to return table of books
        public DataTable BooksList()
        {
            string query = "SELECT * FROM `books` ORDER BY id DESC";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        // create a function to return table of the selected author books
        public DataTable authorBooks(int authorId)
        {
            string query = "SELECT * FROM `books` WHERE `author_id` = @author_id";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@author_id", MySqlDbType.Int32);
            parameters[0].Value = authorId;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        // check if the book isbn already exists
        public Boolean isIsbnExists(string isbn, int id)
        {
            string query = "SELECT * FROM `books` WHERE `isbn`= @isbn AND id <> @id";
            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;
            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check if the book title already exists
        public Boolean isTitleExists(string title, int id)
        {
            string query = "SELECT * FROM `books` WHERE `title`= @title AND id <> @id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[0].Value = title;

            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // search book by id or isbn
        public DataTable searchBookBy_IDorISBN(string id_or_isbn, int id, string isbn)
        {
            string query;
            MySqlParameter[] parameters = new MySqlParameter[1];

            if (id_or_isbn.Equals("id"))
            {
                query = "SELECT * FROM `books` WHERE `id`= @id";
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM `books` WHERE `isbn`= @isbn";
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
            }
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;

        }

        // create a function to retrun the book info
        // with the author fullname and the genre name
        public DataRow getBookInfo(int bookId)
        {
            string query = "SELECT b.id, `isbn`, `title`, concat(a.first_name,' ', a.last_name) as author, g.name as genre, `quantity`, `price`, `publisher`, `date_received`, `description`, `cover` FROM books b, authors a, genres g WHERE b.author_id = a.id and b.genre_id = g.id and b.id = @id";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = bookId;
            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table.Rows[0];
        }
    }
}
