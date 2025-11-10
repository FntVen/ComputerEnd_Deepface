using System;
using System.Collections.Generic;
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
    }

    private static int ButtonToggle = 0;
    private static int ApiFlag = 0;

    public void ChangeName(string name)
    {
        DeviceName.Text = ImgInModelStatic.Device;
    }

    private void Iniciar_Click(object sender, EventArgs e)
    {
        
        if (ButtonToggle == 1)
        {
            Iniciar.BackColor = Color.FromArgb(10,29,44);
            ButtonToggle = 0;
        }
        else
        {
            ButtonToggle = 1;
            Iniciar.BackColor = Color.Green;
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
        
    }

    private void DeviceName_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
}