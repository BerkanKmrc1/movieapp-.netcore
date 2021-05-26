using azad.Data;
using Microsoft.AspNetCore.Mvc;
//bu classın amacı sayfanın solunda olan liste menüsü için bir component oluşturmak ve 
//bu component ile birlikte categori verilerini data namespacein içindekki CategoryRepository içinden çekebilicek
//bu çekebiilme işlemini
namespace azad.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent //bu kalıtım sayesinde yapabiliyoruz.view component diye
    //özel bi class var c# da
    {
        public IViewComponentResult Invoke()//ınvoke adında bir metot oluşturup
        {
            if(RouteData.Values["action"].ToString()=="Index")
            {
            ViewBag.SelectedCategory = RouteData?.Values["id"];//viewbag ile viewe veri taşıcaz taşıcağımız veri
            //selectedcategory diye oluşturduğumuz değişken. Routedata.values ilede id bilgisini alabiliriz.
            //bu c# da kayıtlı olan bir sınıf ve sınıfın metodu.Invoke metodu çalıştığı zaman url içerisindeki
            //id parametresi alınır ve geçici bir alana atılır yani viewbage atılır viewbagi ile birliktete 
            //viewcomponentimize bunu aktarıcaz.Soru işaretide routedatası yoksa demek null değeri atıcak
            }
            return View(CategoryRepository.Categories);//view le birlikte category repositoriy altındaki
            //categories verilerini gönderiyoruz ki bu compenenti baz alan diğer view sayfalarında(bu sayfalar
            //index.cshtml,details.cshtml) bu categori bilgileri de gidebilsin.
        }
    }
}