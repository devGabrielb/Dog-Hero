using System;

namespace DogHero.API.Models
{
    public class Pets
    {
        public Pets(){
            this.Id = Guid.NewGuid();
        }
        public Pets(string name, double weight, string breed): this()
        {
            Name = name;
            Weight = weight;
            Breed = breed;
        }

        public Guid Id {get; set;}
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Breed { get; set; }
        
    }
}