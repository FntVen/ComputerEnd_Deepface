namespace Deepface_Recon;

public partial class SelectImage : Form
{
    public SelectImage()
    {
        InitializeComponent();
        CreateNote1("C:\\", "Inside");
    }

    private static string CurrentFolder;
    private void CreateNote1(string PathtoShow, string Coming_From)
    {
        if (Coming_From == "Inside")
        {
            FileSearcher.Nodes.Clear();
            var NewTreeNode = new TreeNode(PathtoShow,0 ,0);
            NewTreeNode.Tag = PathtoShow;
        
            string[] BaseFolders = Directory.GetDirectories(PathtoShow);
            CurrentFolder = PathtoShow;
            foreach(string folder in BaseFolders)
            {
                var tempNode = new TreeNode(Path.GetFileName(folder));
                tempNode.Tag = folder;
                NewTreeNode.Nodes.Add(tempNode);
                NewTreeNode.Expand();
            }
            string[] BaseFiles = Directory.GetFiles(PathtoShow);
            foreach (string file in BaseFiles)
            {
                var tempNode = new TreeNode(Path.GetFileName(file));
                tempNode.Tag = file;
                NewTreeNode.Nodes.Add(tempNode);
            }

            FileSearcher.Nodes.Add(NewTreeNode);
        }
        else
        {
            if(Directory.GetFiles(CurrentFolder).Contains(PathtoShow))
            {
                ChooseImg(PathtoShow);
            }
            else
            {
                FileSearcher.Nodes.Clear();
                var NewTreeNode = new TreeNode(PathtoShow,0 ,0);
                NewTreeNode.Tag = PathtoShow;
        
                string[] BaseFolders = Directory.GetDirectories(PathtoShow);
                CurrentFolder = PathtoShow;
                foreach(string folder in BaseFolders)
                {
                    var tempNode = new TreeNode(Path.GetFileName(folder));
                    tempNode.Tag = folder;
                    NewTreeNode.Nodes.Add(tempNode);
                    NewTreeNode.Expand();
                }
                string[] BaseFiles = Directory.GetFiles(PathtoShow);
                foreach (string file in BaseFiles)
                {
                    var tempNode = new TreeNode(Path.GetFileName(file));
                    tempNode.Tag = file;
                    NewTreeNode.Nodes.Add(tempNode);
                }

                FileSearcher.Nodes.Add(NewTreeNode);
            
            }
        }
        
    }

    private void ChooseImg(string PathtoShow)
    {
        if (PathtoShow.Contains(".png") || PathtoShow.Contains(".jpg") || PathtoShow.Contains(".jpeg"))
        {
            string PathtoSaveDir = Database_Work.DbPath;
            string NodetoSave = Database_Work.Node;
            string imgName = Path.GetFileName(PathtoShow);
            File.Move(PathtoShow, PathtoSaveDir + "\\" + NodetoSave + "\\" + imgName);
            Application.ExitThread();
        }
    }

    private void Back_Click(object sender, EventArgs e)
    {
        string[] FolderPathSplit = CurrentFolder.Split("\\");
        
        if(FolderPathSplit.Length > 1)
        {
            string LastNameIndex = FolderPathSplit.Last();
            string path = "";

            foreach(string step in FolderPathSplit)
            {
                if(step != LastNameIndex &&  step != "")
                {
                    path = path + step + "\\";
                    
                    //Path.Combine()
                }
            }
            path = Path.TrimEndingDirectorySeparator(path);
            CreateNote1(path, "Outside");
        }
    }

    private void FileSearcher_AfterSelect(object sender, TreeViewEventArgs e)
    {
        
    }

    private void Sel_File_Click(object sender, EventArgs e)
    {
        string SelectedNode = FileSearcher.SelectedNode.FullPath;
        CreateNote1(SelectedNode, "Outside");
    }

    private void Sel_Dir_Click(object sender, EventArgs e)
    {
        if(DirofChoice != string.Empty)
        {
            foreach (string file in Directory.GetFiles(DirofChoice))
            {
                if(file.Contains(".png") || file.Contains(".jpg") || file.Contains(".jpeg"))
                {
                    string PathtoSaveDir = Database_Work.DbPath;
                    string NodetoSave = Database_Work.Node;
                    string imgName = Path.GetFileName(file);
                    File.Move(file, PathtoSaveDir + "\\" + NodetoSave + "\\" + imgName);
                    Application.ExitThread();
                }
            }
        }
    }

    private void FileSearcher_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        string SelectedNode = e.Node.FullPath;
        CreateNote1(SelectedNode, "Outside");
    }

    private static string DirofChoice;
    private void FileSearcher_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        if (Directory.Exists(e.Node.FullPath))
        {
            DirofChoice = e.Node.FullPath;
        }
    }
}