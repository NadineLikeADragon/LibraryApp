using System.ComponentModel;

namespace PersonalLibraryApplication.Forms.AddWishList;

partial class AddWishList
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
        button2 = new Button();
        button1 = new Button();
        label4 = new Label();
        txtDescription = new RichTextBox();
        txtTitle = new TextBox();
        label5 = new Label();
        txtAuthorSName = new TextBox();
        label3 = new Label();
        txtBookID = new TextBox();
        label1 = new Label();
        txtPrice = new TextBox();
        label6 = new Label();
        rbtnExistingBook = new RadioButton();
        rbtnNewBook = new RadioButton();
        SuspendLayout();
        // 
        // button2
        // 
        button2.Location = new Point(244, 555);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(100, 35);
        button2.TabIndex = 9;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click_1;
        // 
        // button1
        // 
        button1.Location = new Point(64, 555);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(123, 35);
        button1.TabIndex = 8;
        button1.Text = "Add To Wishlist";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(60, 362);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 7;
        label4.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(64, 386);
        txtDescription.Margin = new Padding(4, 5, 4, 5);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(279, 146);
        txtDescription.TabIndex = 6;
        txtDescription.Text = "";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(208, 41);
        txtTitle.Margin = new Padding(4, 5, 4, 5);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(132, 27);
        txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(64, 44);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 6;
        label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        txtAuthorSName.Location = new Point(208, 171);
        txtAuthorSName.Margin = new Padding(4, 5, 4, 5);
        txtAuthorSName.Name = "txtAuthorSName";
        txtAuthorSName.Size = new Size(132, 27);
        txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(64, 174);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(119, 20);
        label3.TabIndex = 4;
        label3.Text = "Author Surname:";
        // 
        // txtBookID
        // 
        txtBookID.Location = new Point(208, 108);
        txtBookID.Margin = new Padding(4, 5, 4, 5);
        txtBookID.Name = "txtBookID";
        txtBookID.Size = new Size(132, 27);
        txtBookID.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(64, 115);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(44, 20);
        label1.TabIndex = 0;
        label1.Text = "ISBN:";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(208, 303);
        txtPrice.Margin = new Padding(4, 5, 4, 5);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(132, 27);
        txtPrice.TabIndex = 4;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(73, 303);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(66, 20);
        label6.TabIndex = 3;
        label6.Text = "Price (€):";
        // 
        // rbtnExistingBook
        // 
        rbtnExistingBook.AutoSize = true;
        rbtnExistingBook.Checked = true;
        rbtnExistingBook.Location = new Point(210, 238);
        rbtnExistingBook.Margin = new Padding(4, 5, 4, 5);
        rbtnExistingBook.Name = "rbtnExistingBook";
        rbtnExistingBook.Size = new Size(119, 24);
        rbtnExistingBook.TabIndex = 1;
        rbtnExistingBook.TabStop = true;
        rbtnExistingBook.Text = "Existing Book";
        rbtnExistingBook.UseVisualStyleBackColor = true;
        // 
        // rbtnNewBook
        // 
        rbtnNewBook.AutoSize = true;
        rbtnNewBook.Location = new Point(64, 238);
        rbtnNewBook.Margin = new Padding(4, 5, 4, 5);
        rbtnNewBook.Name = "rbtnNewBook";
        rbtnNewBook.Size = new Size(98, 24);
        rbtnNewBook.TabIndex = 0;
        rbtnNewBook.Text = "New Book";
        rbtnNewBook.UseVisualStyleBackColor = true;
        // 
        // AddWishList
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(388, 634);
        Controls.Add(label6);
        Controls.Add(txtPrice);
        Controls.Add(txtAuthorSName);
        Controls.Add(label3);
        Controls.Add(rbtnExistingBook);
        Controls.Add(txtTitle);
        Controls.Add(rbtnNewBook);
        Controls.Add(txtBookID);
        Controls.Add(label5);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddWishList";
        Text = "AddWishList";
        Load += AddWishList_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button2;
    private Button button1;
    private Label label4;
    private RichTextBox txtDescription;
    private TextBox txtTitle;
    private Label label5;
    private TextBox txtAuthorSName;
    private Label label3;
    private TextBox txtBookID;
    private Label label1;
    private Label label6;
    private RadioButton rbtnExistingBook;
    private RadioButton rbtnNewBook;
    private TextBox txtPrice;
}