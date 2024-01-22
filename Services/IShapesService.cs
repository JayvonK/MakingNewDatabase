using MakingNewDatabase.Models;

namespace MakingNewDatabase.Services;

    public interface IShapesService
    {
        List<Shapes> GetData();
        string InputShape(string name, string shape);
    }
