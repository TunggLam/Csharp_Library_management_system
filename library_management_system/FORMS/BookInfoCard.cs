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
    public partial class BookInfoCard : Form
    {
        int bookId;
        public BookInfoCard(int id)
        {
            InitializeComponent();
            bookId = id;
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        private void BookInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                // display the book info
                DataRow data = book.getBookInfo(bookId);

                label_isbn.Text = data["isbn"].ToString();
                label_title.Text = data["title"].ToString();
                label_author.Text = data["author"].ToString();

                label_genre.Text = data["genre"].ToString();

                int qty = Convert.ToInt32(data["quantity"].ToString());

                if (qty == 0)
                {
                    label_qty.BackColor = Color.Red;
                }
                else if (qty > 0 && qty < 11)
                {
                    label_qty.BackColor = Color.Orange;
                }
                else
                {
                    label_qty.BackColor = Color.LimeGreen;
                }

                label_qty.Text = data["quantity"].ToString();
                label_price.Text = data["price"].ToString();
                label_publisher.Text = data["publisher"].ToString();
                label_dateAdded.Text = data["date_received"].ToString();
                richTextBox_description.Text = data["description"].ToString();

                // display the book cover
                byte[] cover = (byte[])data["cover"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBox_cover.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Book To Show: " + ex.Message);
                // hide the label quantity
                label_qty.Visible = false;
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
