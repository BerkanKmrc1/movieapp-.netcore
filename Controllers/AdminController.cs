using System.Linq;
using azad.Data;
using azad.Models;
using Microsoft.AspNetCore.Mvc;

namespace azad.Controllers
{
    public class AdminController:Controller
    {
        //id gönderilirse menü sekmesinden yani
        //bir kategori seçilirse id ye göre olan filmleri getircek
        //seçilmezsede tüm filmleri getircek bunu yapıcaz Index
        //actionresultında o yüzden ? koyuyoruz yani nullable 
        //olabilir yani bir parametre gönderilmeyebilir.
        public IActionResult Index(int? id)
        {
          // ProductCategoryModel productCategoryModel = new ProductCategoryModel();  
          // productCategoryModel.Categories = CategoryRepository.Categories;
          var movies=Repository.Movies;//Öncelikle bütün film bilgilerini alıyoruz.
          if(id!=null)//id null değilse
          {
            movies = movies.Where(x=>x.CategoryId==id).ToList();//bir filtreleme yapıyoruz where komutuyla linq komutu bu.
            //bizim category id miz parametre olarak gelen yani kullanıcının seçeceği parametreyle eşitse
            //demekki burada istediğimiz kategoriye ait bir film var ve bunu movies in içine tolist ile 
            //liste halinde atar
          }
          return View(movies);//en sonda bu değerleri döndürcez geriye 
        }
        public IActionResult Details(int id)
        {
          //ProductCategoryModel productCategoryModel = new ProductCategoryModel();  
          //productCategoryModel.Categories = CategoryRepository.Categories; 
          //productCategoryModel.Movie = Repository.GetById(id);bunları yorum satırına aldım aynı şekilde
          //üsteki actionresultında aynı kodlarını yorum satırına aldım çünkü
          //artık view component kullandım yani categories listesine ihtiyacım yok artık buna ihtiyacım
          //olmadığı için ikitane liste göndermek adına oluşturduğum ProductCategoryModel ı indexde ve
          //details viewlerinde üstte tanımlamıştım bunları değiştircem kendi ıenumarable larını kullanıcak
          //bu viewşar. Index altında @Html.Partial("_movies",Model.Movies) şu kısmıda değiştircem.Değiştirilmiş
          //hali index viewinde var. Not: Index ProductCategoryModeli kullanıcak ve haliyle  @Html.Partial("_movies",Model.Movies)
          //burasıda böyle kalcak değişmicek ama detailsview yalnızca movie yi  kullanabilirim ProductCategoryi
          //kullanmama gerekk yok çünkü component olayına geçtik.
       
          return View(Repository.GetById(id));
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}