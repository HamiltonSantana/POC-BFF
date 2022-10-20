using System;
using System.Threading.Tasks;
using Domain.Entities;
using Infraestructure.DataAccess;
using Services.Interfaces;

namespace Services
{
    public class CategorieService : ICategorieService
    {
        private DataContext _dataContext;

        public CategorieService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> Add(Categorie categorie)
        {
            var result = _dataContext.Categorie.Add(categorie);
            _dataContext.SaveChanges();
            return result.Entity.Id;
        }

        public Task Delete(int id)
        {
            _dataContext.Remove(_dataContext.Categorie.Find(id));
            return Task.CompletedTask;
        }

        public Categorie GetCategorie(int id)
        {
            return _dataContext.Categorie.Find(id);
        }

        public Task Update(Categorie categorie)
        {
            _dataContext.Categorie.Update(categorie);
            _dataContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}