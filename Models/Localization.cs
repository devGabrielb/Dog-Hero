namespace DogHero.API.Models
{
    public class Localization
    {
        public Localization(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}