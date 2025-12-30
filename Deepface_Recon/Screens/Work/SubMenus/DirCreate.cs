namespace Deepface_Recon.SubMenus;

public partial class DirCreate : Form
{
    public DirCreate()
    {
        InitializeComponent();
    }

    private void dbNameField_TextChanged(object sender, EventArgs e)
    {
       
    }

    private void GoBackDb()
    {
        Application.Run(new Database_Work());
    }


    private void Confirm_Click(object sender, EventArgs e)
    {
        string DatabasePath = Database_Work.DbPath;
        if(dbNameField.Text != "")
        {
            Directory.CreateDirectory(DatabasePath + "\\"  + dbNameField.Text);
            var DbScreen = new Thread(GoBackDb);
            DbScreen.Start();
            Application.ExitThread();
        }
    }
}