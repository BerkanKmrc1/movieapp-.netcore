using System.Collections.Generic;
using System.Linq;
using azad.Models;

namespace azad.Data
{
    //bu repository de category repositedeki gibi film verilerini oluşturacak bir constructor ile ve
    //listeleme ekleme ve ıd'ye göre getirme gibi metotları olucak
    public class Repository
    {
        private static List<Movie> _movies = null;
        static Repository()
        {
            _movies = new List<Movie>()
            {

                new Movie()
                {
                    Id = 1, 
                    CourseCode="1234",
                    CourseName= "Software" , 
                    CourseType = "XYZ",
                    ImageUrl="1.jpg",
                    ShortDescription = "Kısa Açıklama",
                    CategoryId = 1
                    
                },
                new Movie()
                {
                    Id = 2, 
                    CourseCode="3453", 
                    CourseName= "Hardware" , 
                    CourseType = "ABC", 
                    ImageUrl ="2.jpg",
                    ShortDescription = "Kısa Açıklama",
                    CategoryId = 2
                },
                  new Movie()
                {
                    Id = 3, 
                    CourseCode="3453", 
                    CourseName= "TEHLİKE" , 
                    CourseType = "ABC", 
                    ImageUrl ="2.jpg",
                    ShortDescription = "Kısa Açıklama",
                    CategoryId = 2 
                }
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie p)
        {
            _movies.Add(p);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x=>x.Id == id);
        }
    }
}