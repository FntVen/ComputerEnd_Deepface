using System.Threading;

namespace Deepface_Recon
{
    static class Program
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
            Application.Run(new Welcome_Screen());
        }

        public static void PageSwitch(int LoadKey)
        {
            switch (LoadKey)
            {
                case 1:
                    var Thread1 = new Thread(LoadWelcome);
                    Thread1.Start();
                return;
                
                case 2:
                    var Thread2 = new Thread(LoadMain);
                    Thread2.Start();
                return;
                
                case 3:
                    var Thread3 = new Thread(LoadSetup);
                    Thread3.Start();
                    return;
                case 4:
                    Application.ExitThread();
                    var Thread4 = new Thread(LoadAskUser);
                    Thread4.Start();
                    return;
            }
        }

        private static void LoadWelcome()
        {
            Application.Exit(); 
            Application.Run(new Welcome_Screen());
        }

        private static void LoadSetup()
        {
            Application.Run(new Setup_Download());
        }

        private static void LoadAskUser()
        {
            Application.Run(new AskUser());
        }

        private static void LoadMain()
        {
            Application.Exit();
            Application.Run();
        }

    }
}