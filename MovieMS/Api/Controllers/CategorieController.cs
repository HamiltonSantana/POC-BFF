using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategorieController : ControllerBase
    {
        private readonly ICategorieService _categorieService;

        public CategorieController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }

        [HttpGet]
        public Categorie GetCategorie(int id)
        {
            return _categorieService.GetCategorie(id);
        }

        [HttpPost]
        public IActionResult AddCategorie(Categorie categorie)
        {
             _categorieService.Add(new Categorie { Name = categorie.Name});
             return Ok(200);
        }
    }
}
