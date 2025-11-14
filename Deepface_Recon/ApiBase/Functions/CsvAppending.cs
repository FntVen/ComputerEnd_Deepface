using System.Globalization;
using CsvHelper;
using Deepface_Recon.ApiBase.Model;

namespace Deepface_Recon.ApiBase.Functions;

public class CsvAppending
{
    public void CsvArgWork(string Session)
    {
       
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);
        string ArgPath = Final + "\\Resources\\Temp";
        if (File.Exists(ArgPath + "\\CSVArgument.csv") == false)
        {
            File.WriteAllText(ArgPath + "\\CSVArgument.csv", "Argument,Mode,Sync\n");
            File.AppendAllText(ArgPath + "\\CSVArgument.csv", $"{Session},0,0\n");
        }
        else
        {
            File.AppendAllText(ArgPath + "\\CSVArgument.csv", $"{Session},0,0\n");
        }

        
        
    }
}