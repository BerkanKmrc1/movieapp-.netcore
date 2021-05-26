using System.Collections.Generic;
using System.Linq;
using azad.Models;

namespace azad.Data
{
    //bu repository tanımladığım Category.cs adındaki categori modelimin içeriğini dolduran bir
    //Liste üretiyor tanımladığım model tipinde. ve bu listeden bir nesne üretiyor. Bu nesneye 
    //daha sonra constructor ile modelimin içinde yer alacak verileri dolduruyoruz. Bu projede bir veritabanı
    //kullanmadım yani program her çalıştığında sabit veriler üzerinden işlem yapılacak ve eklenen güncellenen
    //veriler bir database de tutulamayacağı için kayıtlı kalamıcak. Devam ettiğimde verileri constructor la 
    //atadığımda bu repository her new lendiğinde constructor çalışıcak ve bu veriler listeye eklenicek
    //listeyi döndürdüğüm bir metodum var buda Categories adında bir metot ekleme ve getirme içinde ayrı metotlar
    //tanımladık
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category()
                {
                    Id=1,
                    Name = "Macera"
                 
                },
                new Category()
                {
                    Id=2,
                    Name = "Korku"
                  
                },
                  new Category()
                {
                    Id=3,
                    Name = "Dram"
                   
                }
               
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category p)
        {
            _categories.Add(p);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(x=>x.Id == id);
        }
    }
}