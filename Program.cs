using  te = TextEditor.BL;

namespace TextEditor
{

static class Program
{
    public static Form1 form = new Form1();
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        form.FormLayout();
        te.FileManager fm = new te.FileManager();
        
       // ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}
}