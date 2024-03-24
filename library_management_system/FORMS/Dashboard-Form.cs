using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_management_system.FORMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        CLASSES.MEMBER member = new CLASSES.MEMBER();
        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            //ảnh logo 
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/book.png");
            //ảnh nút đóng ở mành hình
            button_close.Image = Image.FromFile("../../IMAGES/x-mark-4-24.png");
            //ảnh nút sách ở mành hình
            button_books.Image = Image.FromFile("../../IMAGES/literature.png");
            //ảnh nút tác giả ở màn hình
            button_authors.Image = Image.FromFile("../../IMAGES/author.png");
            //ảnh nút thể loại ở màn hình
            button_genres.Image = Image.FromFile("../../IMAGES/tag.png");
            //ảnh nút bạn đọc ở màn hình
            button_member.Image = Image.FromFile("../../IMAGES/member.png");
            //ảnh nút mượn trả ở màn hình
            button_circulation.Image = Image.FromFile("../../IMAGES/loop.png");
            //ảnh nút tài khoản ở màn hình
            button_users.Image = Image.FromFile("../../IMAGES/users.png");

            /*DataTable bookData = book.BooksList();

           
            byte[] img;
            MemoryStream ms;
            int i = 0; 

            
            foreach (var panelControl in panel_displayBooks.Controls)
            {
                if (panelControl.GetType() == typeof(Panel))
                {
                 
                    Panel panel = (Panel)panelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    
                    foreach (var labelControl in panel.Controls)
                    {
                        if (labelControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)labelControl;
                            label.Text = "$" + bookData.Rows[i][6].ToString();
                        }
                    }

                    i++;
                }
            }*/


        }



        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            Login_Form lgf = new Login_Form(this);
            lgf.Show();

            label_membersCount.Text = member.MembersList(false).Rows.Count.ToString();
            label_booksCount.Text = book.BooksList().Rows.Count.ToString();
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString();
        }

        private void button_genres_Click(object sender, EventArgs e)
        {
            selectionButton(button_genres);
            ManageGenres_Form mngGnrF = new ManageGenres_Form();
            mngGnrF.Show();
        }

        private void button_member_Click(object sender, EventArgs e)
        {
            selectionButton(button_member);
            ManageMemberForm mngMb = new ManageMemberForm();
            mngMb.Show();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            selectionButton(button_users);
            ManageUsers mngUs = new ManageUsers();
            mngUs.Show();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            selectionButton(button_books);
            ManageBooksForm mngB = new ManageBooksForm();
            mngB.Show();
        }

        private void button_authors_Click(object sender, EventArgs e)
        {           
            selectionButton(button_authors);
            ManageAuthorsForm mngA = new ManageAuthorsForm();
            mngA.Show();
        }

        private void button_circulation_Click(object sender, EventArgs e)
        {
            selectionButton(button_circulation);
            ManageCirculationForm mngCF = new ManageCirculationForm();
            mngCF.Show();
        }

        public void selectionButton(Button btn)
        {
            foreach(Control control in panel_menu.Controls)
            {
               if (control.GetType() == typeof(Button))
               {
                    Button button = (Button)control;
                    button.BackColor = System.Drawing.Color.FromArgb(46, 49, 49);
               }
            }
            btn.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
        }
    }
}
