using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
{
    public class MoviesController : Controller
    {
        public string Index(int id)
        {
            return $"Welcome to the Movies Controller! ID: {id}";
        }
        public IActionResult GetMovie(int? Id, string name)
        {
            // ContentResult result = new ContentResult();
            // result.Content = $"Movie ID: {Id}, Movie Name: {name}";
            // result.ContentType = "text/html";
            // result.StatusCode = 900;
            // if (Id == null)
            // {
            //     return "Movie ID is null";
            // }
            // return Content($"Movie ID: {Id}, Movie Name: {name}");

            if(Id==0)
            {
                return new BadRequestResult();
            }
            else if(Id < 10)
            {
                return new NotFoundResult();
            }
            else
            {
                return Content($"Movie ID: {Id}, Movie Name: {name}"); 
            }
            
        }
        public IActionResult TestRedirect()
        {
            return Redirect("https://www.google.com");
        }
        public IActionResult TestRedirectToAction()
        {
            return RedirectToAction("GetMovie", new { Id = 16, name = "Inception" });
        }
        public IActionResult TestModelBinding([FromRoute]int id, [FromQuery]string name)
        {
            return Content($"Movie ID: {id}, Movie Name: {name}");
        }
        
    }
}