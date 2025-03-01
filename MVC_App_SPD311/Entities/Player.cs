namespace MVC_App_SPD311.Models;

public class Player
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Goals { get; set; }
    public int Number { get; set; }
    public DateTime Birthdate { get; set; }
    
    public int TeamId { get; set; }
    public Team Team { get; set; }
}