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

    public List<Shapes> InputShape(string name, string shape)
    {
        Shapes s = new();
        s.Name = name;
        s.ShapeName = shape;
        _db.Shapes.Add(s);
        _db.SaveChanges();

        return _db.Shapes.ToList();
    }
}
