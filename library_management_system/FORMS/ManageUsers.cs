using library_management_system.CLASSES;
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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        CLASSES.USERS users = new CLASSES.USERS();
        

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string re_password = textBox_re_password.Text.Trim();
            string userType = "user";
            if (checkBox_setToAdmin.Checked)
            {
                userType = "admin";
            }

            if (verify())
            {
                if (users.isUssernameExists(username, 00))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Tên tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (re_password.Equals(password))
                    {
                        users.addUser(fname, lname, username, password, userType);
                        MessageBox.Show("Thêm mới thành công", "Tài khoản mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_users.DataSource = users.usersList();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập trùng khớp mật khẩu", "Thêm mới thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                             
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thêm mới thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {   
            int id;
            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string re_password = textBox_re_password.Text.Trim();
            string userType = "user";
            if (checkBox_setToAdmin.Checked)
            {
                userType = "admin";
            }

            if (verify())
            {
                try
                {
                    id = Convert.ToInt32(textBox_id.Text);

                    if (users.isUssernameExists(username, id))
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại", "Tên tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                    {
                        if (re_password.Equals(password))
                        {
                            users.editUser(id, fname, lname, username, password, userType);
                            MessageBox.Show("Cập nhật thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView_users.DataSource = users.usersList();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập trùng khớp mật khẩu", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }                  
                } catch(Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn id cần cập nhật trong bảng", "Cập nhật thất bại" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần cập nhật", "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                if (MessageBox.Show("Bạn có thực sự muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (users.removeUser(id))
                    {
                        MessageBox.Show("Dữ liệu tài khoản đã được xóa thành công", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_username.Text = "";
                        textBox_password.Text = "";
                        textBox_re_password.Text = "";
                        checkBox_setToAdmin.Checked = false;


                        dataGridView_users.DataSource = users.usersList();
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu tài khoản chưa được xóa", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID tài khoản không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_users.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_users.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_users.CurrentRow.Cells[2].Value.ToString();
            textBox_username.Text = dataGridView_users.CurrentRow.Cells[3].Value.ToString();
            textBox_password.Text = dataGridView_users.CurrentRow.Cells[4].Value.ToString();
            textBox_re_password.Text = dataGridView_users.CurrentRow.Cells[4].Value.ToString();
            string userType = dataGridView_users.CurrentRow.Cells[5].Value.ToString();

            if (userType.Equals("admin"))
            {
                checkBox_setToAdmin.Checked = true;
            }else
            {
                checkBox_setToAdmin.Checked= false;
            }
        }

        public Boolean verify()
        {
            string fname = textBox_fname.Text.Trim();
            string lname = textBox_lname.Text.Trim();
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();
            string re_password = textBox_re_password.Text.Trim();

            if(fname.Equals("") || lname.Equals("") || username.Equals("") || password.Equals("") || re_password.Equals(""))
            {
                return false;
            }          
            else
            {
                return true;
            }
            
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            dataGridView_users.DataSource = users.usersList();

            dataGridView_users.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_users.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
            dataGridView_users.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView_users.EnableHeadersVisualStyles = false;
        }
    }
}
