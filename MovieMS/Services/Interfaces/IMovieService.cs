using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Service.Interfaces
{
    public interface IMovieService : IBaseService<Movie>
    {
        Movie GetMovie(int id);
    }
}