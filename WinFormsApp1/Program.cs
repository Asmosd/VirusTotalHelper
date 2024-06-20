namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                System.Windows.Forms.Application.Run(new Application());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FATAL ERROR : {ex.Message}");
            }
        }
    }
}