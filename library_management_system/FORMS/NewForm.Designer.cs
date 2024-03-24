namespace library_management_system.FORMS
{
    partial class NewForm
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
            this.listView_books = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_books
            // 
            this.listView_books.Location = new System.Drawing.Point(12, 24);
            this.listView_books.Name = "listView_books";
            this.listView_books.Size = new System.Drawing.Size(531, 343);
            this.listView_books.TabIndex = 0;
            this.listView_books.UseCompatibleStateImageBehavior = false;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 398);
            this.Controls.Add(this.listView_books);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_books;
    }
}