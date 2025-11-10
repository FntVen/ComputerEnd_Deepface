using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using Image = SixLabors.ImageSharp.Image;


namespace Deepface_Recon.ApiBase.Functions;

public class ImageCreation
{
    public void Img64(string B64, string Session)
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
        }

        string Time = DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + "." + DateTime.Now.Millisecond.ToString();

        using (Image img = Image.Load(ImgBytes))
        {
            img.Save(Final + "\\Resources\\" + "Sessions\\" + Session + "\\PicturesTS\\" + Time + ".png", new PngEncoder());
        }
    }
    
}