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
    public partial class ManageGenres_Form : Form
    {
        public ManageGenres_Form()
        {
            InitializeComponent();
        }

        CLASSES.GENRES genre = new CLASSES.GENRES();

        private void ManageGenres_Form_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            dataGridView_genres.DataSource = genre.GenresList();

            dataGridView_genres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial",14, FontStyle.Bold);
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView_genres.EnableHeadersVisualStyles = false;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Nhập tên thể loại", "Thể loại trống",  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }
            else
            {
                if (genre.addGenre(name))
                {
                    MessageBox.Show("Nhập Thành công", "Thể loại mới", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView_genres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Nhập Thất bại", "Nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

           try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string name = textBox_name.Text;

                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Nhập tên thể loại", "Thể loại trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (genre.editGenre(id, name))
                    {
                        MessageBox.Show("Cập nhật Thành công", "Thể loại thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView_genres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Thất bại", "Thay đổi lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Không tồn tại ID");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                
                    if (genre.removeGenre(id))
                    {
                        MessageBox.Show("Xóa Thành công", "Xóa thể loại", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox_id.Text = "";
                        textBox_name.Text = "";

                        dataGridView_genres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất bại", "Xóa lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không tồn tại ID");
            }
        }

        private void dataGridView_genres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_genres.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_genres.CurrentRow.Cells[1].Value.ToString();
        }

        
    }
}
