using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramApi.Core.ExternalServices.InstagramApi;
using InstagramApi.Models.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace InstagramApi.Controllers
{
    public class InstagramController : Controller
    {
        public IActionResult Index()
        {
            InstagramManager ınsta = new InstagramManager();
            ViewBag.images = ınsta.GetAllImage("tokenBilgisi");          
            return View();
        }
    }
}