using foododering.DAO;

namespace foododering
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

            try
            {
                new RestaurantDao().EnsureDefaultAsync().GetAwaiter().GetResult();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"The restaurant record could not be initialized in the database.\n\n{exception.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Application.Run(new Form1());
        }
    }
}