namespace library_management_system.FORMS
{
    partial class MemberInfoCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_close = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_fullName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.pictureBox_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Yellow;
            this.label_close.Location = new System.Drawing.Point(715, 0);
            this.label_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(35, 28);
            this.label_close.TabIndex = 58;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(320, 234);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(80, 29);
            this.label_email.TabIndex = 53;
            this.label_email.Text = "Email:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(320, 181);
            this.label_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(160, 29);
            this.label_phone.TabIndex = 52;
            this.label_phone.Text = "Số điện thoại:";
            // 
            // label_fullName
            // 
            this.label_fullName.AutoSize = true;
            this.label_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fullName.ForeColor = System.Drawing.Color.White;
            this.label_fullName.Location = new System.Drawing.Point(320, 75);
            this.label_fullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.Size = new System.Drawing.Size(119, 29);
            this.label_fullName.TabIndex = 51;
            this.label_fullName.Text = "Họ và tên:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(320, 22);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 29);
            this.label_id.TabIndex = 50;
            this.label_id.Text = "ID:";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(320, 128);
            this.label_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(107, 29);
            this.label_gender.TabIndex = 49;
            this.label_gender.Text = "Thể loại:";
            // 
            // pictureBox_picture
            // 
            this.pictureBox_picture.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_picture.ImageLocation = "";
            this.pictureBox_picture.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_picture.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_picture.Name = "pictureBox_picture";
            this.pictureBox_picture.Size = new System.Drawing.Size(289, 255);
            this.pictureBox_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_picture.TabIndex = 48;
            this.pictureBox_picture.TabStop = false;
    
            // 
            // MemberInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(752, 292);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_fullName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.pictureBox_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfoCard";
            this.Load += new System.EventHandler(this.MemberInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_fullName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.PictureBox pictureBox_picture;
    }
}
