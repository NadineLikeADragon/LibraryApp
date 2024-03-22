using System.ComponentModel;

namespace PersonalLibraryApplication.Forms.AddBookRead;

partial class AddBookRead
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
        chkOwned = new CheckBox();
        dtpDateFinished = new DateTimePicker();
        label6 = new Label();
        txtReview = new RichTextBox();
        Label = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
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
        panel1.Location = new Point(43, 52);
        panel1.Margin = new Padding(4, 5, 4, 5);
        panel1.Name = "panel1";
        panel1.Size = new Size(280, 128);
        panel1.TabIndex = 5;
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
        // button2
        // 
        button2.Location = new Point(223, 578);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(100, 35);
        button2.TabIndex = 9;
        button2.Text = "Cancel";
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(43, 578);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(100, 35);
        button1.TabIndex = 8;
        button1.Text = "Add Book";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(39, 385);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 7;
        label4.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(43, 409);
        txtDescription.Margin = new Padding(4, 5, 4, 5);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(279, 146);
        txtDescription.TabIndex = 6;
        txtDescription.Text = "";
        // 
        // panel2
        // 
        panel2.Controls.Add(chkOwned);
        panel2.Controls.Add(dtpDateFinished);
        panel2.Controls.Add(label6);
        panel2.Location = new Point(43, 237);
        panel2.Margin = new Padding(4, 5, 4, 5);
        panel2.Name = "panel2";
        panel2.Size = new Size(280, 128);
        panel2.TabIndex = 8;
        // 
        // chkOwned
        // 
        chkOwned.AutoSize = true;
        chkOwned.Location = new Point(79, 80);
        chkOwned.Margin = new Padding(4, 5, 4, 5);
        chkOwned.Name = "chkOwned";
        chkOwned.Size = new Size(110, 24);
        chkOwned.TabIndex = 8;
        chkOwned.Text = "Still Own it?";
        chkOwned.UseVisualStyleBackColor = true;
        // 
        // dtpDateFinished
        // 
        dtpDateFinished.Location = new Point(5, 25);
        dtpDateFinished.Margin = new Padding(4, 5, 4, 5);
        dtpDateFinished.Name = "dtpDateFinished";
        dtpDateFinished.Size = new Size(265, 27);
        dtpDateFinished.TabIndex = 7;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(1, 0);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(102, 20);
        label6.TabIndex = 4;
        label6.Text = "Date Finished:";
        // 
        // txtReview
        // 
        txtReview.Location = new Point(360, 52);
        txtReview.Margin = new Padding(4, 5, 4, 5);
        txtReview.Name = "txtReview";
        txtReview.Size = new Size(276, 559);
        txtReview.TabIndex = 10;
        txtReview.Text = "";
        // 
        // Label
        // 
        Label.AutoSize = true;
        Label.Location = new Point(356, 28);
        Label.Margin = new Padding(4, 0, 4, 0);
        Label.Name = "Label";
        Label.Size = new Size(56, 20);
        Label.TabIndex = 11;
        Label.Text = "Review";
        // 
        // AddBookRead
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(676, 642);
        Controls.Add(Label);
        Controls.Add(txtReview);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(txtDescription);
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddBookRead";
        Text = "AddBookRead";
        Load += AddBookRead_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private TextBox txtTitle;
    private Label label5;
    private TextBox txtAuthorSName;
    private Label label3;
    private TextBox txtBookID;
    private Label label2;
    private Button button2;
    private Button button1;
    private Label label4;
    private RichTextBox txtDescription;
    private Panel panel2;
    private Label label6;
    private DateTimePicker dtpDateFinished;
    private RichTextBox txtReview;
    private Label Label;
    private CheckBox chkOwned;
}