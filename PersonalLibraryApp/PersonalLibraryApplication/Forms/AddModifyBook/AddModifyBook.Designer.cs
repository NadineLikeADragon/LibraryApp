namespace PersonalLibraryApplication.Forms.AddModifyBook
{
    partial class AddModifyBook
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
            groupBox1 = new GroupBox();
            txtDatePicked = new TextBox();
            lbdate = new Label();
            txtSurname = new TextBox();
            txtTitle = new TextBox();
            txtBookId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            rtxtDescription = new RichTextBox();
            btnAddBook = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDatePicked);
            groupBox1.Controls.Add(lbdate);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 5);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(315, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtDatePicked
            // 
            txtDatePicked.Location = new Point(145, 249);
            txtDatePicked.Margin = new Padding(4, 5, 4, 5);
            txtDatePicked.Name = "txtDatePicked";
            txtDatePicked.Size = new Size(132, 27);
            txtDatePicked.TabIndex = 7;
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Location = new Point(25, 254);
            lbdate.Margin = new Padding(4, 0, 4, 0);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(93, 20);
            lbdate.TabIndex = 6;
            lbdate.Text = "Date Bought";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(145, 185);
            txtSurname.Margin = new Padding(4, 5, 4, 5);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(132, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(145, 108);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(132, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(145, 45);
            txtBookId.Margin = new Padding(4, 5, 4, 5);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(132, 27);
            txtBookId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 314);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 1;
            label4.Text = "Book Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(95, 352);
            rtxtDescription.Margin = new Padding(4, 5, 4, 5);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(313, 118);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(95, 523);
            btnAddBook.Margin = new Padding(4, 5, 4, 5);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 35);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(309, 523);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddModifyBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(507, 594);
            Controls.Add(btnCancel);
            Controls.Add(btnAddBook);
            Controls.Add(rtxtDescription);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddModifyBook";
            Text = "V";
            Load += AddModifyBook_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.TextBox txtDatePicked;
    }
}