using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategorieController : ControllerBase
{
    [HttpGet]
    public void Get()
    {
    }
}
