using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_management_system.FORMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("../../IMAGES/user.jpg");
            pictureBox_Pass.Image = Image.FromFile("../../IMAGES/lock.jpg");
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Dashboard_Form dashF = null;
        public Login_Form(Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }
        private void button_login_Click(object sender, EventArgs e)
        {

            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username`=@usn AND `password`=@pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 ) {
                if (table.Rows[0][5].ToString().Equals("owner"))
                {
                    dashF.Enabled = true;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("admin"))
                {
                    dashF.Enabled = true;
                    dashF.button_users.Enabled = false;
                    this.Close();
                }
                else if (table.Rows[0][5].ToString().Equals("user"))
                {
                    dashF.Enabled = true;
                    dashF.button_circulation.Enabled = false;
                    dashF.button_users.Enabled=false;
                    this.Close();
                }
            } else {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập tên người dùng của bạn để đăng nhập","Tài khoản bỏ trống",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập mật khẩu của bạn để đăng nhập", "Mật khẩu bỏ trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Không tồn tại tài khoản hoặc mật khẩu", "Không có dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
