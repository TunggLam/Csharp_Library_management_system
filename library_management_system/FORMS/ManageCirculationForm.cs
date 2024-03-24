using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageCirculationForm : Form
    {
        public ManageCirculationForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.MEMBER member = new CLASSES.MEMBER();
        CLASSES.ISSUE_BOOK issueBook = new CLASSES.ISSUE_BOOK();

        private void ManageCirculationForm_Load(object sender, EventArgs e)
        {
            // display button images
            button_issue.Image = Image.FromFile("../../IMAGES/issue.png");
            button_return.Image = Image.FromFile("../../IMAGES/return.png");

            // customize the datagridview
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_issuedBooks.EnableHeadersVisualStyles = false;

            panel_issue.BringToFront();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // search the book by id and display the book title // in panel issue
        private void button_searchBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_BookId.Value);
            DataTable table = book.searchBookBy_IDorISBN("id", id, "");

            // check if the book exist
            if (table.Rows.Count > 0)
            {
                label_bookTitle.Text = table.Rows[0][2].ToString();
                label_bookTitle.ForeColor = Color.LimeGreen;

                // check the book availability
                if (issueBook.checkBookAvailability(id))
                {
                    label_availability.ForeColor = Color.Green;
                    label_availability.Text = "Yes";
                }
                else
                {
                    label_availability.ForeColor = Color.Red;
                    label_availability.Text = "No";
                }

            }
            else
            {
                label_bookTitle.Text = "this book doesn't exist";
                label_bookTitle.ForeColor = Color.OrangeRed;
            }

        }

        // search the member by id and display the member full name // in panel issue
        private void button_searchMember_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_MemberId.Value);
            DataRow row = member.getMemberById(id);

            if (row != null)
            {
                label_MemberFullName.Text = row["first_name"] + " " + row["last_name"];
                label_MemberFullName.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_MemberFullName.Text = "this member doesn't exist";
                label_MemberFullName.ForeColor = Color.OrangeRed;
            }
        }

        // display this book info in form ( card ) - // in panel issue
        private void label_bookTitle_Click(object sender, EventArgs e)
        {
            // get the book id
            int bookId = Convert.ToInt32(numericUpDown_BookId.Value);
            BookInfoCard bookCard = new BookInfoCard(bookId);
            bookCard.ShowDialog();
        }

        // in panel issue
        private void label_bookTitle_MouseEnter(object sender, EventArgs e)
        {
            label_bookTitle.Font = new Font(label_bookTitle.Font.FontFamily, 11, FontStyle.Underline);
        }

        // in panel issue
        private void label_bookTitle_MouseLeave(object sender, EventArgs e)
        {
            label_bookTitle.Font = new Font(label_bookTitle.Font.FontFamily, 10, FontStyle.Regular);
        }

        // in panel issue
        private void label_MemberFullName_MouseEnter(object sender, EventArgs e)
        {
            label_MemberFullName.Font = new Font(label_MemberFullName.Font.FontFamily, 11, FontStyle.Underline);
        }

        // in panel issue
        private void label_MemberFullName_MouseLeave(object sender, EventArgs e)
        {
            label_MemberFullName.Font = new Font(label_MemberFullName.Font.FontFamily, 10, FontStyle.Regular);
        }

        // display this member info in form ( card ) - panel issue
        private void label_MemberFullName_Click(object sender, EventArgs e)
        {
            // get the member id
            int memberId = Convert.ToInt32(numericUpDown_MemberId.Value);
            MemberInfoCard memberCard = new MemberInfoCard(memberId);
            memberCard.ShowDialog();
        }

        // button to issue the book - panel issue
        private void button_IssueBook_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(numericUpDown_BookId.Value);
            int memberId = Convert.ToInt32(numericUpDown_MemberId.Value);
            DateTime issueDate = dateTimePicker_Issue.Value;
            DateTime returnDate = dateTimePicker_return.Value;
            string note = richTextBox_note.Text;

            try
            {
                // we need to chack if the book is available first
                // return date shouldn't be before the issue date
                // check if a copy of this book is still issued to this member
                if (issueBook.isBookStillIssuedByMember(memberId, bookId))
                {
                    MessageBox.Show("a copy of this book is still issued to this member", "Issued Book", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (issueBook.checkBookAvailability(bookId))
                    {
                        if (issueDate < returnDate)
                        {
                            if (issueBook.Issue(bookId, memberId, "issued", issueDate, returnDate, note))
                            {
                                MessageBox.Show("Book Issued", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("the return date shouldn't be before the issue date");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book Is Not Available Right Now", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Make Sure To Enter a Valid Book and Member ID | " + ex.Message, "ID'S Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        // show the panel return
        // populate the datagridview
        private void button_return_Click(object sender, EventArgs e)
        {
            panel_return.BringToFront();
            dataGridView_issuedBooks.DataSource = issueBook.issueList("");// in panel return
        }

        // display the selected row data  - panel return
        private void dataGridView_issuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_BookId_2.Value = (int)dataGridView_issuedBooks.CurrentRow.Cells[0].Value;
            numericUpDown_MemberId_2.Value = (int)dataGridView_issuedBooks.CurrentRow.Cells[1].Value;
            dateTimePicker_IssueDate_2.Value = (DateTime)dataGridView_issuedBooks.CurrentRow.Cells[3].Value;
            dateTimePicker_ReturnDate_2.Value = (DateTime)dataGridView_issuedBooks.CurrentRow.Cells[4].Value;
            richTextBox_Note_2.Text = dataGridView_issuedBooks.CurrentRow.Cells[5].Value.ToString();

            // display the book title 
            int bkId = Convert.ToInt32(numericUpDown_BookId_2.Value);
            DataRow bookData = book.getBookInfo(bkId);
            label_BookTitle_2.Text = bookData["title"].ToString();

            // display the member fullname
            int atId = Convert.ToInt32(numericUpDown_MemberId_2.Value);
            DataRow row = member.getMemberById(atId);
            // the member doesn't exists
            label_MemberFullName_2.Text = row["first_name"] + " " + row["last_name"];
        }


        // return book  - panel return
        private void button_returnBook_Click(object sender, EventArgs e)
        {

            // NOTE: if you are gonna change an issued book status from 
            // losted to returned you need to edit the quantity to + 1
            // or don't allow the user to change the status of losted books

            // the user can only edit the status(to returned), retun date & note

            int bookId = Convert.ToInt32(numericUpDown_BookId_2.Value);
            int memberId = Convert.ToInt32(numericUpDown_MemberId_2.Value);
            DateTime issueDate = dateTimePicker_IssueDate_2.Value;
            DateTime returnDate = dateTimePicker_ReturnDate_2.Value;
            string note = richTextBox_Note_2.Text;

            if (issueDate < returnDate)
            {
                if (issueBook.returnBook(bookId, memberId, "returned", issueDate, returnDate, note))
                {
                    MessageBox.Show("Book Returned", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("the return date shouldn't be before the issue date");
            }

        }

        // the book is lost  - panel return
        private void button_lostBook_Click(object sender, EventArgs e)
        {
            // change the status to losted
            int bookId = Convert.ToInt32(numericUpDown_BookId_2.Value);
            int memberId = Convert.ToInt32(numericUpDown_MemberId_2.Value);
            DateTime issueDate = dateTimePicker_IssueDate_2.Value;
            DateTime returnDate = dateTimePicker_ReturnDate_2.Value;// the day he(the member) lost the book
            string note = richTextBox_Note_2.Text;

            if (issueBook.returnBook(bookId, memberId, "losted", issueDate, issueDate, note))
            {
                MessageBox.Show("Book Losted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // we need to edit the book quantity
                // the book quantity - 1(lost copy)
                if (book.bookQuantityMinusOne(bookId))
                {
                    MessageBox.Show("Book Qunatity Updated", "New Quantity Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("the return date shouldn't be before the issue date");
            }


        }

        // delete this data  - panel return
        private void button_delete_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(numericUpDown_BookId_2.Value);
            int memberId = Convert.ToInt32(numericUpDown_MemberId_2.Value);
            DateTime issueDate = dateTimePicker_IssueDate_2.Value;

            if (issueBook.removeData(bookId, memberId, issueDate))
            {
                MessageBox.Show("Data Deleted", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Somehing Went Wrong And I Don't Know Why", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // display the issued books  - panel return
        private void button_issued_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBook.issueList("issued");
        }

        // display the returned books  - panel return
        private void button_returned_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBook.issueList("returned");
        }

        // display the losted books  - panel return
        private void button_losted_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBook.issueList("losted");
        }

        // dislay all - panel return
        private void button_displayAll_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBook.issueList("");
        }

        // show panel issue
        private void button_issue_Click(object sender, EventArgs e)
        {
            panel_issue.BringToFront();
        }



    }
}
