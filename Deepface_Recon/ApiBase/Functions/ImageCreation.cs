using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using Image = SixLabors.ImageSharp.Image;


namespace Deepface_Recon.ApiBase.Functions;

public class ImageCreation
{
    public void Img64(string B64, string Session, int TimeFrame)
    {
        byte[] ImgBytes = Convert.FromBase64String(B64);
        string path = AppDomain.CurrentDomain.BaseDirectory;
        string[] segpath = path.Split("\\");
        List<string> segpathList = segpath.ToList();
        segpathList.RemoveAt(segpathList.Count - 1);
        segpathList.RemoveAt(segpathList.Count - 1);
        string Final = String.Join("\\", segpathList);

        if (Directory.Exists(Final + "\\Resources\\" + "Sessions\\" + Session) == false)
        {
            Directory.CreateDirectory(Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTS\\");
            Directory.CreateDirectory(Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTA\\");
            Directory.CreateDirectory(Final + "\\Resources\\" + "Sessions\\" + Session + "\\CSVtemps\\");
            Directory.CreateDirectory(Final + "\\Resources\\" + "Sessions\\" + Session + "\\TimeLog\\");
        }

        var CorrectedTime = TimeFrame;
        int flag = 0;
        string extension = "Seconds";
        
        string Time = DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString();
        if (TimeFrame >= 60)
        {
            CorrectedTime = TimeFrame / 60;
            flag = 1;
        }
        if (CorrectedTime >= 60)
        {
            CorrectedTime = CorrectedTime / 60;
            flag = 2;
        }

        switch (flag)
        {
            case 1:
                extension = "Minutes";
                break;
            case 2:
                extension = "Hours";
                break;
        }
        
        if (File.Exists(Final + "\\Resources\\" + "Sessions\\" + Session + "\\TimeLog\\" + "TimeDecoder.csv") == false)
        {
            File.WriteAllText(Final + "\\Resources\\" + "Sessions\\" + Session + "\\TimeLog\\" + "TimeDecoder.csv", "FileName,TakenTime\n");
            File.AppendAllText(Final + "\\Resources\\" + "Sessions\\" + Session + "\\TimeLog\\" + "TimeDecoder.csv", Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTS\\" + Time + ".png," + CorrectedTime + " " + extension + "\n");
        }
        else
        {
            File.AppendAllText(Final + "\\Resources\\" + "Sessions\\" + Session + "\\TimeLog\\" + "TimeDecoder.csv", Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTS\\" + Time + ".png," + CorrectedTime + " " + extension + "\n");
        }

        using (Image img = Image.Load(ImgBytes))
        {
            img.Save(Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTS\\" + Time + ".png", new PngEncoder());
        }
    }
    
}