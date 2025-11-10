using System.Diagnostics;
namespace Deepface_Recon
{
    public partial class Welcome_Screen : Form
    {
        static int ChoiceIndex = 0;
        public Welcome_Screen()
        {
            InitializeComponent();
            
            
            
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void NoDownload_Click_Click(object sender, EventArgs e)
        {
            Program.PageSwitch(2);
        }

        private void Download_Click_Click(object sender, EventArgs e)
        {
            Program.PageSwitch(3);
        }
       
        
    }
}