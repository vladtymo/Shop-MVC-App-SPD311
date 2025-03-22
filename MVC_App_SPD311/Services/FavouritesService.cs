using MVC_App_SPD311.Data;
using MVC_App_SPD311.Extensions;
using MVC_App_SPD311.Models;

namespace MVC_App_SPD311;

public class FavouritesService
{
    private readonly ISession _session;
    private readonly FootballDbContext _context;
    private const string key = "favourite_list";
    
    public FavouritesService(IHttpContextAccessor accessor, FootballDbContext context)
    {
        this._session = accessor.HttpContext.Session;
        _context = context;
    }
    
    public List<int> GetIds()
    {
        return _session.Get<List<int>>(key) ?? new();
    }
    public List<Team> GetAll()
    {
        var ids = GetIds();
        return _context.FootballTeams.Where(x => ids.Contains(x.Id)).ToList();
    }

    public void Add(int id)
    {
        var ids = GetIds();
        ids.Add(id);
        _session.Set(key, ids);
    }
    
    public void Remove(int id)
    {
        var ids = GetIds();
        ids.Remove(id);
        _session.Set(key, ids);
    }
    
    public void Clear()
    {
        _session.Remove(key);
    }
}