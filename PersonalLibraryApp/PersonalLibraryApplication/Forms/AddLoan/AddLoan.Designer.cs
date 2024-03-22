using System.ComponentModel;

namespace PersonalLibraryApplication.Forms.AddLoan;

partial class AddLoan
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private IContainer components = null;

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
        panel1 = new Panel();
        txtTitle = new TextBox();
        label5 = new Label();
        txtAuthorSName = new TextBox();
        label3 = new Label();
        txtBookID = new TextBox();
        label2 = new Label();
        panel2 = new Panel();
        label6 = new Label();
        dtpDueDate = new DateTimePicker();
        label1 = new Label();
        dtpDateBorrowed = new DateTimePicker();
        button2 = new Button();
        button1 = new Button();
        label4 = new Label();
        txtDescription = new RichTextBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.Control;
        panel1.Controls.Add(txtTitle);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(txtAuthorSName);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(txtBookID);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(71, 49);
        panel1.Margin = new Padding(4, 5, 4, 5);
        panel1.Name = "panel1";
        panel1.Size = new Size(280, 138);
        panel1.TabIndex = 11;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(137, 14);
        txtTitle.Margin = new Padding(4, 5, 4, 5);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(132, 27);
        txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(4, 18);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 6;
        label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        txtAuthorSName.Location = new Point(137, 94);
        txtAuthorSName.Margin = new Padding(4, 5, 4, 5);
        txtAuthorSName.Name = "txtAuthorSName";
        txtAuthorSName.Size = new Size(132, 27);
        txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(8, 100);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(57, 20);
        label3.TabIndex = 4;
        label3.Text = "Author:";
        // 
        // txtBookID
        // 
        txtBookID.Location = new Point(137, 54);
        txtBookID.Margin = new Padding(4, 5, 4, 5);
        txtBookID.Name = "txtBookID";
        txtBookID.Size = new Size(132, 27);
        txtBookID.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(4, 58);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(44, 20);
        label2.TabIndex = 2;
        label2.Text = "ISBN:";
        // 
        // panel2
        // 
        panel2.Controls.Add(label6);
        panel2.Controls.Add(dtpDueDate);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(dtpDateBorrowed);
        panel2.Location = new Point(71, 214);
        panel2.Margin = new Padding(4, 5, 4, 5);
        panel2.Name = "panel2";
        panel2.Size = new Size(279, 172);
        panel2.TabIndex = 16;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(8, 72);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(72, 20);
        label6.TabIndex = 3;
        label6.Text = "Due Date";
        // 
        // dtpDueDate
        // 
        dtpDueDate.Location = new Point(4, 97);
        dtpDueDate.Margin = new Padding(4, 5, 4, 5);
        dtpDueDate.Name = "dtpDueDate";
        dtpDueDate.Size = new Size(265, 27);
        dtpDueDate.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 6);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(110, 20);
        label1.TabIndex = 1;
        label1.Text = "Date Borrowed";
        // 
        // dtpDateBorrowed
        // 
        dtpDateBorrowed.Location = new Point(4, 31);
        dtpDateBorrowed.Margin = new Padding(4, 5, 4, 5);
        dtpDateBorrowed.Name = "dtpDateBorrowed";
        dtpDateBorrowed.Size = new Size(265, 27);
        dtpDateBorrowed.TabIndex = 0;
        // 
        // button2
        // 
        button2.Location = new Point(251, 608);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(100, 35);
        button2.TabIndex = 15;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new Point(71, 608);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(100, 35);
        button1.TabIndex = 14;
        button1.Text = "Add Book";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(67, 414);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 13;
        label4.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(71, 438);
        txtDescription.Margin = new Padding(4, 5, 4, 5);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(279, 146);
        txtDescription.TabIndex = 12;
        txtDescription.Text = "";
        // 
        // AddLoan
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(417, 692);
        Controls.Add(panel1);
        Controls.Add(panel2);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddLoan";
        Text = "AddLoan";
        Load += AddLoan_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtAuthorSName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtBookID;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox txtDescription;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtpDateBorrowed;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker dtpDueDate;
}