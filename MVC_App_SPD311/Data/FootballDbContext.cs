using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311.Models;

namespace MVC_App_SPD311.Data;

public class FootballDbContext : DbContext
{
    public DbSet<Team> FootballTeams { get; set; }

    public FootballDbContext() {  }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            var str = "workstation id=shop-db.mssql.somee.com;packet size=4096;user id=wladnaz_SQLLogin_1;pwd=qsyiy5d3ff;data source=shop-db.mssql.somee.com;persist security info=False;initial catalog=shop-db;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(str);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasData(
            new Team { Id = 1, Logo = "https://upload.wikimedia.org/wikipedia/en/4/47/FC_Barcelona_%28crest%29.svg", Name = "FC Barcelona", Players = 26, Country = "Spain" },
            new Team { Id = 2, Logo = "https://upload.wikimedia.org/wikipedia/en/5/56/Real_Madrid_CF.svg", Name = "Real Madrid", Players = 25, Country = "Spain" },
            new Team { Id = 3, Logo = "https://upload.wikimedia.org/wikipedia/en/7/7a/Manchester_United_FC_crest.svg", Name = "Manchester United", Players = 24, Country = "England" },
            new Team { Id = 4, Logo = "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg", Name = "Manchester City", Players = 25, Country = "England" },
            new Team { Id = 5, Logo = "https://upload.wikimedia.org/wikipedia/en/0/0c/Liverpool_FC.svg", Name = "Liverpool", Players = 26, Country = "England" },
            new Team { Id = 6, Logo = "https://upload.wikimedia.org/wikipedia/en/a/a7/Paris_Saint-Germain_F.C..svg", Name = "Paris Saint-Germain", Players = 27, Country = "France" },
            new Team { Id = 7, Logo = "https://upload.wikimedia.org/wikipedia/en/c/c5/Bayern_Munich_logo_%282017%29.svg", Name = "Bayern Munich", Players = 25, Country = "Germany" },
            new Team { Id = 8, Logo = "https://upload.wikimedia.org/wikipedia/en/6/67/Borussia_Dortmund_logo.svg", Name = "Borussia Dortmund", Players = 24, Country = "Germany" },
            new Team { Id = 9, Logo = "https://upload.wikimedia.org/wikipedia/en/d/d2/Juventus_FC_2017_logo.svg", Name = "Juventus", Players = 26, Country = "Italy" },
            new Team { Id = 10, Logo = "https://upload.wikimedia.org/wikipedia/en/0/05/Inter_Milan_2021_logo.svg", Name = "Inter Milan", Players = 24, Country = "Italy" },
            new Team { Id = 11, Logo = "https://upload.wikimedia.org/wikipedia/commons/d/d0/Logo_of_AC_Milan.svg", Name = "AC Milan", Players = 25, Country = "Italy" },
            new Team { Id = 12, Logo = "https://upload.wikimedia.org/wikipedia/en/5/53/Arsenal_FC.svg", Name = "Arsenal", Players = 24, Country = "England" },
            new Team { Id = 13, Logo = "https://upload.wikimedia.org/wikipedia/en/c/cc/Chelsea_FC.svg", Name = "Chelsea", Players = 25, Country = "England" },
            new Team { Id = 14, Logo = "https://upload.wikimedia.org/wikipedia/en/f/f4/Atletico_Madrid_2017_logo.svg", Name = "Atletico Madrid", Players = 24, Country = "Spain" },
            new Team { Id = 15, Logo = "https://upload.wikimedia.org/wikipedia/en/2/28/SSC_Napoli.svg", Name = "Napoli", Players = 24, Country = "Italy" },
            new Team { Id = 16, Logo = "https://upload.wikimedia.org/wikipedia/en/0/04/AS_Roma_logo_%282017%29.svg", Name = "AS Roma", Players = 23, Country = "Italy" },
            new Team { Id = 17, Logo = "https://upload.wikimedia.org/wikipedia/en/b/b4/Tottenham_Hotspur.svg", Name = "Tottenham Hotspur", Players = 24, Country = "England" },
            new Team { Id = 18, Logo = "https://upload.wikimedia.org/wikipedia/en/8/86/Sevilla_FC_logo.svg", Name = "Sevilla", Players = 25, Country = "Spain" },
            new Team { Id = 19, Logo = "https://upload.wikimedia.org/wikipedia/en/a/a5/RB_Leipzig_2014_logo.svg", Name = "RB Leipzig", Players = 24, Country = "Germany" },
            new Team { Id = 20, Logo = "https://upload.wikimedia.org/wikipedia/en/7/7f/Ajax_Amsterdam.svg", Name = "Ajax", Players = 25, Country = "Netherlands" }
        );
    }
}