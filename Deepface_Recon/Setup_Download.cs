using System.Diagnostics;

namespace Deepface_Recon
{

    public partial class Setup_Download : Form
    {
        public Setup_Download()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Procede_Click_Click(object sender, EventArgs e)
        {
            PyInstaller();
        }

        private void GoBack_Click_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
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

    }
}