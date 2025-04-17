using hiep_14_typing_speed;

namespace hiep_14
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
            //Application.Run(new hiep_14_Frm1());
            Application.Run(new hiep_14_frm_test_174_chieu());
        }
    }
}