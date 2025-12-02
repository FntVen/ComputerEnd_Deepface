﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Net;
using Deepface_Recon.General_Fuctions;
using System.Windows;


namespace Deepface_Recon;

public partial class MainMenu : Form
{
    public delegate void delUpdateUITextBox(string txt);
    private ThreadStart Inicializar;
    private Thread Updates;
    public MainMenu()
    {
        string hostName = Dns.GetHostName(); // Retrive the Name of HOST
        
        var myIP = Dns.GetHostByName(hostName).AddressList;
        
        
        InitializeComponent();
        
        foreach (var ip in myIP)
        {
            if (ip.ToString().Contains(":") == false && ip.ToString().Contains("192"))
            {
                richTextBox1.Text = "http://" + ip.ToString() + ":5000" + "/deepface";
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
            Iniciar.Text = "Iniciar";
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
                Thread CheckConsoleFile = new Thread(ConsoleStart);
                CheckConsoleFile.Name = "CheckConsoleFile";
                CheckConsoleFile.Start();
            }
            ApiFlag = 1;
        }
        
    }

    private void ConsoleStart()
    {
        if (ConsoleWork.ConsoleFileLock == 0)
        {
            ConsoleWork.ConsoleFileLock = 1;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string[] segpath = path.Split("\\");
            List<string> segpathList = segpath.ToList();
            segpathList.RemoveAt(segpathList.Count - 1);
            segpathList.RemoveAt(segpathList.Count - 1);
            string Final = String.Join("\\", segpathList);
            string ArgPath = Final + "\\Resources\\Temp";
            while (true)
            {
                string[] ConsoleLog = File.ReadAllLines(ArgPath + "\\ConsoleWrite.txt");
                string[] Comp = File.ReadAllLines(ArgPath + "\\a.txt");
                ConsoleWork.ConsoleFileLock = 0;
                if (ConsoleLog != Comp)
                {
                    string ConsoleLastLine = ConsoleLog[ConsoleLog.GetUpperBound(0)];
                    if(this.InvokeRequired)
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate { ConsoleUpdate(ConsoleLog); });
                    }
                    else
                    {
                        ConsoleUpdate(ConsoleLog);
                    }
                }
                else
                {
                    ConsoleUpdate([]);
                }
                if(ButtonToggle == 0)
                {
                    break;
                }
            
            }
        }
    }

    private void ConsoleUpdate(string[] ConsoleMessage)
    {
        string[] LatestLog = [];
        if(LatestLog != ConsoleMessage)
        {
            UserConsole.Text = "";

            foreach(string line in ConsoleMessage)
            {
                UserConsole.AppendText(line + "\n");
            }
        }
        else
        {
            UserConsole.Text = "Loading \n";
            Thread.Sleep(1000);
            UserConsole.Text = "Loading. \n";
            Thread.Sleep(1000);
            UserConsole.Text = "Loading.. \n";
            Thread.Sleep(1000);
            UserConsole.Text = "Loading... \n";
            Thread.Sleep(1000);
        }

        LatestLog = ConsoleMessage;
    }

    private void OffApi()
    {
    }


    private void Entenda_Click(object sender, EventArgs e)
    {
        
    }

    private void Ver_R_Click(object sender, EventArgs e)
    {
        Thread VerRela = new Thread(RelatorioVer);
        VerRela.Start();
    }

    private void RelatorioVer()
    {
        Application.Run(new Rela_Look());
    }

    private void Criar_R_Click(object sender, EventArgs e)
    {
        Thread ThreadCriar = new Thread(RelatorioMenu);
        ThreadCriar.Start();
        //Pycaller();
    }

    private static void RelatorioMenu()
    {
        Application.Run(new Rela_Create());
    }

    
    

    

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void UserConsole_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void Databases_Click(object sender, EventArgs e)
    {
        Thread GenDb = new Thread(DbCaller);
        GenDb.Start();
    }

    private void DbCaller()
    {
        Application.Run(new Database_Work());
    }

}