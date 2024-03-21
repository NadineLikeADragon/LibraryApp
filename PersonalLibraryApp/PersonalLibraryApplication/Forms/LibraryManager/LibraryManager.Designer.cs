namespace PersonalLibraryApplication.Forms.LibraryManager
{
    partial class LibraryManager
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
            label1 = new Label();
            dgvReadBooks = new DataGridView();
            panel2 = new Panel();
            dataGridView4 = new DataGridView();
            dgvWishlistBooks = new DataGridView();
            label2 = new Label();
            rbVADOwned = new RadioButton();
            rbVADRead = new RadioButton();
            rbVADWishlist = new RadioButton();
            groupBox1 = new GroupBox();
            rbVADWishListToOwned = new RadioButton();
            rbVADLoans = new RadioButton();
            btnAddOwned = new Button();
            btnAddRead = new Button();
            btnAddWishlist = new Button();
            dgvOwnedBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReadBooks).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWishlistBooks).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnedBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(428, 34);
            label1.Name = "label1";
            label1.Size = new Size(297, 33);
            label1.TabIndex = 0;
            label1.Text = "Personal Library Manager";
            // 
            // dgvReadBooks
            // 
            dgvReadBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReadBooks.Location = new Point(10, 451);
            dgvReadBooks.Margin = new Padding(3, 2, 3, 2);
            dgvReadBooks.Name = "dgvReadBooks";
            dgvReadBooks.RowHeadersWidth = 51;
            dgvReadBooks.RowTemplate.Height = 24;
            dgvReadBooks.Size = new Size(1064, 122);
            dgvReadBooks.TabIndex = 5;
            dgvReadBooks.CellContentClick += dgvReadBooks_CellContentClick;
            dgvReadBooks.VisibleChanged += rbVADRead_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView4);
            panel2.Location = new Point(1093, 644);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 124);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(17, 124);
            dataGridView4.Margin = new Padding(3, 2, 3, 2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 24;
            dataGridView4.Size = new Size(172, 109);
            dataGridView4.TabIndex = 1;
            // 
            // dgvWishlistBooks
            // 
            dgvWishlistBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWishlistBooks.Location = new Point(10, 586);
            dgvWishlistBooks.Margin = new Padding(3, 2, 3, 2);
            dgvWishlistBooks.Name = "dgvWishlistBooks";
            dgvWishlistBooks.RowHeadersWidth = 51;
            dgvWishlistBooks.RowTemplate.Height = 24;
            dgvWishlistBooks.Size = new Size(1064, 120);
            dgvWishlistBooks.TabIndex = 1;
            dgvWishlistBooks.CellContentClick += dgvWishlistBooks_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(-4, 13);
            label2.Name = "label2";
            label2.Size = new Size(173, 22);
            label2.TabIndex = 4;
            label2.Text = "Please select an option: ";
            // 
            // rbVADOwned
            // 
            rbVADOwned.AutoSize = true;
            rbVADOwned.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADOwned.ForeColor = SystemColors.ActiveCaptionText;
            rbVADOwned.Location = new Point(4, 47);
            rbVADOwned.Margin = new Padding(3, 2, 3, 2);
            rbVADOwned.Name = "rbVADOwned";
            rbVADOwned.Size = new Size(278, 23);
            rbVADOwned.TabIndex = 5;
            rbVADOwned.TabStop = true;
            rbVADOwned.Text = "View, Add, Delete Current Owned Books";
            rbVADOwned.UseVisualStyleBackColor = true;
            rbVADOwned.CheckedChanged += rbVADOwned_CheckedChanged;
            // 
            // rbVADRead
            // 
            rbVADRead.AutoSize = true;
            rbVADRead.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADRead.ForeColor = SystemColors.ActiveCaptionText;
            rbVADRead.Location = new Point(4, 88);
            rbVADRead.Margin = new Padding(3, 2, 3, 2);
            rbVADRead.Name = "rbVADRead";
            rbVADRead.Size = new Size(254, 23);
            rbVADRead.TabIndex = 6;
            rbVADRead.TabStop = true;
            rbVADRead.Text = "View Add, Delete Books You've Read";
            rbVADRead.UseVisualStyleBackColor = true;
            rbVADRead.CheckedChanged += rbVADRead_CheckedChanged;
            // 
            // rbVADWishlist
            // 
            rbVADWishlist.AutoSize = true;
            rbVADWishlist.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADWishlist.ForeColor = SystemColors.ActiveCaptionText;
            rbVADWishlist.Location = new Point(4, 133);
            rbVADWishlist.Margin = new Padding(3, 2, 3, 2);
            rbVADWishlist.Name = "rbVADWishlist";
            rbVADWishlist.Size = new Size(224, 23);
            rbVADWishlist.TabIndex = 7;
            rbVADWishlist.TabStop = true;
            rbVADWishlist.Text = "ViewAdd, Delete  Wishlist Items";
            rbVADWishlist.UseVisualStyleBackColor = true;
            rbVADWishlist.CheckedChanged += rbVADWishlist_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rbVADWishListToOwned);
            groupBox1.Controls.Add(rbVADLoans);
            groupBox1.Controls.Add(rbVADOwned);
            groupBox1.Controls.Add(rbVADRead);
            groupBox1.Controls.Add(rbVADWishlist);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(43, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(346, 250);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // rbVADWishListToOwned
            // 
            rbVADWishListToOwned.AutoSize = true;
            rbVADWishListToOwned.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADWishListToOwned.ForeColor = SystemColors.ActiveCaptionText;
            rbVADWishListToOwned.Location = new Point(4, 215);
            rbVADWishListToOwned.Margin = new Padding(3, 2, 3, 2);
            rbVADWishListToOwned.Name = "rbVADWishListToOwned";
            rbVADWishListToOwned.Size = new Size(285, 23);
            rbVADWishListToOwned.TabIndex = 6;
            rbVADWishListToOwned.TabStop = true;
            rbVADWishListToOwned.Text = "Switch Books from WishList to Owned List ";
            rbVADWishListToOwned.UseVisualStyleBackColor = true;
            // 
            // rbVADLoans
            // 
            rbVADLoans.AutoSize = true;
            rbVADLoans.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADLoans.ForeColor = SystemColors.ActiveCaptionText;
            rbVADLoans.Location = new Point(4, 174);
            rbVADLoans.Margin = new Padding(3, 2, 3, 2);
            rbVADLoans.Name = "rbVADLoans";
            rbVADLoans.Size = new Size(133, 23);
            rbVADLoans.TabIndex = 5;
            rbVADLoans.TabStop = true;
            rbVADLoans.Text = "Track Book Loans";
            rbVADLoans.UseVisualStyleBackColor = true;
            rbVADLoans.CheckedChanged += rbVADLoans_CheckedChanged;
            // 
            // btnAddOwned
            // 
            btnAddOwned.Location = new Point(1093, 341);
            btnAddOwned.Margin = new Padding(3, 2, 3, 2);
            btnAddOwned.Name = "btnAddOwned";
            btnAddOwned.Size = new Size(119, 46);
            btnAddOwned.TabIndex = 12;
            btnAddOwned.Text = "Add to Owned Books";
            btnAddOwned.UseVisualStyleBackColor = true;
            btnAddOwned.Visible = false;
            btnAddOwned.Click += btnAddOwned_Click;
            // 
            // btnAddRead
            // 
            btnAddRead.Location = new Point(1093, 433);
            btnAddRead.Margin = new Padding(3, 2, 3, 2);
            btnAddRead.Name = "btnAddRead";
            btnAddRead.Size = new Size(119, 46);
            btnAddRead.TabIndex = 13;
            btnAddRead.Text = "Add to Read Books";
            btnAddRead.UseVisualStyleBackColor = true;
            btnAddRead.Visible = false;
            btnAddRead.Click += btnAddRead_Click;
            // 
            // btnAddWishlist
            // 
            btnAddWishlist.Location = new Point(1093, 508);
            btnAddWishlist.Margin = new Padding(3, 2, 3, 2);
            btnAddWishlist.Name = "btnAddWishlist";
            btnAddWishlist.Size = new Size(119, 46);
            btnAddWishlist.TabIndex = 14;
            btnAddWishlist.Text = "Add to WishList Books";
            btnAddWishlist.UseVisualStyleBackColor = true;
            btnAddWishlist.Visible = false;
            btnAddWishlist.Click += btnAddWishlist_Click;
            // 
            // dgvOwnedBooks
            // 
            dgvOwnedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnedBooks.Location = new Point(10, 297);
            dgvOwnedBooks.Margin = new Padding(3, 2, 3, 2);
            dgvOwnedBooks.Name = "dgvOwnedBooks";
            dgvOwnedBooks.RowHeadersWidth = 51;
            dgvOwnedBooks.RowTemplate.Height = 24;
            dgvOwnedBooks.Size = new Size(1064, 140);
            dgvOwnedBooks.TabIndex = 0;
            dgvOwnedBooks.CellContentClick += dgvOwnedBooks_CellContentClick;
            // 
            // LibraryManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1292, 661);
            Controls.Add(dgvWishlistBooks);
            Controls.Add(dgvReadBooks);
            Controls.Add(dgvOwnedBooks);
            Controls.Add(btnAddWishlist);
            Controls.Add(btnAddRead);
            Controls.Add(btnAddOwned);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LibraryManager";
            Text = "Form1";
            Load += LibraryManager_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReadBooks).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWishlistBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private DataGridView dgvWishlistBooks;
        private DataGridView dgvReadBooks;
        private DataGridView dataGridView4;
        private Label label2;
        private RadioButton rbVADOwned;
        private RadioButton rbVADRead;
        private RadioButton rbVADWishlist;
        private GroupBox groupBox1;
        private RadioButton rbVADLoans;
        private RadioButton rbVADWishListToOwned;
        private Button btnAddOwned;
        private Button btnAddRead;
        private Button btnAddWishlist;
        private DataGridView dgvOwnedBooks;
    }
}

