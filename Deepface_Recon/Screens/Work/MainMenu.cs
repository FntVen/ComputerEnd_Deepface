using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net;
using Deepface_Recon.ApiBase.Model;

namespace Deepface_Recon;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        string hostName = Dns.GetHostName(); // Retrive the Name of HOST
        
        var myIP = Dns.GetHostByName(hostName).AddressList;
        

        
        InitializeComponent();
        
        foreach (var ip in myIP)
        {
            if (ip.ToString().Contains(":") == false)
            {
                richTextBox1.Text = "http://" + ip.ToString() + ":500" + "/deepface";
                break;
            }
        }
        
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        Abspath = Final;
        
    }

    private static string Abspath;
    private static int ButtonToggle = 0;
    private static int ApiFlag = 0;

    public void ChangeName(string name)
    {
        
    }

    private void Iniciar_Click(object sender, EventArgs e)
    {
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";
        
        if (ButtonToggle == 1)
        {
            Iniciar.BackColor = Color.FromArgb(10,29,44);
            ButtonToggle = 0;
        }
        else
        {
            ButtonToggle = 1;
            File.WriteAllText(ArgPath + "\\CSVArgument.csv", "Argument,Mode,Sync\n");
            Iniciar.BackColor = Color.Green;
            Iniciar.Text = "Rodando";
            if (ApiFlag == 0)
            {
                Program.PageSwitch(5);
                
            }
            ApiFlag = 1;
        }
        
    }

    

    private void Entenda_Click(object sender, EventArgs e)
    {
        
    }

    private void Ver_R_Click(object sender, EventArgs e)
    {
        
    }

    private void Criar_R_Click(object sender, EventArgs e)
    {
        try
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "C:\\Program Files\\Python312\\python.exe", // Path to the executable of the desired application
                Arguments = Abspath + "\\Resources\\Python\\Pre2Águia-Eye.py", // Path to the file to open, enclosed in quotes
                UseShellExecute = false // Set to false to directly launch the specified application
            };

            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening file with specific application: {ex.Message}");
        }
    }

    private void DeviceName_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
}