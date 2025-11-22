using System.Diagnostics;
using System.Text;
using System.IO.Compression;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Deepface_Recon
{

    public partial class AskUser : Form
    {
        

        public AskUser()
        {
            
            InitializeComponent();
            LoadingIcon.Visible = false;

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
        

        private void PyInstaller(string user)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string[] segpath = path.Split("\\");
            List<string> segpathList = segpath.ToList();
            segpathList.RemoveAt(segpathList.Count - 1);
            segpathList.RemoveAt(segpathList.Count - 1);
            
            string Final = String.Join("\\", segpathList);
            Console.WriteLine(Final);

            string FullCall = "/c " + "winget install --id Python.Python.3.12 --scope machine";

            ProcessStartInfo RunPy = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = FullCall,
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true
            };
            VisibilityToggle(1);
            Process.Start(RunPy);
            //Console.WriteLine("After RunPy");
            //Console.WriteLine("");
            
            Task.Run(() =>
            {
                Thread.Sleep(10000);
                //Console.WriteLine("ThreadSleep");
                //Console.WriteLine("");
                while (true)
                {
                    //Console.WriteLine("In While Loop");
                    //Console.WriteLine("");
                    Process[] PythonOpen = Process.GetProcessesByName("Python-3.12.0-amd64");
                    Process[] CmdOpen = Process.GetProcessesByName("cmd");
                
                    if (PythonOpen.Length > 0 == false && CmdOpen.Length > 0 == false)
                    {
                        //Console.WriteLine("In if");
                        //Console.WriteLine("");
                        
                        Directory.Delete("C:\\Program Files\\Python312\\Scripts", true);
                        Directory.Delete("C:\\Program Files\\Python312\\Lib\\site-packages", true);
                        ZipFile.ExtractToDirectory(Final + "\\Resources\\Lib\\PythonCompressed.zip",  Final + "\\Resources\\Lib");
                        //Console.WriteLine("After Extract");
                        Directory.Move(Final + "\\Resources\\Lib\\site-packages", "C:\\Program Files\\Python312\\Lib\\site-packages");
                        Directory.Move(Final + "\\Resources\\Lib\\Scripts","C:\\Program Files\\Python312\\Scripts");
                        VisibilityToggle(0);
                        break;
                    }
                }
                
            });
            

            
            

        }

        private void VisibilityToggle(int Visibility)
        {
            if (Visibility == 1)
            {
                Proceed_Click.Visible =  false;
                GoBack_Click.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                UserOptions_CB.Visible = false;
                pictureBox1.Visible = false;
                LoadingIcon.Visible = true;
            }
            else
            {
                LoadingIcon.Visible = false;
                Proceed_Click.Visible = true;
                GoBack_Click.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                UserOptions_CB.Visible = true;
                pictureBox1.Visible = true;

            }
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

        private void Proceed_Click_Click(object sender, EventArgs e)
        {
            var User = UserOptions_CB.SelectedItem;
            if (User != null)
            {
                PyInstaller(User.ToString());   
            }
            
            
        }

        private void UserOptions_CB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void LoadingIcon_Click(object sender, EventArgs e)
        {
            
        }
    }
}