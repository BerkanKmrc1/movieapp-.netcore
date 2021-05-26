namespace azad.Models
{
    //Filmlerimin verilerini tutacak model
    public class Movie
    {
        public int Id { get; set; }
        public string CourseName{ get; set; }
        public string CourseType { get; set; }
        public string CourseCode { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public int CategoryId { get; set; }
        
    }
}