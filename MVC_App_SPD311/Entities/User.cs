using Microsoft.AspNetCore.Identity;

namespace MVC_App_SPD311.Models;

public class User : IdentityUser
{
   // add custom properties
   public DateTime Birthdate { get; set; }
}