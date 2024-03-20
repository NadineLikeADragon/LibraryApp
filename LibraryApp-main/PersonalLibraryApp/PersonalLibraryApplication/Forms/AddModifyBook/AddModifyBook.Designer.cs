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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatePicked = new System.Windows.Forms.TextBox();
            this.lbdate = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatePicked);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDatePicked
            // 
            this.txtDatePicked.Location = new System.Drawing.Point(109, 162);
            this.txtDatePicked.Name = "txtDatePicked";
            this.txtDatePicked.Size = new System.Drawing.Size(100, 20);
            this.txtDatePicked.TabIndex = 7;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(19, 165);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(67, 13);
            this.lbdate.TabIndex = 6;
            this.lbdate.Text = "Date Bought";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(109, 120);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(109, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(109, 29);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(100, 20);
            this.txtBookId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authors Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(71, 229);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(236, 78);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(71, 340);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(380, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddModifyBook";
            this.Text = "V";
            this.Load += new System.EventHandler(this.AddModifyBook_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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