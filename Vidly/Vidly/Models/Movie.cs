using System;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        public string[] Cast { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        
    }
}