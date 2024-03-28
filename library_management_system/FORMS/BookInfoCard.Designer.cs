namespace library_management_system.FORMS
{
    partial class BookInfoCard
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
            this.pictureBox_cover = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_isbn = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_publisher = new System.Windows.Forms.Label();
            this.label_dateAdded = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_cover
            // 
            this.pictureBox_cover.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_cover.ImageLocation = "";
            this.pictureBox_cover.Location = new System.Drawing.Point(16, 12);
            this.pictureBox_cover.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_cover.Name = "pictureBox_cover";
            this.pictureBox_cover.Size = new System.Drawing.Size(289, 320);
            this.pictureBox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cover.TabIndex = 37;
            this.pictureBox_cover.TabStop = false;
     
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(320, 79);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(102, 29);
            this.label_title.TabIndex = 38;
            this.label_title.Text = "Tiêu đề:";
            // 
            // label_isbn
            // 
            this.label_isbn.AutoSize = true;
            this.label_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isbn.ForeColor = System.Drawing.Color.White;
            this.label_isbn.Location = new System.Drawing.Point(320, 26);
            this.label_isbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(75, 29);
            this.label_isbn.TabIndex = 39;
            this.label_isbn.Text = "ISBN:";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.Color.White;
            this.label_author.Location = new System.Drawing.Point(320, 132);
            this.label_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(99, 29);
            this.label_author.TabIndex = 40;
            this.label_author.Text = "Tác giả:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.ForeColor = System.Drawing.Color.White;
            this.label_genre.Location = new System.Drawing.Point(320, 185);
            this.label_genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(107, 29);
            this.label_genre.TabIndex = 41;
            this.label_genre.Text = "Thể loại:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.Color.White;
            this.label_quantity.Location = new System.Drawing.Point(320, 238);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(115, 29);
            this.label_quantity.TabIndex = 42;
            this.label_quantity.Text = "Số lượng:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.White;
            this.label_price.Location = new System.Drawing.Point(320, 290);
            this.label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(56, 29);
            this.label_price.TabIndex = 43;
            this.label_price.Text = "Giá:";
            // 
            // label_publisher
            // 
            this.label_publisher.AutoSize = true;
            this.label_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_publisher.ForeColor = System.Drawing.Color.White;
            this.label_publisher.Location = new System.Drawing.Point(320, 343);
            this.label_publisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_publisher.Name = "label_publisher";
            this.label_publisher.Size = new System.Drawing.Size(170, 29);
            this.label_publisher.TabIndex = 44;
            this.label_publisher.Text = "Ngày xuất bản:";
            // 
            // label_dateAdded
            // 
            this.label_dateAdded.AutoSize = true;
            this.label_dateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateAdded.ForeColor = System.Drawing.Color.White;
            this.label_dateAdded.Location = new System.Drawing.Point(320, 396);
            this.label_dateAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dateAdded.Name = "label_dateAdded";
            this.label_dateAdded.Size = new System.Drawing.Size(134, 29);
            this.label_dateAdded.TabIndex = 45;
            this.label_dateAdded.Text = "Ngày nhập:";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Enabled = false;
            this.richTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_description.Location = new System.Drawing.Point(16, 340);
            this.richTextBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.ReadOnly = true;
            this.richTextBox_description.Size = new System.Drawing.Size(288, 117);
            this.richTextBox_description.TabIndex = 46;
            this.richTextBox_description.Text = "";
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Yellow;
            this.label_close.Location = new System.Drawing.Point(667, 1);
            this.label_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(35, 28);
            this.label_close.TabIndex = 47;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.BackColor = System.Drawing.Color.Lime;
            this.label_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty.ForeColor = System.Drawing.Color.White;
            this.label_qty.Location = new System.Drawing.Point(439, 238);
            this.label_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(52, 29);
            this.label_qty.TabIndex = 48;
            this.label_qty.Text = "100";
            // 
            // BookInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(703, 462);
            this.Controls.Add(this.label_qty);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.label_dateAdded);
            this.Controls.Add(this.label_publisher);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_isbn);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_cover);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoCard";
            this.Load += new System.EventHandler(this.BookInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_cover;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_isbn;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_publisher;
        private System.Windows.Forms.Label label_dateAdded;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_qty;
    }
}