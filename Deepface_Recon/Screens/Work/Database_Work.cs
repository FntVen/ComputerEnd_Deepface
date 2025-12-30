using Deepface_Recon.SubMenus;
using Microsoft.EntityFrameworkCore;

namespace Deepface_Recon;

public partial class Database_Work : Form
{
    public Database_Work()
    {
        InitializeComponent();
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";
        string DatabasePath = Final + "\\Resources\\Dbs";
        DbPath = DatabasePath;
        string[] DbList = Directory.GetDirectories(DatabasePath);
        if(DbList.Length != 0)
        {
            foreach (string db in DbList)
            {
                string dbName = Path.GetFileNameWithoutExtension(db);
                Database_View.Nodes.Add(dbName);
                //Database_View.Refresh();
            }
        }
    }

    public void SetView()
    {
        Database_View.Nodes.Clear();
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";
        string DatabasePath = Final + "\\Resources\\Dbs";
        DbPath = DatabasePath;
        string[] DbList = Directory.GetDirectories(DatabasePath);
        if(DbList.Length != 0)
        {
            foreach (string db in DbList)
            {
                string dbName = Path.GetFileNameWithoutExtension(db);
                Database_View.Nodes.Add(dbName);
                //Database_View.Refresh();
            }
        }
    }

    public static string DbPath;
    
    private void Database_View_AfterSelect(object sender, TreeViewEventArgs e)
    {
        
    }

    private void Back_Click(object sender, EventArgs e)
    {
        Application.ExitThread();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Thread NameField = new Thread(Namebox);
        NameField.Start();
        Application.ExitThread();
        
    }

    private void Namebox()
    {
        Application.Run(new DirCreate());
    }

    private void Reopen()
    {
        Application.Run(new Database_Work());
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Thread SelImg = new Thread(ImgSelect);
        SelImg.Start();
    }

    private void ImgSelect()
    {
        Application.Run(new SelectImage());
    }

    public static string Node;
    private void Database_View_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        string NodeSelected = e.Node.Text;
        Node = NodeSelected;
        ShowSelection.Text = NodeSelected;
    }

    private void ShowSelection_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void Delete_Click(object sender, EventArgs e)
    {
        if(Node != "")
        {
            Directory.Delete(DbPath + "\\" + Node, true);
            var Restart = new Thread(Reopen);
            Restart.Start();
            Application.ExitThread();
        }
    }
}