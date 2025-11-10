using Deepface_Recon;
using Microsoft.AspNetCore.Mvc;
using Deepface_Recon.ApiBase.Model;
using Deepface_Recon.ApiBase.Functions;


    [ApiController]
    [Route("deepface/[controller]")]
    public class Controller : ControllerBase
    {
        //private readonly Repository.Repository _Repo;
        private readonly ImgInModel _Model;

        //public  Controller(Repository.Repository repo)
        public Controller(ImgInModel model)
        {
            _Model = model;
        }
        
        
        
        [HttpPost]
        public IActionResult AttemptPost([FromBody] ImgInModel model)
        {
            
            var PrintImage = new ImageCreation();
            PrintImage.Img64(model.thing, model.Session);

            var changename = new MainMenu();
            changename.ChangeName(ImgInModelStatic.Device);
            
            ImgInModelStatic.Device = model.Device;
            ImgInModelStatic.thing = model.thing;
            ImgInModelStatic.Session = model.Session;
            ImgInModelStatic.TimeFrame = model.TimeFrame;
            
            return StatusCode(201);
        }
    }

