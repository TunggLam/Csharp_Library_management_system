using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace library_management_system.CLASSES
{
    class ISSUE_BOOK
    {

        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        CLASSES.BOOKS book = new CLASSES.BOOKS();

        // create a function to add a new issue 
        public Boolean Issue(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "INSERT INTO `issue_book`(`book_id`, `member_id`, `status`, `issue_date`, `return_date`, `note`) VALUES (@bId, @mId, @stt, @issDt, @rtnDt, @nt)";

            MySqlParameter[] paramters = new MySqlParameter[6];

            // @bId, @mId, @stt, @issDt, @rtnDt, @nt
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = memberId;

            paramters[2] = new MySqlParameter("@stt", MySqlDbType.VarChar);
            paramters[2].Value = status;

            paramters[3] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[3].Value = issueDate;

            paramters[4] = new MySqlParameter("@rtnDt", MySqlDbType.Date);
            paramters[4].Value = returnDate;

            paramters[5] = new MySqlParameter("@nt", MySqlDbType.Text);
            paramters[5].Value = note;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        // function to count the issued books
        public int countIssuedCopiesOfThisBook(int bookId)
        {
            string query = "SELECT * FROM `issue_book` WHERE `book_id`=@id and status = 'issued'";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            return db.getData(query, paramters).Rows.Count;

        }


        public Boolean checkBookAvailability(int bookId)
        {
            // check if this book is available
            // how to do that?
            // get the book quantity from table books and compare it to 
            // the number of book issued in the table issue_book 

            Boolean availability;

            // get the book quantity
            int bookQuantity = Convert.ToInt32(book.getBookInfo(bookId)["quantity"].ToString());

            // get the number of copy of the same book are issued
            int issuedCopies = countIssuedCopiesOfThisBook(bookId);

            // now check if this is available or not
            // if the quantity is biger than the number of issued copies
            if (bookQuantity > issuedCopies)
            {
                availability = true;
            }
            else
            {
                availability = false;
            }

            return availability;
        }

        // create a function to return data from from table issue_book
        public DataTable issueList(string status)
        {
            string query = "SELECT `book_id` as book, `member_id` as member, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book`";

            if (!status.Equals(""))
            {
                query = "SELECT `book_id` as book, `member_id` as member, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book` WHERE `status`='" + status + "'";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        // this function allow the user to edit the book status 
        public Boolean returnBook(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "UPDATE `issue_book` SET `status`=@stt,`return_date`=@rtnDt,`note`=@nt WHERE `book_id`=@bId AND `member_id`=@mId AND `issue_date`=@issDt";

            MySqlParameter[] paramters = new MySqlParameter[6];

            // @bId, @mId, @stt, @issDt, @rtnDt, @nt
            paramters[0] = new MySqlParameter("@stt", MySqlDbType.VarChar);
            paramters[0].Value = status;

            paramters[1] = new MySqlParameter("@rtnDt", MySqlDbType.Date);
            paramters[1].Value = returnDate;

            paramters[2] = new MySqlParameter("@nt", MySqlDbType.Text);
            paramters[2].Value = note;

            paramters[3] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[3].Value = bookId;

            paramters[4] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[4].Value = memberId;

            paramters[5] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[5].Value = issueDate;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // create a function to remove the selected data
        public Boolean removeData(int bookId, int memberId, DateTime issueDate)
        {
            string query = "DELETE FROM `issue_book` WHERE `book_id`=@bId AND `member_id`=@mId and issue_date=@issDt";

            MySqlParameter[] paramters = new MySqlParameter[3];
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = memberId;

            paramters[2] = new MySqlParameter("@issDt", MySqlDbType.Date);
            paramters[2].Value = issueDate;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // create a function to check if a book is still issued by a member
        // while trying to issued a new copy of the same book
        public Boolean isBookStillIssuedByMember(int memberId, int bookId)
        {

            string query = "SELECT * FROM `issue_book` WHERE `status`='issued' AND `book_id`=@bId AND `member_id`=@mId";

            MySqlParameter[] paramters = new MySqlParameter[2];
            paramters[0] = new MySqlParameter("@bId", MySqlDbType.Int32);
            paramters[0].Value = bookId;

            paramters[1] = new MySqlParameter("@mId", MySqlDbType.Int32);
            paramters[1].Value = memberId;

            DataTable table = db.getData(query, paramters);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
