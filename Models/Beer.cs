namespace BeerApplication.Models
{
    public class Beer 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string image_url {get; set;}

        public string tagline {get; set;}

        public string description {get; set;}

        public float bv {get; set;}

        public float ibu {get; set;}

    }
}