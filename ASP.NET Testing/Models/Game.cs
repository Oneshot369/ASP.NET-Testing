using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Testing.Models
{
    public class Game
    {
        [Display(Name = "Id #")]
        public string Id { get; set; }
        [Display(Name = "Game")]
        public string Name { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Cost")]
        public float Price { get; set; }
        public char Rating { get; set; }

        //Default Contructor
        public Game(){   }

        // Paramiterized contructor
        public Game(string id, string name, string genre, float price, char rating)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Price = price;
            Rating = rating;
        }
    }
}
