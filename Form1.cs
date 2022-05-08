using System.Windows.Forms;
using System;


namespace TextEditor;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public void FormLayout()
    {
        this.Name = "Form12";
        this.Text = "Form12";
        this.Size = new System.Drawing.Size(500, 500);
        this.StartPosition = FormStartPosition.CenterScreen;
    }
}
