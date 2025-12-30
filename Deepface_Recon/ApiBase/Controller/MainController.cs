using Deepface_Recon;
using Microsoft.AspNetCore.Mvc;
using Deepface_Recon.ApiBase.Model;
using Deepface_Recon.ApiBase.Functions;
using Deepface_Recon.General_Fuctions;


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
            PrintImage.Img64(model.thing, model.Session, model.TimeFrame);

            var PassArgs = new CsvAppending();
            PassArgs.CsvArgWork(model.Session);
           
            ConsoleWork.ConsoleFormating(model.Session, model.Device);
            
            return StatusCode(201);
        }
    }

