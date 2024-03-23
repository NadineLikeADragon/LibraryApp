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
            dgvBooks = new DataGridView();
            btnAddLoan = new Button();
            btnSwaptoOwned = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(489, 45);
            label1.Name = "label1";
            label1.Size = new Size(378, 44);
            label1.TabIndex = 0;
            label1.Text = "Personal Library Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(-5, 17);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 4;
            label2.Text = "Please select an option: ";
            // 
            // rbVADOwned
            // 
            rbVADOwned.AutoSize = true;
            rbVADOwned.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADOwned.ForeColor = SystemColors.ActiveCaptionText;
            rbVADOwned.Location = new Point(5, 63);
            rbVADOwned.Name = "rbVADOwned";
            rbVADOwned.Size = new Size(339, 27);
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
            rbVADRead.Location = new Point(5, 117);
            rbVADRead.Name = "rbVADRead";
            rbVADRead.Size = new Size(312, 27);
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
            rbVADWishlist.Location = new Point(5, 177);
            rbVADWishlist.Name = "rbVADWishlist";
            rbVADWishlist.Size = new Size(273, 27);
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
            groupBox1.Location = new Point(49, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 333);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // rbVADWishListToOwned
            // 
            rbVADWishListToOwned.AutoSize = true;
            rbVADWishListToOwned.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADWishListToOwned.ForeColor = SystemColors.ActiveCaptionText;
            rbVADWishListToOwned.Location = new Point(5, 287);
            rbVADWishListToOwned.Name = "rbVADWishListToOwned";
            rbVADWishListToOwned.Size = new Size(349, 27);
            rbVADWishListToOwned.TabIndex = 6;
            rbVADWishListToOwned.TabStop = true;
            rbVADWishListToOwned.Text = "Switch Books from WishList to Owned List ";
            rbVADWishListToOwned.UseVisualStyleBackColor = true;
            rbVADWishListToOwned.CheckedChanged += rbVADWishListToOwned_CheckedChanged;
            // 
            // rbVADLoans
            // 
            rbVADLoans.AutoSize = true;
            rbVADLoans.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbVADLoans.ForeColor = SystemColors.ActiveCaptionText;
            rbVADLoans.Location = new Point(5, 232);
            rbVADLoans.Name = "rbVADLoans";
            rbVADLoans.Size = new Size(163, 27);
            rbVADLoans.TabIndex = 5;
            rbVADLoans.TabStop = true;
            rbVADLoans.Text = "Track Book Loans";
            rbVADLoans.UseVisualStyleBackColor = true;
            rbVADLoans.CheckedChanged += rbVADLoans_CheckedChanged;
            // 
            // btnAddOwned
            // 
            btnAddOwned.Enabled = false;
            btnAddOwned.Location = new Point(465, 284);
            btnAddOwned.Name = "btnAddOwned";
            btnAddOwned.Size = new Size(136, 61);
            btnAddOwned.TabIndex = 12;
            btnAddOwned.Text = "Add to Owned Books";
            btnAddOwned.UseVisualStyleBackColor = true;
            btnAddOwned.Click += btnAddOwned_Click;
            // 
            // btnAddRead
            // 
            btnAddRead.Enabled = false;
            btnAddRead.Location = new Point(625, 284);
            btnAddRead.Name = "btnAddRead";
            btnAddRead.Size = new Size(136, 61);
            btnAddRead.TabIndex = 13;
            btnAddRead.Text = "Add to Read Books";
            btnAddRead.UseVisualStyleBackColor = true;
            btnAddRead.Click += btnAddRead_Click;
            // 
            // btnAddWishlist
            // 
            btnAddWishlist.Enabled = false;
            btnAddWishlist.Location = new Point(787, 284);
            btnAddWishlist.Name = "btnAddWishlist";
            btnAddWishlist.Size = new Size(136, 61);
            btnAddWishlist.TabIndex = 14;
            btnAddWishlist.Text = "Add to WishList Books";
            btnAddWishlist.UseVisualStyleBackColor = true;
            btnAddWishlist.Click += btnAddWishlist_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(11, 396);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 24;
            dgvBooks.Size = new Size(1267, 187);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // btnAddLoan
            // 
            btnAddLoan.Enabled = false;
            btnAddLoan.Location = new Point(944, 284);
            btnAddLoan.Name = "btnAddLoan";
            btnAddLoan.Size = new Size(136, 61);
            btnAddLoan.TabIndex = 15;
            btnAddLoan.Text = "Add Loaned Book";
            btnAddLoan.UseVisualStyleBackColor = true;
            btnAddLoan.Click += btnAddLoan_Click;
            // 
            // btnSwaptoOwned
            // 
            btnSwaptoOwned.Enabled = false;
            btnSwaptoOwned.Location = new Point(1097, 284);
            btnSwaptoOwned.Name = "btnSwaptoOwned";
            btnSwaptoOwned.Size = new Size(150, 61);
            btnSwaptoOwned.TabIndex = 16;
            btnSwaptoOwned.Text = "Move From WishList to Owned Books";
            btnSwaptoOwned.UseVisualStyleBackColor = true;
            btnSwaptoOwned.Click += btnSwaptoOwned_Click;
            // 
            // LibraryManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1293, 589);
            Controls.Add(btnSwaptoOwned);
            Controls.Add(btnAddLoan);
            Controls.Add(dgvBooks);
            Controls.Add(btnAddWishlist);
            Controls.Add(btnAddRead);
            Controls.Add(btnAddOwned);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "LibraryManager";
            Text = "Form1";
            Load += LibraryManager_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private DataGridView dgvBooks;
        private Button btnAddLoan;
        private Button btnSwaptoOwned;
    }
}

