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
    public partial class ManageAuthorsForm : Form
    {

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            // display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
            button_exportAuthors.Image = Image.FromFile("../../IMAGES/activity-feed.png");
            button_Show_Author_Books.Image = Image.FromFile("../../IMAGES/book-stack.png");

            // populate datagridview with authors
            dataGridView_authors.DataSource = author.AuthorsList(false);

            // customize datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_authors.EnableHeadersVisualStyles = false;

            // show the number of authors
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";


        }


        // add a new author
        private void button_add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_education.Text;
            string bio = richTextBox_bio.Text;

            // check if the first/last name are empty
            if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("Bạn cần nhập họ và tên tác giả", "Dữ liệu trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio))
                {

                    MessageBox.Show("Tác giả mới được thêm thành công", "Tác giả mới", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // refresh datagridview
                    dataGridView_authors.DataSource = author.AuthorsList(false);

                    // update the number of authors
                    label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                }
                else
                {
                    MessageBox.Show("Tác giả chưa được thêm", "Thêm lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // button edit author
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string first_name = textBox_fname.Text;
                string last_name = textBox_lname.Text;
                string education = textBox_education.Text;
                string bio = richTextBox_bio.Text;

                // check if the first/last name are empty
                if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn cần nhập họ và tên tác giả", "Dữ liệu trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (author.editAuthor(id, first_name, last_name, education, bio))
                    {

                        MessageBox.Show("Dữ liệu tác giả đã được cập nhật thành công", "Chỉnh sửa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // refresh datagridview
                        dataGridView_authors.DataSource = author.AuthorsList(false);

                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu tác giả chưa được cập nhật", "Lỗi chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID tác giả không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_education.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_authors.CurrentRow.Cells[4].Value.ToString();
        }


        // button delete author
        private void button_delete_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                // show a confirmation message before deleting the author
                if (MessageBox.Show("Bạn có thực sự muốn xóa tác giả này không?", "Hộp xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (author.removeAuthor(id))
                    {
                        MessageBox.Show("Dữ liệu tác giả đã được xóa thành công", "Xóa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // clear fileds
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_education.Text = "";
                        richTextBox_bio.Text = "";

                        // refresh datagridview
                        dataGridView_authors.DataSource = author.AuthorsList(false);

                        // edit the number of authors
                        label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                    }
                    else
                    {
                        MessageBox.Show("Tác giả chưa bị xóa", "Xóa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID tác giả không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // show the selected author books
        private void button_Show_Author_Books_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(dataGridView_authors.CurrentRow.Cells[0].Value.ToString());
            string fname = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            string lname = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            string fullName = fname + " " + lname;
            BooksListForm bkLsFrm = new BooksListForm(authorId, fullName);
            bkLsFrm.Show();
        }

        // button export authors from datagridview to a text file
        private void button_exportAuthors_Click(object sender, EventArgs e)
        {
            // we will create a folder first
            if (!Directory.Exists(@"C:\authors"))
            {
                Directory.CreateDirectory(@"C:\authors");
            }

            string filePath = @"C:\authors\list.txt";

            if (!File.Exists(filePath))// check if this file exist
            {
                File.Create(filePath).Close();// create the file
                MessageBox.Show("file created");
            }

            // now we need to populate the text file with
            // the authors id and fullname
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string fname;
            string lname;
            string fullName;


            for (int i = 0; i < dataGridView_authors.Rows.Count; i++)// for rows
            {
                /*
                for(int j = 0; j < dataGridView_authors.Columns.Count; j++)// for columns
                {
                    writer.Write(dataGridView_authors.Rows[i].Cells[j].Value.ToString());
                }
                 */
                // we want to display just the author id and full name
                id = dataGridView_authors.Rows[i].Cells[0].Value.ToString();
                fname = dataGridView_authors.Rows[i].Cells[1].Value.ToString();
                lname = dataGridView_authors.Rows[i].Cells[2].Value.ToString();
                fullName = fname + " " + lname;

                writer.Write(id + " - " + fullName);

                writer.WriteLine("");// create a new line
                writer.WriteLine("----------------------------");
            }
            writer.Close();
            MessageBox.Show("Dữ liệu đã xuất");

        }

       
    }
}
