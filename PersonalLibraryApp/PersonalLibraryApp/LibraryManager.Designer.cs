namespace PersonalLibraryApp
{
    partial class LibraryApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvWishlistBooks = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReadBooks = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dgvOwnedBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rbVADOwned = new System.Windows.Forms.RadioButton();
            this.rbVADRead = new System.Windows.Forms.RadioButton();
            this.rbVADWishlist = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnAddOwned = new System.Windows.Forms.Button();
            this.btnAddRead = new System.Windows.Forms.Button();
            this.btnAddWishlist = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlistBooks)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadBooks)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnedBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(356, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Library Manager";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 277);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvWishlistBooks);
            this.panel2.Location = new System.Drawing.Point(543, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 277);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // dgvWishlistBooks
            // 
            this.dgvWishlistBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWishlistBooks.Location = new System.Drawing.Point(15, 94);
            this.dgvWishlistBooks.Name = "dgvWishlistBooks";
            this.dgvWishlistBooks.RowHeadersWidth = 51;
            this.dgvWishlistBooks.RowTemplate.Height = 24;
            this.dgvWishlistBooks.Size = new System.Drawing.Size(188, 116);
            this.dgvWishlistBooks.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReadBooks);
            this.panel3.Location = new System.Drawing.Point(289, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 277);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgvReadBooks
            // 
            this.dgvReadBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadBooks.Location = new System.Drawing.Point(14, 94);
            this.dgvReadBooks.Name = "dgvReadBooks";
            this.dgvReadBooks.RowHeadersWidth = 51;
            this.dgvReadBooks.RowTemplate.Height = 24;
            this.dgvReadBooks.Size = new System.Drawing.Size(188, 116);
            this.dgvReadBooks.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Location = new System.Drawing.Point(1017, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 277);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(14, 94);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(188, 116);
            this.dataGridView4.TabIndex = 1;
            // 
            // dgvOwnedBooks
            // 
            this.dgvOwnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnedBooks.Location = new System.Drawing.Point(44, 421);
            this.dgvOwnedBooks.Name = "dgvOwnedBooks";
            this.dgvOwnedBooks.RowHeadersWidth = 51;
            this.dgvOwnedBooks.RowTemplate.Height = 24;
            this.dgvOwnedBooks.Size = new System.Drawing.Size(188, 116);
            this.dgvOwnedBooks.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(-5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select an option: ";
            // 
            // rbVADOwned
            // 
            this.rbVADOwned.AutoSize = true;
            this.rbVADOwned.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVADOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbVADOwned.Location = new System.Drawing.Point(6, 51);
            this.rbVADOwned.Name = "rbVADOwned";
            this.rbVADOwned.Size = new System.Drawing.Size(229, 20);
            this.rbVADOwned.TabIndex = 5;
            this.rbVADOwned.TabStop = true;
            this.rbVADOwned.Text = "View, Add, Delete Current Owned Books";
            this.rbVADOwned.UseVisualStyleBackColor = true;
            this.rbVADOwned.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbVADRead
            // 
            this.rbVADRead.AutoSize = true;
            this.rbVADRead.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVADRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbVADRead.Location = new System.Drawing.Point(6, 93);
            this.rbVADRead.Name = "rbVADRead";
            this.rbVADRead.Size = new System.Drawing.Size(211, 20);
            this.rbVADRead.TabIndex = 6;
            this.rbVADRead.TabStop = true;
            this.rbVADRead.Text = "View Add, Delete Books You\'ve Read";
            this.rbVADRead.UseVisualStyleBackColor = true;
            // 
            // rbVADWishlist
            // 
            this.rbVADWishlist.AutoSize = true;
            this.rbVADWishlist.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVADWishlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbVADWishlist.Location = new System.Drawing.Point(6, 141);
            this.rbVADWishlist.Name = "rbVADWishlist";
            this.rbVADWishlist.Size = new System.Drawing.Size(187, 20);
            this.rbVADWishlist.TabIndex = 7;
            this.rbVADWishlist.TabStop = true;
            this.rbVADWishlist.Text = "ViewAdd, Delete  Wishlist Items";
            this.rbVADWishlist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbVADOwned);
            this.groupBox1.Controls.Add(this.rbVADRead);
            this.groupBox1.Controls.Add(this.rbVADWishlist);
            this.groupBox1.Location = new System.Drawing.Point(82, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(650, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(-5, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Would You Like to: ";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton4.Location = new System.Drawing.Point(6, 51);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(114, 20);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Track Book Loans";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton5.Location = new System.Drawing.Point(6, 93);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(235, 20);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Switch Books from WishList to Owned List ";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnAddOwned
            // 
            this.btnAddOwned.Location = new System.Drawing.Point(794, 479);
            this.btnAddOwned.Name = "btnAddOwned";
            this.btnAddOwned.Size = new System.Drawing.Size(136, 49);
            this.btnAddOwned.TabIndex = 12;
            this.btnAddOwned.Text = "Add to Owned Books";
            this.btnAddOwned.UseVisualStyleBackColor = true;
            // 
            // btnAddRead
            // 
            this.btnAddRead.Location = new System.Drawing.Point(955, 479);
            this.btnAddRead.Name = "btnAddRead";
            this.btnAddRead.Size = new System.Drawing.Size(136, 49);
            this.btnAddRead.TabIndex = 13;
            this.btnAddRead.Text = "Add to Read Books";
            this.btnAddRead.UseVisualStyleBackColor = true;
            // 
            // btnAddWishlist
            // 
            this.btnAddWishlist.Location = new System.Drawing.Point(1115, 479);
            this.btnAddWishlist.Name = "btnAddWishlist";
            this.btnAddWishlist.Size = new System.Drawing.Size(136, 49);
            this.btnAddWishlist.TabIndex = 14;
            this.btnAddWishlist.Text = "Add to WishList Books";
            this.btnAddWishlist.UseVisualStyleBackColor = true;
            // 
            // LibraryApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersonalLibraryApp.Properties.Resources.Books_1085770318;
            this.ClientSize = new System.Drawing.Size(1263, 605);
            this.Controls.Add(this.btnAddWishlist);
            this.Controls.Add(this.btnAddRead);
            this.Controls.Add(this.btnAddOwned);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOwnedBooks);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "LibraryApp";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWishlistBooks)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadBooks)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnedBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvOwnedBooks;
        private System.Windows.Forms.DataGridView dgvWishlistBooks;
        private System.Windows.Forms.DataGridView dgvReadBooks;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbVADOwned;
        private System.Windows.Forms.RadioButton rbVADRead;
        private System.Windows.Forms.RadioButton rbVADWishlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnAddOwned;
        private System.Windows.Forms.Button btnAddRead;
        private System.Windows.Forms.Button btnAddWishlist;
    }
}

