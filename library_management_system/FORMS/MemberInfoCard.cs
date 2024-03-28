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
    public partial class MemberInfoCard : Form
    {
        int memberId;
        public MemberInfoCard(int id)
        {
            InitializeComponent();
            memberId = id;
        }

        CLASSES.MEMBER member = new CLASSES.MEMBER();

        private void MemberInfoCard_Load(object sender, EventArgs e)
        {
            try
            {
                DataRow data = member.getMemberById(memberId);

                label_id.Text = data["id"].ToString();
                label_fullName.Text = data["name"].ToString();
                label_gender.Text = data["gender"].ToString();
                label_phone.Text = data["phone"].ToString();
                label_email.Text = data["email"].ToString();

                // display the member picture
                byte[] cover = (byte[])data["picture"];
                MemoryStream ms = new MemoryStream(cover);
                pictureBox_picture.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty Card: " + ex.Message);
            }
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
