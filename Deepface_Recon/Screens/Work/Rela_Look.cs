using System.Diagnostics;

namespace Deepface_Recon;

public partial class Rela_Look : Form
{
    public Rela_Look()
    {
        InitializeComponent();
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";

        string[] Relatorios = Directory.GetFiles(Final + "\\Resources\\Relatórios");
        Options = Relatorios;
        
        if(Relatorios.Length != 0)
        {
            foreach(string Relatorio in Relatorios)
            {
                string Rela_Name = Path.GetFileName(Relatorio);
                Rela_Viewer.Nodes.Add(Rela_Name);
            }
        }
    }

    private static string[] Options;
    private void Rela_Viewer_AfterSelect(object sender, TreeViewEventArgs e)
    {
        
    }

    private void Rela_Viewer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        foreach (string File in Options)
        { 
            string Name = Path.GetFileName(File);
            
            if (Name == Rela_Viewer.SelectedNode.Text)
            {
                ProcessStartInfo method = new ProcessStartInfo
                {
                    FileName = File,
                    UseShellExecute = true
                };
                
                Process.Start(method);
                Application.ExitThread();
            }
        }
    }
}