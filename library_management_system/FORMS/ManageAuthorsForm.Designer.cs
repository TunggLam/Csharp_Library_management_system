namespace library_management_system.FORMS
{
    partial class ManageAuthorsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox_bio = new System.Windows.Forms.RichTextBox();
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_education = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_exportAuthors = new System.Windows.Forms.Button();
            this.label_authorsCount = new System.Windows.Forms.Label();
            this.button_Show_Author_Books = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 575);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.richTextBox_bio);
            this.panel4.Controls.Add(this.dataGridView_authors);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_education);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_lname);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBox_fname);
            this.panel4.Controls.Add(this.textBox_id);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label_ID);
            this.panel4.Location = new System.Drawing.Point(191, 95);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1295, 476);
            this.panel4.TabIndex = 6;
            // 
            // richTextBox_bio
            // 
            this.richTextBox_bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_bio.Location = new System.Drawing.Point(164, 290);
            this.richTextBox_bio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_bio.Name = "richTextBox_bio";
            this.richTextBox_bio.Size = new System.Drawing.Size(337, 157);
            this.richTextBox_bio.TabIndex = 15;
            this.richTextBox_bio.Text = "";
            // 
            // dataGridView_authors
            // 
            this.dataGridView_authors.AllowUserToAddRows = false;
            this.dataGridView_authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_authors.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authors.GridColor = System.Drawing.Color.Black;
            this.dataGridView_authors.Location = new System.Drawing.Point(523, 50);
            this.dataGridView_authors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.RowHeadersWidth = 51;
            this.dataGridView_authors.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.YellowGreen;
            this.dataGridView_authors.Size = new System.Drawing.Size(760, 398);
            this.dataGridView_authors.TabIndex = 14;
            this.dataGridView_authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_authors_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới thiệu:";
            // 
            // textBox_education
            // 
            this.textBox_education.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_education.Location = new System.Drawing.Point(167, 229);
            this.textBox_education.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_education.Name = "textBox_education";
            this.textBox_education.Size = new System.Drawing.Size(335, 34);
            this.textBox_education.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giáo dục:";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(167, 170);
            this.textBox_lname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(335, 34);
            this.textBox_lname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên chính:";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(167, 107);
            this.textBox_fname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(335, 34);
            this.textBox_fname.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(167, 47);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(145, 34);
            this.textBox_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và đệm:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(113, 50);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(42, 29);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.button_exportAuthors);
            this.panel3.Controls.Add(this.label_authorsCount);
            this.panel3.Controls.Add(this.button_Show_Author_Books);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 483);
            this.panel3.TabIndex = 5;
            // 
            // button_exportAuthors
            // 
            this.button_exportAuthors.BackColor = System.Drawing.Color.White;
            this.button_exportAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exportAuthors.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_exportAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exportAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportAuthors.Location = new System.Drawing.Point(3, 326);
            this.button_exportAuthors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_exportAuthors.Name = "button_exportAuthors";
            this.button_exportAuthors.Size = new System.Drawing.Size(177, 96);
            this.button_exportAuthors.TabIndex = 54;
            this.button_exportAuthors.Text = " Xuất Txt File";
            this.button_exportAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_exportAuthors.UseVisualStyleBackColor = false;
            this.button_exportAuthors.Click += new System.EventHandler(this.button_exportAuthors_Click);
            // 
            // label_authorsCount
            // 
            this.label_authorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authorsCount.ForeColor = System.Drawing.Color.Gold;
            this.label_authorsCount.Location = new System.Drawing.Point(4, 433);
            this.label_authorsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_authorsCount.Name = "label_authorsCount";
            this.label_authorsCount.Size = new System.Drawing.Size(175, 49);
            this.label_authorsCount.TabIndex = 53;
            this.label_authorsCount.Text = "9999 Tác giả";
            this.label_authorsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Show_Author_Books
            // 
            this.button_Show_Author_Books.BackColor = System.Drawing.Color.White;
            this.button_Show_Author_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Show_Author_Books.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Show_Author_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Author_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Author_Books.Location = new System.Drawing.Point(3, 226);
            this.button_Show_Author_Books.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Show_Author_Books.Name = "button_Show_Author_Books";
            this.button_Show_Author_Books.Size = new System.Drawing.Size(177, 92);
            this.button_Show_Author_Books.TabIndex = 9;
            this.button_Show_Author_Books.Text = " Hiện sách của tác giả";
            this.button_Show_Author_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Show_Author_Books.UseVisualStyleBackColor = false;
            this.button_Show_Author_Books.Click += new System.EventHandler(this.button_Show_Author_Books_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(4, 165);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(177, 54);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = " Xóa";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(5, 103);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(177, 54);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = " Sửa";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(4, 42);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(177, 54);
            this.button_add.TabIndex = 6;
            this.button_add.Text = " Thêm mới";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1489, 92);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(171)))), ((int)(((byte)(53)))));
            this.pictureBox1.ImageLocation = "../../IMAGES/typewriter.png";
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(1453, 1);
            this.label_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(35, 28);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(96, 0);
            this.label_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(229, 92);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "Tác giả";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAutorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_education;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_authors;
        private System.Windows.Forms.RichTextBox richTextBox_bio;
        private System.Windows.Forms.Button button_Show_Author_Books;
        private System.Windows.Forms.Label label_authorsCount;
        private System.Windows.Forms.Button button_exportAuthors;
    }
}