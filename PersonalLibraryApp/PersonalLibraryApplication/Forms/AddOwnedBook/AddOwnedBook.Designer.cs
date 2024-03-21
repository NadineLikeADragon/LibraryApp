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
        panel1.Enabled = false;
        panel1.Location = new Point(55, 25);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(245, 104);
        panel1.TabIndex = 5;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(120, 10);
        txtTitle.Margin = new Padding(4, 3, 4, 3);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(116, 23);
        txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(4, 14);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(32, 15);
        label5.TabIndex = 6;
        label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        txtAuthorSName.Location = new Point(120, 70);
        txtAuthorSName.Margin = new Padding(4, 3, 4, 3);
        txtAuthorSName.Name = "txtAuthorSName";
        txtAuthorSName.Size = new Size(116, 23);
        txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(7, 75);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(97, 15);
        label3.TabIndex = 4;
        label3.Text = "Author Surname:";
        // 
        // txtBookID
        // 
        txtBookID.Location = new Point(120, 40);
        txtBookID.Margin = new Padding(4, 3, 4, 3);
        txtBookID.Name = "txtBookID";
        txtBookID.Size = new Size(116, 23);
        txtBookID.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(4, 44);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(35, 15);
        label2.TabIndex = 2;
        label2.Text = "ISBN:";
        // 
        // button2
        // 
        button2.Location = new Point(212, 367);
        button2.Margin = new Padding(4, 3, 4, 3);
        button2.Name = "button2";
        button2.Size = new Size(88, 27);
        button2.TabIndex = 9;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new Point(55, 367);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(88, 27);
        button1.TabIndex = 8;
        button1.Text = "Add Book";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(51, 222);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(70, 15);
        label4.TabIndex = 7;
        label4.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Enabled = false;
        txtDescription.Location = new Point(55, 240);
        txtDescription.Margin = new Padding(4, 3, 4, 3);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(244, 110);
        txtDescription.TabIndex = 6;
        txtDescription.Text = "";
        // 
        // panel2
        // 
        panel2.Controls.Add(label6);
        panel2.Controls.Add(dtpDateBought);
        panel2.Location = new Point(55, 149);
        panel2.Margin = new Padding(4, 3, 4, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(244, 58);
        panel2.TabIndex = 10;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(4, 0);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(73, 15);
        label6.TabIndex = 3;
        label6.Text = "Date Bought";
        // 
        // dtpDateBought
        // 
        dtpDateBought.Location = new Point(2, 22);
        dtpDateBought.Margin = new Padding(4, 3, 4, 3);
        dtpDateBought.Name = "dtpDateBought";
        dtpDateBought.Size = new Size(233, 23);
        dtpDateBought.TabIndex = 2;
        // 
        // AddOwnedBook
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(332, 406);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Margin = new Padding(4, 3, 4, 3);
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