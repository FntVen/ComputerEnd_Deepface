using Deepface_Recon.SubMenus;

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

    private void SetView()
    {
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
        TreeViewReFresh();
    }

    public static int Lock = 0;
    
    private void TreeViewReFresh()
    {
        while (true)
        {
            Thread.Sleep(1000);
            if(Lock == 1)
            {
                Lock = 0;
                Database_View.Nodes.Clear();
                SetView();
                break;
            }
        }
    }

    private void Namebox()
    {
        Application.Run(new DirCreate());
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
}