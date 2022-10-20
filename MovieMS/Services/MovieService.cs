using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infraestructure.DataAccess;
using Service.Interfaces;

namespace Services
{
    public class MovieService : IMovieService
    {
        private DataContext _datacontext;

        public MovieService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<int> Add(Movie movie)
        {
            using (_datacontext)
            {
                if (_datacontext.Movie.Any(e => e.Id == movie.Id))
                    throw new InvalidOperationException("Movie already exist");

                var result = _datacontext.Movie.Add(movie);
                _datacontext.SaveChanges();
                return result.Entity.Id;
            }
        }

        public Task Delete(int id)
        {
            using (_datacontext)
            {
                var movie = _datacontext.Movie.Find(id);
                _datacontext.Remove(movie);
                _datacontext.SaveChanges();
                return Task.CompletedTask;
            }
        }

        public Movie GetMovie(int id)
        {
            using(_datacontext)
            {
                return  _datacontext.Movie.Find(id);
            }
        }

        public Task Update(Movie movie)
        {
            using(_datacontext)
            {
                if(!_datacontext.Movie.Any(e => e.Id == movie.Id))
                    throw new InvalidOperationException("Movie don't exist");

                var currentMovie = _datacontext.Movie.Find(movie.Id);
                currentMovie.Name = movie.Name;
                currentMovie.Description = movie.Description;
                currentMovie.CategorieID = movie.CategorieID;
                _datacontext.SaveChanges();
                return Task.CompletedTask;
            }
        }
    }
}