using Microsoft.AspNetCore.Mvc;
using Moviegram.Repositories;

namespace Moviegram.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviePostRepository moviePostRepository;

        public MoviesController(IMoviePostRepository moviePostRepository)
        {
            this.moviePostRepository = moviePostRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Index(string urlHandle)
        {
            var moviePost = await moviePostRepository.GetByUrlHandleAsync(urlHandle);
            return View(moviePost);
        }
    }
}
