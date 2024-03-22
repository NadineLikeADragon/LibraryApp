using System.ComponentModel;

namespace PersonalLibraryApplication.Forms.AddBook;

partial class AddBook
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
        txtDescription = new RichTextBox();
        label4 = new Label();
        button1 = new Button();
        button2 = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(txtTitle);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(txtAuthorSName);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(txtBookID);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(60, 45);
        panel1.Margin = new Padding(4, 5, 4, 5);
        panel1.Name = "panel1";
        panel1.Size = new Size(280, 128);
        panel1.TabIndex = 0;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(143, 5);
        txtTitle.Margin = new Padding(4, 5, 4, 5);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(132, 27);
        txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(9, 9);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 6;
        label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        txtAuthorSName.Location = new Point(143, 85);
        txtAuthorSName.Margin = new Padding(4, 5, 4, 5);
        txtAuthorSName.Name = "txtAuthorSName";
        txtAuthorSName.Size = new Size(132, 27);
        txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(9, 89);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(57, 20);
        label3.TabIndex = 4;
        label3.Text = "Author:";
        // 
        // txtBookID
        // 
        txtBookID.Location = new Point(143, 45);
        txtBookID.Margin = new Padding(4, 5, 4, 5);
        txtBookID.Name = "txtBookID";
        txtBookID.Size = new Size(132, 27);
        txtBookID.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(9, 49);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(44, 20);
        label2.TabIndex = 2;
        label2.Text = "ISBN:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(60, 246);
        txtDescription.Margin = new Padding(4, 5, 4, 5);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(279, 146);
        txtDescription.TabIndex = 1;
        txtDescription.Text = "";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(56, 222);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 2;
        label4.Text = "Description:";
        // 
        // button1
        // 
        button1.Location = new Point(60, 415);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(100, 35);
        button1.TabIndex = 3;
        button1.Text = "Add Book";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(240, 415);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(100, 35);
        button2.TabIndex = 4;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // AddBook
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(403, 485);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Controls.Add(panel1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddBook";
        Text = "AddBook";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorSName;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label2;
}