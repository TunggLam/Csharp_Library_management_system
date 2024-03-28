using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.FORMS
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.GENRES genre = new CLASSES.GENRES();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            // display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_ShowBooksList.Image = Image.FromFile("../../IMAGES/list.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
            button_selectCover.Image = Image.FromFile("../../IMAGES/upload.png");// in add panel
            button_selectCover_Edit.Image = Image.FromFile("../../IMAGES/upload.png"); // in edit panel
            button_exportBooks.Image = Image.FromFile("../../IMAGES/activity-feed.png");

            // populate combobox with genres ( in the add panel )
            comboBox_genre.DataSource = genre.GenresList();
            comboBox_genre.DisplayMember = "name";
            comboBox_genre.ValueMember = "id";

            // show the number of books
            label_booksCount.Text = book.BooksList().Rows.Count.ToString() + " Books";

            // show the panel edit
            panel_add.BringToFront();

        }

        // browse and display book cover
        private void button_selectCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_cover.Image = Image.FromFile(opf.FileName);
            }
        }

        // show authors list in a new form
        private void button_selectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsListForm athsLsForm = new AuthorsListForm(this);
            athsLsForm.Show();
        }

        // button add a new book
        private void button_AddBook_Click(object sender, EventArgs e)
        {

            // get data
            int author_id;
            int genre_id;
            int quantity;
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;
            double price;
            string publisher = textBox_publisher.Text;
            string description = richTextBox_description.Text;
            DateTime dt_rcv = dateTimePicker_dateRecieved.Value;

            MemoryStream ms = new MemoryStream();
            pictureBox_cover.Image.Save(ms, pictureBox_cover.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {
                author_id = Convert.ToInt32(label_author_id.Text);
                genre_id = Convert.ToInt32(comboBox_genre.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_quantity.Value);
                price = Convert.ToDouble(textBox_price.Text);

                // the book isbn need to be unique
                if (!book.isIsbnExists(isbn, 0))
                {
                    // we need to check if this book name already exists
                    if (!book.isTitleExists(title, 0))
                    {
                        if (book.addBook(isbn, title, author_id, genre_id, quantity, price, publisher, dt_rcv, description, book_cover))
                        {
                            MessageBox.Show("Thêm sách mới thành công", "Sách mới", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // refresh the books counter
                            label_booksCount.Text = book.BooksList().Rows.Count.ToString() + " Books";

                        }
                        else
                        {
                            MessageBox.Show("Sách chưa được thêm", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiêu đề sách đã tồn tại, nhập tên mới", "Trùng tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("ISBN đã tồn tại, thay đổi ISBN", "Trùng ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // button clear fields
        private void button_ClearFields_Click(object sender, EventArgs e)
        {
            // we can use a foreach loop to clear all textboxes
            foreach (var control in panel_add.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }

            // set the id into the textbox_id
            // we will count the number of book
            int numberOfBooks = book.BooksList().Rows.Count;
            int theLastBookId = 0; // not the real value that will be inserted
            if (numberOfBooks > 0)
            {
                theLastBookId = Convert.ToInt32(book.BooksList().Rows[numberOfBooks - 1][0].ToString()) + 1;
            }

            textBox_id.Text = Convert.ToString(theLastBookId);

            richTextBox_description.Text = "";
            label_author_id.Text = "ID";
            comboBox_genre.SelectedIndex = 0;
            numericUpDown_quantity.Value = 0;
            dateTimePicker_dateRecieved.Value = DateTime.Now;
            pictureBox_cover.ImageLocation = "../../IMAGES/paper.jpg";
        }

        // show the add panel
        private void button_add_Click(object sender, EventArgs e)
        {
            panel_add.BringToFront();

            // clear the author id and textbox
            textBox_authorFullName.Text = "";
            label_author_id.Text = "ID";
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            panel_edit.BringToFront();

            // populate combobox with genres ( in the edit panel )
            comboBox_genres_Edit.DataSource = genre.GenresList();
            comboBox_genres_Edit.DisplayMember = "name";
            comboBox_genres_Edit.ValueMember = "id";

            // clear the author id and textbox
            textBox_Author_Edit.Text = "";
            label_AuthorId_Edit.Text = "ID";
        }

        // button select cover in the edit panel
        private void button_selectCover_Edit_Click(object sender, EventArgs e)
        {
            // we can copy and past the code 
            // or just call the other button event
            //button_selectCover.PerformClick();

            // but the the other button display the image in the add panel

            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_Cover_Edit.Image = Image.FromFile(opf.FileName);
            }

        }

        // search book by id ( edit panel )
        private void button_searchById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_ID_Edit.Text);
            DataTable data = book.searchBookBy_IDorISBN("id", id, "");
            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("ID sách không tồn tại, chọn ID ở bảng", "không tìm thấy ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // search book by isbn ( edit panel )
        private void button_searchByIsbn_Click(object sender, EventArgs e)
        {
            string isbn = textBox_Isbn_Edit.Text;
            DataTable data = book.searchBookBy_IDorISBN("isbn", 00, isbn);
            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("ISBN của sách này không tồn tại, hãy chọn ISBN khác", "Không tìm thấy ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // show authors list in a new form - ( edit panel )
        private void button_selectAuthor_Edit_Click(object sender, EventArgs e)
        {
            AuthorsListForm athsLsForm = new AuthorsListForm(this);
            athsLsForm.Show();
        }


        // button edit book (panel edit)
        private void button_editBook_Click(object sender, EventArgs e)
        {
            // get data
            int id;
            int author_id;
            int genre_id;
            int quantity;
            string isbn = textBox_Isbn_Edit.Text;
            string title = textBox_Title_Edit.Text;
            double price;
            string publisher = textBox_Publisher_Edit.Text;
            string description = richTextBox_Description_Edit.Text;
            DateTime dt_rcv = dateTimePicker_Date_Edit.Value;

            MemoryStream ms = new MemoryStream();
            pictureBox_Cover_Edit.Image.Save(ms, pictureBox_Cover_Edit.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {
                id = Convert.ToInt32(textBox_ID_Edit.Text);
                author_id = Convert.ToInt32(label_AuthorId_Edit.Text);
                genre_id = Convert.ToInt32(comboBox_genres_Edit.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_Qty_Edit.Value);
                price = Convert.ToDouble(textBox_Price_Edit.Text);

                // the book isbn need to be unique
                if (!book.isIsbnExists(isbn, id))
                {
                    // we need to check if this book name already exists
                    if (!book.isTitleExists(title, id))
                    {
                        if (book.editBook(id, isbn, title, author_id, genre_id, quantity, price, publisher, dt_rcv, description, book_cover))
                        {
                            MessageBox.Show("Dữ liệu sách đã được chỉnh sửa thành công", "Sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Book Data Not Edited", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên sách này đã tồn tại, hãy nhập tên mới", "Trùng tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Sách này ISBN đã tồn tại, hãy nhập một mã mới", "Trùng ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dữ liệu lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // create a function to display data in fields
        public void displayData(DataTable data)
        {
            // display book data
            textBox_ID_Edit.Text = data.Rows[0][0].ToString();
            textBox_Isbn_Edit.Text = data.Rows[0][1].ToString();
            textBox_Title_Edit.Text = data.Rows[0][2].ToString();

            // get the author data
            int author_id = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable authorData = author.getAuthorById(author_id);
            // first name                            Last Name    
            textBox_Author_Edit.Text = authorData.Rows[0][1].ToString() + " " + authorData.Rows[0][2].ToString();
            label_AuthorId_Edit.Text = data.Rows[0][3].ToString();

            textBox_Price_Edit.Text = data.Rows[0][6].ToString();
            textBox_Publisher_Edit.Text = data.Rows[0][7].ToString();
            richTextBox_Description_Edit.Text = data.Rows[0][9].ToString();
            numericUpDown_Qty_Edit.Value = Convert.ToInt32(data.Rows[0][5].ToString());
            comboBox_genres_Edit.SelectedValue = data.Rows[0][4].ToString();
            dateTimePicker_Date_Edit.Value = (DateTime)data.Rows[0][8];

            // display the book cover
            byte[] cover = (byte[])data.Rows[0][10];
            MemoryStream ms = new MemoryStream(cover);
            pictureBox_Cover_Edit.Image = Image.FromStream(ms);
        }

        // show the books list
        private void button_ShowBooksList_Click(object sender, EventArgs e)
        {
            panel_ShowBooks.BringToFront();

            // customize the datagridview rows height
            dataGridView_Books.RowTemplate.Height = 75;

            // display books in the datagridview
            dataGridView_Books.DataSource = book.BooksList();

            // customize the datagridview image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_Books.Columns[10];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // customize datagridview header
            dataGridView_Books.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_Books.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_Books.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Books.EnableHeadersVisualStyles = false;



        }

        // remove the selected book
        private void button_delete_Click(object sender, EventArgs e)
        {
            // show the remove book form
            RemoveBookForm rmvBkF = new RemoveBookForm();
            rmvBkF.Show();
        }

        // button edit book - in books list panel
        private void button_editBook__Click(object sender, EventArgs e)
        {
            // we will show the panel edit 
            // and display the selected book (from the datagridview) data in the fields
            panel_edit.BringToFront();
            // populate combobox with genres ( in the edit panel )
            comboBox_genres_Edit.DataSource = genre.GenresList();
            comboBox_genres_Edit.DisplayMember = "name";
            comboBox_genres_Edit.ValueMember = "id";

            int id = Convert.ToInt32(dataGridView_Books.CurrentRow.Cells[0].Value);
            DataTable data = book.searchBookBy_IDorISBN("id", id, "");
            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("ID sách này không tồn tại, hãy chọn một ID khác", "Không tìm thấy ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        // button export books from datagridview to a text file
        private void button_exportBooks_Click(object sender, EventArgs e)
        {
            // call the button show books so the datagridview will be populated
            button_ShowBooksList.PerformClick();

            // we will create a folder first
            if (!Directory.Exists(@"C:\books"))
            {
                Directory.CreateDirectory(@"C:\books");
            }

            string filePath = @"C:\books\list.txt";

            if (!File.Exists(filePath))// check if this file exist
            {
                File.Create(filePath).Close();// create the file
                MessageBox.Show("file đã được tạo");

            }


            // now we need to populate the text file with
            // the book id - isbn - title
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string isbn;
            string title;


            for (int i = 0; i < dataGridView_Books.Rows.Count; i++)// for rows
            {

                // we will display just the book id, isbn and title
                id = dataGridView_Books.Rows[i].Cells[0].Value.ToString();
                isbn = dataGridView_Books.Rows[i].Cells[1].Value.ToString();
                title = dataGridView_Books.Rows[i].Cells[2].Value.ToString();

                writer.Write(id + " - " + isbn + " - " + title);

                writer.WriteLine("");// create a new line
                writer.WriteLine("----------------------------");
            }
            writer.Close();
            MessageBox.Show("Dữ liệu đã được xuất");

        }


        // button remove selected book
        private void button_RemoveBook_Click(object sender, EventArgs e)
        {
            // we will but a try catch in case the datagridview is empty

            try
            {
                int bookId = Convert.ToInt32(dataGridView_Books.CurrentRow.Cells[0].Value.ToString());

                // show a confirmation message before deleting the book
                if (MessageBox.Show("Bạn có thực sự muốn xóa cuốn sách này?", "Hộp xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (book.removeBook(bookId))
                    {
                        MessageBox.Show("Dữ liệu sách đã được xóa thành công", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sách chưa bị xóa", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có sách được chọn | " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

       
    }
}
