using System.Diagnostics;

namespace Deepface_Recon
{

    public partial class Setup_Download : Form
    {
        public Setup_Download()
        {
            InitializeComponent();
        }
       
        private void Procede_Click_Click(object sender, EventArgs e)
        {
            Program.PageSwitch(4);
        }

        private void GoBack_Click_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}