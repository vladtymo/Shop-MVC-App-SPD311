using MVC_App_SPD311.Models;

namespace MVC_App_SPD311.Interfaces;

public interface IFavoriteService
{
    List<int> GetIds();
    List<Team> GetAll();
    void Add(int id);
    void Remove(int id);
    void Clear();
    int GetCount();
}