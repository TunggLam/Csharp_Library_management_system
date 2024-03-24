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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library_management_system.FORMS
{
    public partial class ManageMemberForm : Form
    {
        public ManageMemberForm()
        {
            InitializeComponent();
        }

        CLASSES.MEMBER member = new CLASSES.MEMBER();

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            string gender = "Nam";

            if (radioButton2.Checked)
            {
                gender = "Nữ";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_cover.Image.Save(ms, pictureBox_cover.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            if (name.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Bạn cần điền thông tin thành viên", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (member.addMember(name, gender, phone, email, profile_picture))
                {
                    MessageBox.Show("Thành viên mới đã được thêm", "New Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thành viên mới chưa được thêm", "New_Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/add.png");
            button_edit.Image = Image.FromFile("../../IMAGES/edit.png");
            button_delete.Image = Image.FromFile("../../IMAGES/delete.png");
            button_selectCover.Image = Image.FromFile("../../IMAGES/upload.png");

            dataGridView_members.DataSource = member.MembersList(false);

            dataGridView_members.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_members.EnableHeadersVisualStyles = false;

            dataGridView_members.RowTemplate.Height = 50;
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_members.Columns[5];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }


        private void pictureBox_cover_Click_1(object sender, EventArgs e)
        {
            pictureBox_cover.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button_selectCover_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_cover.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_edit_Click_1(object sender, EventArgs e)
        {
            int id;
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string email = textBox4.Text;
            string gender = "Nam";

            if (radioButton2.Checked)
            {
                gender = "Nữ";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_cover.Image.Save(ms, pictureBox_cover.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            if (!textBox1.Text.Trim().Equals(""))
            {
                if (name.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn cần điền thông tin thành viên", "Empty data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id = Convert.ToInt32(textBox1.Text);

                    if (member.editMember(id, name, gender, phone, email, profile_picture))
                    {
                        MessageBox.Show("Chỉnh sửa thành công", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Thành viên chưa được chỉnh sửa", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên ở bảng trước", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            int id;

            if (!textBox1.Text.Trim().Equals(""))
            {
                id = Convert.ToInt32(textBox1.Text);

                if (member.removeMember(id))
                {
                    {
                        MessageBox.Show("Xóa thành công ", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên ở bảng trước", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;
            textBox3.Text = "";
            textBox4.Text = "";
            pictureBox_cover.ImageLocation = "../../IMAGES/avatar.png";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView_members.DataSource = member.MembersList(false);
        }

        private void dataGridView_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView_members.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView_members.CurrentRow.Cells[1].Value.ToString();
            string gender = dataGridView_members.CurrentRow.Cells[2].Value.ToString();
            if (gender.Equals("Nam"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox3.Text = dataGridView_members.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView_members.CurrentRow.Cells[4].Value.ToString();

            byte[] pic = (byte[])dataGridView_members.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(pic);
            pictureBox_cover.Image = Image.FromStream(ms);
        }
    }
}
