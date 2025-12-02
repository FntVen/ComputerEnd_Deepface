﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Net;
using Deepface_Recon.General_Fuctions;
using System.Windows;

namespace Deepface_Recon;

public partial class Rela_Create : Form
{
    public Rela_Create()
    {
        InitializeComponent();
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";
        TempFolder = ArgPath;
        string SessionsPath = Final + "\\Resources\\Sessions";
        Abspath = Final;
        
        
        string[] SessionsList = Directory.GetDirectories(SessionsPath);
        if (SessionsList.Length != 0)
        {
            foreach (string sessionPath in SessionsList)
            {
                string sessionName = Path.GetFileNameWithoutExtension(sessionPath);
                ComboSessãoList.Items.Add(sessionName);
            }
        }
    }
    private static string Abspath;
    private void Pycaller()
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


    private static string TempFolder;
    private void ComboSessãoList_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void Confirm_Click(object sender, EventArgs e)
    {
        if(ComboSessãoList.SelectedIndex != -1)
        {
            string Sessão = ComboSessãoList.SelectedItem.ToString();
            File.WriteAllText(TempFolder + "\\Order.txt", Sessão);
            Pycaller();
            Application.ExitThread();
        }
    }
}