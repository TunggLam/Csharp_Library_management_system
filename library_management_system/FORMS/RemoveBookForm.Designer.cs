namespace library_management_system.FORMS
{
    partial class RemoveBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_BookId = new System.Windows.Forms.NumericUpDown();
            this.button_RemoveBook = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xóa sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.numericUpDown_BookId);
            this.panel1.Controls.Add(this.button_RemoveBook);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Location = new System.Drawing.Point(1, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 178);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown_BookId
            // 
            this.numericUpDown_BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BookId.Location = new System.Drawing.Point(296, 26);
            this.numericUpDown_BookId.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_BookId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_BookId.Name = "numericUpDown_BookId";
            this.numericUpDown_BookId.Size = new System.Drawing.Size(225, 37);
            this.numericUpDown_BookId.TabIndex = 56;
            // 
            // button_RemoveBook
            // 
            this.button_RemoveBook.BackColor = System.Drawing.Color.Red;
            this.button_RemoveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RemoveBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveBook.ForeColor = System.Drawing.Color.White;
            this.button_RemoveBook.Location = new System.Drawing.Point(68, 103);
            this.button_RemoveBook.Margin = new System.Windows.Forms.Padding(4);
            this.button_RemoveBook.Name = "button_RemoveBook";
            this.button_RemoveBook.Size = new System.Drawing.Size(453, 52);
            this.button_RemoveBook.TabIndex = 55;
            this.button_RemoveBook.Text = "Xóa sách";
            this.button_RemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_RemoveBook.UseVisualStyleBackColor = false;
            this.button_RemoveBook.Click += new System.EventHandler(this.button_RemoveBook_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Yellow;
            this.label34.Location = new System.Drawing.Point(63, 30);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(162, 29);
            this.label34.TabIndex = 53;
            this.label34.Text = "Nhập ID sách:";
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(561, 0);
            this.label_close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(35, 28);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // RemoveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(595, 251);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.NumericUpDown numericUpDown_BookId;
        private System.Windows.Forms.Button button_RemoveBook;
        private System.Windows.Forms.Label label34;
    }
}