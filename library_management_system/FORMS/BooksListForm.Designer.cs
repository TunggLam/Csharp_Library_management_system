namespace library_management_system.FORMS
{
    partial class BooksListForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_author = new System.Windows.Forms.Label();
            this.listView_books = new System.Windows.Forms.ListView();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList_BooksCovers = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.listView_books);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 646);
            this.panel1.TabIndex = 1;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.Color.White;
            this.label_author.Location = new System.Drawing.Point(3, 91);
            this.label_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(376, 31);
            this.label_author.TabIndex = 3;
            this.label_author.Text = "books by: the author full name";
            // 
            // listView_books
            // 
            this.listView_books.BackColor = System.Drawing.Color.Gray;
            this.listView_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_books.ForeColor = System.Drawing.Color.White;
            this.listView_books.HideSelection = false;
            this.listView_books.Location = new System.Drawing.Point(7, 126);
            this.listView_books.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_books.Name = "listView_books";
            this.listView_books.Size = new System.Drawing.Size(460, 516);
            this.listView_books.TabIndex = 2;
            this.listView_books.UseCompatibleStateImageBehavior = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(436, 4);
            this.label_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(35, 28);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sách của tác giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList_BooksCovers
            // 
            this.imageList_BooksCovers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_BooksCovers.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_BooksCovers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BooksListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksListForm";
            this.Load += new System.EventHandler(this.BooksListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.ListView listView_books;
        private System.Windows.Forms.ImageList imageList_BooksCovers;

    }
}
