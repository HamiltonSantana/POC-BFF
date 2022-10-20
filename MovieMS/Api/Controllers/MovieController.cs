using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieServices;

    public MovieController(IMovieService movieServices)
    {
        _movieServices = movieServices;
    }

    [HttpGet]
    public Movie GetMovie(int id)
    {
        return _movieServices.GetMovie(id);
    }

    [HttpPost]
    public IActionResult AddMovieAsync(Movie movie)
    {
        _movieServices.Add(new Movie { Description = movie.Description, Name = movie.Name, CategorieID = movie.CategorieID });

        return Ok(200);
    }

    [HttpPost("/updateMovie")]
    public IActionResult UpdateMovie(Movie movie)
    {
        _movieServices.Update(movie);

        return Ok(200);
    }

    [HttpDelete]
    public IActionResult DeleteMovie(int id)
    {
        _movieServices.Delete(id);
        return Ok(200);
    }
}
