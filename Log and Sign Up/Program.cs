using System.Collections;

namespace Log_and_Sign_Up
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       

        public static string UserPassword;
        public static string UserName;
        public static SortedList userNameandPassword_Collection;
       
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Sign_up_form());
        }
    }
}