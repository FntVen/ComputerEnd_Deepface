using System.Diagnostics;
using System.Text;

namespace Deepface_Recon
{

    public partial class AskUser : Form
    {
        

        public AskUser()
        {
            InitializeComponent();

            string[] AvaliableOptions;
            string UserPath = "C:\\Users";
            string AppPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] UserOptions = Directory.GetDirectories(UserPath);
            StringBuilder CorrectedList = new StringBuilder();
            foreach (string user in UserOptions)
            {
                if (!(user.ToUpper().Contains("DEFAULT")|| user.ToUpper().Contains("PUBLIC") || user.ToUpper().Contains("PÚBLICO") || user.ToUpper().Contains("ALL") ||  user.ToUpper().Contains("PÚBLICO") || user.ToUpper().Contains("TODOS") || user.ToUpper().Contains("PADRÃO")))
                {
                    CorrectedList.Append(user);
                }
            }

            string[] FinalList;
            string[] CorrectedOptions = CorrectedList.ToString().Split('C');
            foreach (string Option in  CorrectedOptions)
            {
                string[] LastSegment = Option.Split("\\");
                if (!(LastSegment[0] == null || LastSegment[0] == ""))
                {
                    UserOptions_CB.Items.Add(LastSegment[LastSegment.Length - 1]);
                }
            }

        }
        

        private void UserOptions_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private static void PyInstaller()
        {

            string FullCall = "/c " + "winget install --id Python.Python.3.12 --scope machine";

            ProcessStartInfo RunPy = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = FullCall,
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true
            };

            try
            {
                Process.Start(RunPy);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("Python Installed Successfully");
        }

        private void AskUser_Load(object sender, EventArgs e)
        {
           
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GoBack_Click_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}