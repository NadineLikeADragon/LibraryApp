using System.ComponentModel;

namespace PersonalLibraryApplication.Forms.AddOwnedBook;

partial class AddOwnedBook
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
        button2 = new Button();
        button1 = new Button();
        label4 = new Label();
        txtDescription = new RichTextBox();
        panel2 = new Panel();
        label6 = new Label();
        dtpDateBought = new DateTimePicker();
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
        panel1.Location = new Point(63, 33);
        panel1.Margin = new Padding(5, 4, 5, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(280, 139);
        panel1.TabIndex = 5;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(137, 13);
        txtTitle.Margin = new Padding(5, 4, 5, 4);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(132, 27);
        txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(5, 19);
        label5.Margin = new Padding(5, 0, 5, 0);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 6;
        label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        txtAuthorSName.Location = new Point(137, 93);
        txtAuthorSName.Margin = new Padding(5, 4, 5, 4);
        txtAuthorSName.Name = "txtAuthorSName";
        txtAuthorSName.Size = new Size(132, 27);
        txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(8, 100);
        label3.Margin = new Padding(5, 0, 5, 0);
        label3.Name = "label3";
        label3.Size = new Size(119, 20);
        label3.TabIndex = 4;
        label3.Text = "Author Surname:";
        // 
        // txtBookID
        // 
        txtBookID.Location = new Point(137, 53);
        txtBookID.Margin = new Padding(5, 4, 5, 4);
        txtBookID.Name = "txtBookID";
        txtBookID.Size = new Size(132, 27);
        txtBookID.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(5, 59);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(44, 20);
        label2.TabIndex = 2;
        label2.Text = "ISBN:";
        // 
        // button2
        // 
        button2.Location = new Point(242, 489);
        button2.Margin = new Padding(5, 4, 5, 4);
        button2.Name = "button2";
        button2.Size = new Size(101, 36);
        button2.TabIndex = 9;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new Point(63, 489);
        button1.Margin = new Padding(5, 4, 5, 4);
        button1.Name = "button1";
        button1.Size = new Size(101, 36);
        button1.TabIndex = 8;
        button1.Text = "Add Book";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(58, 296);
        label4.Margin = new Padding(5, 0, 5, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 7;
        label4.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(63, 320);
        txtDescription.Margin = new Padding(5, 4, 5, 4);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(278, 145);
        txtDescription.TabIndex = 6;
        txtDescription.Text = "";
        // 
        // panel2
        // 
        panel2.Controls.Add(label6);
        panel2.Controls.Add(dtpDateBought);
        panel2.Location = new Point(63, 199);
        panel2.Margin = new Padding(5, 4, 5, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(279, 77);
        panel2.TabIndex = 10;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(5, 0);
        label6.Margin = new Padding(5, 0, 5, 0);
        label6.Name = "label6";
        label6.Size = new Size(93, 20);
        label6.TabIndex = 3;
        label6.Text = "Date Bought";
        // 
        // dtpDateBought
        // 
        dtpDateBought.Location = new Point(2, 29);
        dtpDateBought.Margin = new Padding(5, 4, 5, 4);
        dtpDateBought.Name = "dtpDateBought";
        dtpDateBought.Size = new Size(266, 27);
        dtpDateBought.TabIndex = 2;
        // 
        // AddOwnedBook
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(379, 541);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Margin = new Padding(5, 4, 5, 4);
        Name = "AddOwnedBook";
        Text = "AddOwnedBook";
        Load += AddOwnedBook_Load;
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
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox txtDescription;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DateTimePicker dtpDateBought;
    private System.Windows.Forms.Label label6;
}