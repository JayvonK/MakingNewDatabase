using MakingNewDatabase.Models;
using MakingNewDatabase.Services;
using Microsoft.AspNetCore.Mvc;

namespace MakingNewDatabase.Controllers;

[ApiController]
[Route("[controller]")]
public class FavShapeController : ControllerBase
{
    private readonly IShapesService _shapes;

    public FavShapeController(IShapesService shapes)
    {
        _shapes = shapes;
    }

    [HttpGet]
    [Route("GetData")]
    public List<Shapes> GetData()
    {
        return _shapes.GetData();
    }

    [HttpPost]
    [Route("AddNameAndFavShape/{name}/{shape}")]

    public string AddFavShape(string name, string shape)
    {
        return _shapes.InputShape(name, shape);
    }
}
