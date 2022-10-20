using System;
using Domain.Entities;
using Service.Interfaces;

namespace Services.Interfaces
{
    public interface ICategorieService : IBaseService<Categorie>
    {
       Categorie GetCategorie(int id);
    }
}