namespace Library.WinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new WinForms.MainForm());
        }
    }
}