using Asp.net_s2.Model;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_s2.Controllers
{
    public class MovieController : Controller
    {
        //private IConfiguration _configuration;
        //public MovieController(IConfiguration configuration)//ask Clr for CREATING  object from class implement IConfiguration To use app setting
        //{

        //    _configuration = configuration;
        //}


        //Action :public not static object member method inside the controller


        //baseUrl/Movies/GetMovie
        //ways to bind the data
        //1. from route data  //baseUrl/Movies/GetMovie/10
        //2. from query string  //baseUrl/Movies/GetMovie?id=10
        //3. from html form  //baseUrl/Movies/GetMovie/10?movie.name=aaa;movie.id=12
        //4. from Header form  //baseUrl/Movies/GetMovie/10

        [HttpGet]
        public IActionResult GetMovie([FromHeader]int id,[FromHeader]Movie movie)
        {

          //  if (id == 0)
                //  return new BadRequestResult();
          //     return BadRequest(); //Helper Method
            if (id == 100)
                // return new NotFoundResult();
                return NotFound();//Helper method
                                  // ContentResult result = new ContentResult();
                                  //    result.Content = $"<h1> MoiveId:{id} </h1>"; //int could return Html becasue i said it will be text/html for type
                                  //    result.ContentType = "text/html" ;
                                  //  result.ContentType = "object/pdf";//here i say the response whose(0 and 1) will come as pdf"
                                  //   result.StatusCode = 200 ;
                                  //   return result;
            return Content($"<h1> MoiveId:{id} MovienName:{movie.Name} </h1> ", "text/html");//Helper method


        }

        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            return new OkResult();

        }


        [HttpGet]
        //baseUrl/Movies/Redirect
        //second way for make di provide object from Iconfiguration
        public IActionResult Redirect([FromServices] IConfiguration _configuration)
        {
            RedirectResult obj = new RedirectResult(_configuration["JustRedirection"]!);//give it the key in app setting

            //     if you want to redirect to endpoint you create it
            obj = new RedirectResult("https://localhost:7015/Movies/GetMovie/12");
            //but https://localhost:7015 could change depends on the phase ! so put it in app setting
            obj = new RedirectResult($"{_configuration["ToEndPoint"]} Movies/GetMovie/12");
            return obj;

        }



        //   [ActionName("GetAllMovie")]
        public string Index()
        {
            return $"AllMoive";
        }


    }
}

