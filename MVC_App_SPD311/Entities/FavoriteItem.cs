using Microsoft.AspNetCore.Identity;

namespace MVC_App_SPD311.Models;

public class FavoriteItem
{
    //public int Id { get; set; }
    
    // Composite Primary Key
    public string UserId { get; set; } 
    public Team? User { get; set; }
    public int TeamId { get; set; } 
    public Team? Team { get; set; }
}