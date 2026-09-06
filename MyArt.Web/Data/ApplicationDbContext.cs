using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyArt.Web.Models;

namespace MyArt.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Technic> Technics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id =  1, LastName = "Banksy", PlaceOfBirth = "Yate (UK)", YearOfBirth = "1974" },
                new Artist { Id =  2, FirstName = "Gerrit", LastName = "Baten", PlaceOfBirth = "Aalst", YearOfBirth = "1959" },
                new Artist { Id =  3, FirstName = "Etienne", LastName = "Bauwens", PlaceOfBirth = "Aalst", YearOfBirth = "1930" },
                new Artist { Id =  4, FirstName = "Geert", LastName = "Bauwens", PlaceOfBirth = "Aalst", YearOfBirth = "1961" },
                new Artist { Id =  5, FirstName = "René", LastName = "Bekaert", PlaceOfBirth = "Aalst", YearOfBirth = "1938" },
                new Artist { Id =  6, FirstName = "André", LastName = "Berner", PlaceOfBirth = "Vilvoorde", YearOfBirth = "1955" },
                new Artist { Id =  7, FirstName = "Walter", LastName = "Brems", PlaceOfBirth = "Reet", YearOfBirth = "1947" },
                new Artist { Id =  8, FirstName = "Pedro", LastName = "Brugada", PlaceOfBirth = "Girona (ESP)", YearOfBirth = "1952" },
                new Artist { Id =  9, FirstName = "André", LastName = "Bruylandt", PlaceOfBirth = "Onkerzele", YearOfBirth = "1944" },
                new Artist { Id = 10, FirstName = "Randall", LastName = "Casaer", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 11, FirstName = "Roland", LastName = "Cobbaut", PlaceOfBirth = "Aalst", YearOfBirth = "1961" },
                new Artist { Id = 12, FirstName = "Claire", LastName = "Cocquyt", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 13, FirstName = "Raf", LastName = "Coorevits", PlaceOfBirth = "Sint-Niklaas", YearOfBirth = "1934" },
                new Artist { Id = 14, FirstName = "Tony", LastName = "De Bruycker", PlaceOfBirth = "Gent", YearOfBirth = "1950" },
                new Artist { Id = 15, FirstName = "Vigdis", LastName = "De Cauter", PlaceOfBirth = "Gent", YearOfBirth = "1974" },
                new Artist { Id = 16, FirstName = "Jeanne", LastName = "De Dijn", PlaceOfBirth = "Wichelen", YearOfBirth = "1919" },
                new Artist { Id = 17, FirstName = "Robert", LastName = "De keersmaecker", PlaceOfBirth = "Bornem", YearOfBirth = "1955" },
                new Artist { Id = 18, FirstName = "Luc", LastName = "De Mot", PlaceOfBirth = "Aalst", YearOfBirth = "1934" },
                new Artist { Id = 19, FirstName = "Pieter", LastName = "De Poortere", PlaceOfBirth = "Gent", YearOfBirth = "1976" },
                new Artist { Id = 20, FirstName = "Gino", LastName = "Dermaut", PlaceOfBirth = "Roeselare", YearOfBirth = "1951" },
                new Artist { Id = 21, FirstName = "Paul", LastName = "De Ryck", PlaceOfBirth = "Aalst", YearOfBirth = "1953" },
                new Artist { Id = 22, FirstName = "Jozef", LastName = "De Schrijver", PlaceOfBirth = "Aalst", YearOfBirth = "1916" },
                new Artist { Id = 23, FirstName = "François", LastName = "Deshommes", PlaceOfBirth = "Aalst", YearOfBirth = "1939" },
                new Artist { Id = 24, FirstName = "Theo", LastName = "De Smedt", PlaceOfBirth = "Aalst", YearOfBirth = "1938" },
                new Artist { Id = 25, FirstName = "Leen", LastName = "De Vos", PlaceOfBirth = "Aalst", YearOfBirth = "1952" },
                new Artist { Id = 26, FirstName = "Frans", LastName = "De Vree", PlaceOfBirth = "Aalst", YearOfBirth = "1934" },
                new Artist { Id = 27, FirstName = "Paul", LastName = "De Vylder", PlaceOfBirth = "Sint-Niklaas", YearOfBirth = "1942" },
                new Artist { Id = 28, FirstName = "Ignace", LastName = "Dierickx", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 29, FirstName = "Hans", LastName = "Droesbeke", PlaceOfBirth = "Geraardsbergen", YearOfBirth = "1968" },
                new Artist { Id = 30, FirstName = "Ronald", LastName = "Ergo", PlaceOfBirth = "Watervliet", YearOfBirth = "1936" },
                new Artist { Id = 31, FirstName = "", LastName = "Expha", PlaceOfBirth = "Gent", YearOfBirth = "" },
                new Artist { Id = 32, FirstName = "Leonor", LastName = "Fini", PlaceOfBirth = "Buenos Aires (ARG)", YearOfBirth = "1907" },
                new Artist { Id = 33, FirstName = "Rafaël", LastName = "Gorsen", PlaceOfBirth = "Merksem", YearOfBirth = "1942" },
                new Artist { Id = 34, FirstName = "Daniël", LastName = "Hardyns", PlaceOfBirth = "Gent", YearOfBirth = "1951" },
                new Artist { Id = 35, FirstName = "Henri", LastName = "Hemelsoet", PlaceOfBirth = "Westdorpe (NL)", YearOfBirth = "1955" },
                new Artist { Id = 36, FirstName = "Eveline", LastName = "Henderickx", PlaceOfBirth = "Aalst", YearOfBirth = "1931" },
                new Artist { Id = 37, FirstName = "Carla", LastName = "Heuvinck", PlaceOfBirth = "", YearOfBirth = "" },
                new Artist { Id = 38, FirstName = "Luc", LastName = "Hoenraet", PlaceOfBirth = "Aalst", YearOfBirth = "1941" },
                new Artist { Id = 39, FirstName = "Achiel", LastName = "Hutsebaut", PlaceOfBirth = "Hofstade", YearOfBirth = "1936" },
                new Artist { Id = 40, FirstName = "Octave", LastName = "Landuyt", PlaceOfBirth = "Gent", YearOfBirth = "1922" },
                new Artist { Id = 41, FirstName = "Fons", LastName = "Macharis", PlaceOfBirth = "Denderbelle", YearOfBirth = "1927" },
                new Artist { Id = 42, FirstName = "Mik", LastName = "Maes", PlaceOfBirth = "Aalst", YearOfBirth = "1959" },
                new Artist { Id = 43, FirstName = "", LastName = "MarieAnge", PlaceOfBirth = "Nieuwpoort", YearOfBirth = "1963" },
                new Artist { Id = 44, FirstName = "Frans", LastName = "Minnaert", PlaceOfBirth = "Idegem", YearOfBirth = "1929" },
                new Artist { Id = 45, FirstName = "Geert", LastName = "Opsomer", PlaceOfBirth = "Waregem", YearOfBirth = "1958" },
                new Artist { Id = 46, FirstName = "Wilhelm", LastName = "Mechnig", PlaceOfBirth = "Köln (GER)", YearOfBirth = "1929" },
                new Artist { Id = 47, FirstName = "Achiel", LastName = "Pauwels", PlaceOfBirth = "Mariakerke", YearOfBirth = "1932" },
                new Artist { Id = 48, FirstName = "Dany", LastName = "Persoons", PlaceOfBirth = "Aspelare", YearOfBirth = "1938" }

                );

            modelBuilder.Entity<Technic>().HasData(
                new Technic { Id = 1,  Name = "Acryl" },
                new Technic { Id = 2,  Name = "Aquarel" },
                new Technic { Id = 3,  Name = "Aquarel & fineliner" },
                new Technic { Id = 4,  Name = "Aquatint" },
                new Technic { Id = 5,  Name = "Bister" },
                new Technic { Id = 6,  Name = "Balpen & markers" },
                new Technic { Id = 7,  Name = "Cement" },
                new Technic { Id = 8,  Name = "Ets" },
                new Technic { Id = 9,  Name = "Ets, droge naald" },
                new Technic { Id = 10, Name = "Gemengde techniek" },
                new Technic { Id = 11, Name = "Gouache" },
                new Technic { Id = 12, Name = "Houtsnede" },
                new Technic { Id = 13, Name = "Keramiek" },
                new Technic { Id = 14, Name = "Klei" },
                new Technic { Id = 15, Name = "Kleurpotlood" },
                new Technic { Id = 16, Name = "Linosnede" },
                new Technic { Id = 17, Name = "Litho" },
                new Technic { Id = 18, Name = "Offset druk" },
                new Technic { Id = 19, Name = "Olieverf" },
                new Technic { Id = 20, Name = "Oostindische inkt" },
                new Technic { Id = 21, Name = "Opgehoogde zeefdruk" },
                new Technic { Id = 22, Name = "PC grafiek" },
                new Technic { Id = 23, Name = "Print op doek" },
                new Technic { Id = 24, Name = "Print op fotopapier" }

            );
        }
    }
}
