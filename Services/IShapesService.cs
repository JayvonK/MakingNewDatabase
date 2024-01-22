using MakingNewDatabase.Models;

namespace MakingNewDatabase.Services;

    public interface IShapesService
    {
        List<Shapes> InputShape(string name, string shape);
    }
