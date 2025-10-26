using System.Diagnostics;
namespace Deepface_Recon
{
    public partial class Welcome_Screen : Form
    {
        public Welcome_Screen()
        {
            InitializeComponent();
        }

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
            PyInstaller();
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
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
           
            Console.WriteLine("Python Installed Successfully");
            
        }
    }
}