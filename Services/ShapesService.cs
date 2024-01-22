using MakingNewDatabase.Data;
using MakingNewDatabase.Models;

namespace MakingNewDatabase.Services;

public class ShapesService : IShapesService
{
    private readonly DataContext _db;

    public ShapesService(DataContext db)
    {
        _db = db;
    }

    public List<Shapes> GetData()
    {
        return _db.Shapes.ToList();
    }

    public string InputShape(string name, string shape)
    {
        Shapes s = new();
        s.Name = name;
        s.FavShape = shape;
        _db.Shapes.Add(s);
        _db.SaveChanges();

        return $"Your name is {name} and your favorite shape is a {shape}";
    }
}
