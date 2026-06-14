//using BL.Api;
//using ConsoleApp1.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace API.Controllers
//{
//    public class ClientsController : Controller
//    {
//        IBL bl;
//        public ClientsController(IBL bl) {
//            this.bl = bl;
//        } 

//        [HttpGet]
//        [Route("api/Read")]
//        public List<BlClient> Read()
//        {
//            return bl.Client.Read();
//        }

//    }
//}
