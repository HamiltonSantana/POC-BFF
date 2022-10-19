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
    public async Task<int> AddMovieAsync(Movie movie)
    {
        return await _movieServices.Add(new Movie { Description =  movie.Description, Name = movie.Name});

    }
}
