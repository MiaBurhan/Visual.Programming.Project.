namespace Visual.Programming.Project.Grey
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // create main form so theme and icon can be applied before run
            var mainForm = new HomeForm();
            // start maximized so home page opens in full screen
            mainForm.WindowState = FormWindowState.Maximized;
            // ensure theme applied (constructor already calls Theme.ApplyFormStyle)
            Application.Run(mainForm);
        }
    }
}