namespace VariousSamples;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        INumberSumButton = new Button();
        GroupBooksButton = new Button();
        IParsablePersonButton = new Button();
        SuspendLayout();
        // 
        // INumberSumButton
        // 
        INumberSumButton.Location = new Point(12, 12);
        INumberSumButton.Name = "INumberSumButton";
        INumberSumButton.Size = new Size(209, 29);
        INumberSumButton.TabIndex = 0;
        INumberSumButton.Text = "INumber Sum";
        INumberSumButton.UseVisualStyleBackColor = true;
        INumberSumButton.Click += INumberSumButton_Click;
        // 
        // GroupBooksButton
        // 
        GroupBooksButton.Location = new Point(12, 57);
        GroupBooksButton.Name = "GroupBooksButton";
        GroupBooksButton.Size = new Size(209, 29);
        GroupBooksButton.TabIndex = 1;
        GroupBooksButton.Text = "Group books";
        GroupBooksButton.UseVisualStyleBackColor = true;
        GroupBooksButton.Click += GroupBooksButton_Click;
        // 
        // IParsablePersonButton
        // 
        IParsablePersonButton.Location = new Point(12, 103);
        IParsablePersonButton.Name = "IParsablePersonButton";
        IParsablePersonButton.Size = new Size(209, 29);
        IParsablePersonButton.TabIndex = 2;
        IParsablePersonButton.Text = "IParsable<Person>";
        IParsablePersonButton.UseVisualStyleBackColor = true;
        IParsablePersonButton.Click += IParsablePersonButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(445, 226);
        Controls.Add(IParsablePersonButton);
        Controls.Add(GroupBooksButton);
        Controls.Add(INumberSumButton);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button INumberSumButton;
    private Button GroupBooksButton;
    private Button IParsablePersonButton;
}
