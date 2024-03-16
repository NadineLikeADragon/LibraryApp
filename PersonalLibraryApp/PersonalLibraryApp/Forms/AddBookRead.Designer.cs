namespace PersonalLibraryApp.Forms
{
    partial class AddBookRead
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateFinished = new System.Windows.Forms.DateTimePicker();
            this.txtReview = new System.Windows.Forms.RichTextBox();
            this.Label = new System.Windows.Forms.Label();
            this.chkOwned = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAuthorSName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBookID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 83);
            this.panel1.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Title:";
            // 
            // txtAuthorSName
            // 
            this.txtAuthorSName.Location = new System.Drawing.Point(107, 55);
            this.txtAuthorSName.Name = "txtAuthorSName";
            this.txtAuthorSName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorSName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author Surname:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(107, 29);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(32, 266);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 96);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkOwned);
            this.panel2.Controls.Add(this.dtpDateFinished);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(32, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 83);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Finished:";
            // 
            // dtpDateFinished
            // 
            this.dtpDateFinished.Location = new System.Drawing.Point(4, 16);
            this.dtpDateFinished.Name = "dtpDateFinished";
            this.dtpDateFinished.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinished.TabIndex = 7;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(270, 34);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(208, 365);
            this.txtReview.TabIndex = 10;
            this.txtReview.Text = "";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(267, 18);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(43, 13);
            this.Label.TabIndex = 11;
            this.Label.Text = "Review";
            // 
            // chkOwned
            // 
            this.chkOwned.AutoSize = true;
            this.chkOwned.Location = new System.Drawing.Point(59, 52);
            this.chkOwned.Name = "chkOwned";
            this.chkOwned.Size = new System.Drawing.Size(81, 17);
            this.chkOwned.TabIndex = 8;
            this.chkOwned.Text = "Still Own it?";
            this.chkOwned.UseVisualStyleBackColor = true;
            // 
            // AddBookRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersonalLibraryApp.Properties.Resources.AddItem_Background;
            this.ClientSize = new System.Drawing.Size(507, 417);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Name = "AddBookRead";
            this.Text = "AddBookRead";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateFinished;
        private System.Windows.Forms.RichTextBox txtReview;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.CheckBox chkOwned;
    }
}