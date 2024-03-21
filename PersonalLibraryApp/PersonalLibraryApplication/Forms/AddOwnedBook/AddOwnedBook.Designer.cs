﻿using System.ComponentModel;

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
        this.dtpDateBought = new System.Windows.Forms.DateTimePicker();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.SystemColors.Control;
        this.panel1.Controls.Add(this.txtTitle);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.txtAuthorSName);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.txtBookID);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Enabled = false;
        this.panel1.Location = new System.Drawing.Point(47, 22);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(210, 90);
        this.panel1.TabIndex = 5;
        // 
        // txtTitle
        // 
        this.txtTitle.Location = new System.Drawing.Point(103, 9);
        this.txtTitle.Name = "txtTitle";
        this.txtTitle.Size = new System.Drawing.Size(100, 20);
        this.txtTitle.TabIndex = 7;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(3, 12);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(30, 13);
        this.label5.TabIndex = 6;
        this.label5.Text = "Title:";
        // 
        // txtAuthorSName
        // 
        this.txtAuthorSName.Location = new System.Drawing.Point(103, 61);
        this.txtAuthorSName.Name = "txtAuthorSName";
        this.txtAuthorSName.Size = new System.Drawing.Size(100, 20);
        this.txtAuthorSName.TabIndex = 5;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 65);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(86, 13);
        this.label3.TabIndex = 4;
        this.label3.Text = "Author Surname:";
        // 
        // txtBookID
        // 
        this.txtBookID.Location = new System.Drawing.Point(103, 35);
        this.txtBookID.Name = "txtBookID";
        this.txtBookID.Size = new System.Drawing.Size(100, 20);
        this.txtBookID.TabIndex = 3;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(3, 38);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(35, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "ISBN:";
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(182, 318);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(75, 23);
        this.button2.TabIndex = 9;
        this.button2.Text = "Cancel";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(47, 318);
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
        this.label4.Location = new System.Drawing.Point(44, 192);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(63, 13);
        this.label4.TabIndex = 7;
        this.label4.Text = "Description:";
        // 
        // txtDescription
        // 
        this.txtDescription.Enabled = false;
        this.txtDescription.Location = new System.Drawing.Point(47, 208);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(210, 96);
        this.txtDescription.TabIndex = 6;
        this.txtDescription.Text = "";
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.label6);
        this.panel2.Controls.Add(this.dtpDateBought);
        this.panel2.Location = new System.Drawing.Point(47, 129);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(209, 50);
        this.panel2.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(3, 0);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(67, 13);
        this.label6.TabIndex = 3;
        this.label6.Text = "Date Bought";
        // 
        // dtpDateBought
        // 
        this.dtpDateBought.Location = new System.Drawing.Point(2, 19);
        this.dtpDateBought.Name = "dtpDateBought";
        this.dtpDateBought.Size = new System.Drawing.Size(200, 20);
        this.dtpDateBought.TabIndex = 2;
        // 
        // AddOwnedBook
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(285, 352);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtDescription);
        this.Name = "AddOwnedBook";
        this.Text = "AddOwnedBook";
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
    private System.Windows.Forms.DateTimePicker dtpDateBought;
    private System.Windows.Forms.Label label6;
}