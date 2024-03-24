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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        int author_id = 6;
        ImageList imageList_Images = new ImageList();
        private void NewForm_Load(object sender, EventArgs e)
        {
            /*
            // display the author books in the listview
            CLASSES.BOOKS book = new CLASSES.BOOKS();
            DataTable booksList = book.authorBooks(author_id);

            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];

            // loop to populate the titles & images
            for (int i = 0; i < booksList.Rows.Count; i++)
            {
                byte[] img = (byte[])booksList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                // add image to the image list
                imageList_Images.Images.Add(Image.FromStream(ms));

                // add title to the titles array
                titles[i] = booksList.Rows[i][2].ToString();
            }

            listView_books.View = View.LargeIcon;
            imageList_Images.ImageSize = new Size(200, 250);
            listView_books.LargeImageList = imageList_Images;

            for (int j = 0; j < imageList_Images.Images.Count; j++)
            {
                listView_books.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }
             */

            listView_books.View = View.Details;

            listView_books.Columns.Add("Cover", 200);
            listView_books.Columns.Add("Title", 200);
            listView_books.Columns.Add("Price", 80);
            listView_books.Columns.Add("Publisher", 80);
            listView_books.Columns.Add("Date", 80);

            populate();
        }

        public void populate()
        {
            imageList_Images.ImageSize = new Size(50, 50);

            // display the author books in the listview
            CLASSES.BOOKS book = new CLASSES.BOOKS();
            DataTable booksList = book.authorBooks(author_id);

            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];
            String[] isbns = new String[booksList.Rows.Count];
            String[] col1 = new String[booksList.Rows.Count];
            String[] col2 = new String[booksList.Rows.Count];
            String[] col3 = new String[booksList.Rows.Count];

            // loop to populate the titles & images
            for (int i = 0; i < booksList.Rows.Count; i++)
            {
                byte[] img = (byte[])booksList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                // add image to the image list
                imageList_Images.Images.Add(Image.FromStream(ms));

                // add isbn to the isbns array
                isbns[i] = booksList.Rows[i][1].ToString();

                // add title to the titles array
                titles[i] = booksList.Rows[i][2].ToString();

                col1[i] = booksList.Rows[i][6].ToString();
                col2[i] = booksList.Rows[i][7].ToString();
                col3[i] = booksList.Rows[i][8].ToString();

                //imageList_Images.Images.Add(j,Image.FromStream(ms));
            }

            listView_books.SmallImageList = imageList_Images;

            for (int j = 0; j < imageList_Images.Images.Count; j++)
            {
                listView_books.Items.Add(new ListViewItem(new string[] { isbns[j], titles[j], col1[j], col2[j], col3[j] }, j));
                //listView_books.Items.Add(isbns[j]).SubItems.Add(titles[j]);
            }

        }
    }
}
