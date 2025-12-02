namespace Deepface_Recon.General_Fuctions;

public class ConsoleWork
{
    public static int ConsoleFileLock = 0;
    public static void ConsoleFormating(string Session, string ModelDevice)
    {
        if (ConsoleFileLock == 0)
        {
            ConsoleFileLock = 1;

            string Log = "Na sessão " + Session + " recebendo imagem do dispositivo " + ModelDevice;
        
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string[] segpath = path.Split("\\");
            List<string> segpathList = segpath.ToList();
            segpathList.RemoveAt(segpathList.Count - 1);
            segpathList.RemoveAt(segpathList.Count - 1);
            string Final = String.Join("\\", segpathList);
            string ArgPath = Final + "\\Resources\\Temp";
        
            File.AppendAllText(ArgPath + "\\ConsoleWrite.txt", Log + "\n");
        
            ConsoleFileLock = 0;
        }
        else
        {
            Thread.Sleep(1000);
            ConsoleFormating(Session, ModelDevice);
        }
    }
}