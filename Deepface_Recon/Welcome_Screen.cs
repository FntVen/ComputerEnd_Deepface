using System.Diagnostics;
namespace Deepface_Recon
{
    public partial class Welcome_Screen : Form
    {
        public Welcome_Screen()
        {
            InitializeComponent();
            string AppPath = AppDomain.CurrentDomain.BaseDirectory;
            PathDependencies = AppPath + "\\Dependencies\\site-packages";
            
        }
        public static string PathDependencies;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void NoDownload_Click_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Download_Click_Click(object sender, EventArgs e)
        {
            Program.PageSwitch(3);
        }
       
        private static void DependencyHandlerv2()
        {
            //The goal is to displace all necessary libraries to the correct folder instead of downloading from the internet
            //to improve speeds (Hopefully)

            string PreBuiltPath = "\\AppData\\Roaming\\Python\\Python312";
            string PathtoUser = "C:\\Users";//Path to the users folder
            string[] AvaliableUsers = [];//List of users that don't involve "Default" and "Public"
            string[] users = Directory.GetDirectories(PathtoUser);//Get all users from users folder
            
            foreach (string dir in users)
            {
                if (dir.ToUpper().Contains("DEFAULT") == false || dir.ToUpper().Contains("PUBLIC") == false)
                {
                    AvaliableUsers.Append(dir);
                }
                if (AvaliableUsers.Count() > 1)
                {
                    //Pop-uo the lists all users in the computer for the end user to choose
                    
                    int ChoiceIndex = 0;
                    string ChoosenUser = AvaliableUsers[ChoiceIndex];
                    string FullEndPath = ChoosenUser + PreBuiltPath;
                    Directory.Move(PathDependencies, FullEndPath);
                }
                if (AvaliableUsers.Count() == 1)
                {
                    //Installs in the only user available
                    Directory.Move(PathtoUser, AvaliableUsers[0] + PreBuiltPath);
                }
            }
        }
    }
}