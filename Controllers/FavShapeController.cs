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
}
