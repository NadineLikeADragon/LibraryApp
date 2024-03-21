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
            groupBox2 = new GroupBox();
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            btnAddOwned = new Button();
            btnAddRead = new Button();
            btnAddWishlist = new Button();
            dgvOwnedBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReadBooks).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWishlistBooks).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOwnedBooks).BeginInit();
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
            // dgvReadBooks
            // 
            dgvReadBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReadBooks.Location = new Point(12, 601);
            dgvReadBooks.Name = "dgvReadBooks";
            dgvReadBooks.RowHeadersWidth = 51;
            dgvReadBooks.RowTemplate.Height = 24;
            dgvReadBooks.Size = new Size(1216, 163);
            dgvReadBooks.TabIndex = 5;
            dgvReadBooks.CellContentClick += dgvReadBooks_CellContentClick;
            dgvReadBooks.VisibleChanged += rbVADRead_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView4);
            panel2.Location = new Point(1249, 859);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 165);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(19, 165);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 24;
            dataGridView4.Size = new Size(196, 145);
            dataGridView4.TabIndex = 1;
            // 
            // dgvWishlistBooks
            // 
            dgvWishlistBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWishlistBooks.Location = new Point(12, 782);
            dgvWishlistBooks.Name = "dgvWishlistBooks";
            dgvWishlistBooks.RowHeadersWidth = 51;
            dgvWishlistBooks.RowTemplate.Height = 24;
            dgvWishlistBooks.Size = new Size(1216, 160);
            dgvWishlistBooks.TabIndex = 1;
            dgvWishlistBooks.CellContentClick += dgvWishlistBooks_CellContentClick;
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
            groupBox1.Controls.Add(rbVADOwned);
            groupBox1.Controls.Add(rbVADRead);
            groupBox1.Controls.Add(rbVADWishlist);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(49, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 238);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(927, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 238);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poor Richard", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(-5, 17);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 4;
            label4.Text = "Would You Like to: ";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = SystemColors.ActiveCaptionText;
            radioButton4.Location = new Point(5, 63);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(163, 27);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "Track Book Loans";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Poor Richard", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton5.ForeColor = SystemColors.ActiveCaptionText;
            radioButton5.Location = new Point(5, 117);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(349, 27);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "Switch Books from WishList to Owned List ";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnAddOwned
            // 
            btnAddOwned.Location = new Point(1249, 455);
            btnAddOwned.Name = "btnAddOwned";
            btnAddOwned.Size = new Size(136, 62);
            btnAddOwned.TabIndex = 12;
            btnAddOwned.Text = "Add to Owned Books";
            btnAddOwned.UseVisualStyleBackColor = true;
            btnAddOwned.Visible = false;
            btnAddOwned.Click += btnAddOwned_Click;
            // 
            // btnAddRead
            // 
            btnAddRead.Location = new Point(1249, 577);
            btnAddRead.Name = "btnAddRead";
            btnAddRead.Size = new Size(136, 62);
            btnAddRead.TabIndex = 13;
            btnAddRead.Text = "Add to Read Books";
            btnAddRead.UseVisualStyleBackColor = true;
            btnAddRead.Visible = false;
            btnAddRead.Click += btnAddRead_Click;
            // 
            // btnAddWishlist
            // 
            btnAddWishlist.Location = new Point(1249, 678);
            btnAddWishlist.Name = "btnAddWishlist";
            btnAddWishlist.Size = new Size(136, 62);
            btnAddWishlist.TabIndex = 14;
            btnAddWishlist.Text = "Add to WishList Books";
            btnAddWishlist.UseVisualStyleBackColor = true;
            btnAddWishlist.Visible = false;
            btnAddWishlist.Click += btnAddWishlist_Click;
            // 
            // dgvOwnedBooks
            // 
            dgvOwnedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnedBooks.Location = new Point(12, 396);
            dgvOwnedBooks.Name = "dgvOwnedBooks";
            dgvOwnedBooks.RowHeadersWidth = 51;
            dgvOwnedBooks.RowTemplate.Height = 24;
            dgvOwnedBooks.Size = new Size(1216, 186);
            dgvOwnedBooks.TabIndex = 0;
            dgvOwnedBooks.CellContentClick += dgvOwnedBooks_CellContentClick;
            // 
            // LibraryManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1476, 1055);
            Controls.Add(dgvWishlistBooks);
            Controls.Add(dgvReadBooks);
            Controls.Add(dgvOwnedBooks);
            Controls.Add(btnAddWishlist);
            Controls.Add(btnAddRead);
            Controls.Add(btnAddOwned);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "LibraryManager";
            Text = "Form1";
            Load += LibraryManager_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReadBooks).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWishlistBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private Label label4;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button btnAddOwned;
        private Button btnAddRead;
        private Button btnAddWishlist;
        private DataGridView dgvOwnedBooks;
    }
}

