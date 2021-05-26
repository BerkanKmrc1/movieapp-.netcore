using System.Collections.Generic;

namespace azad.Models
{
    //bu sınıfın yani modelin amacıda Movie türünde bir movies Ienumarable geri dönüş tipinde bir metot tanımlayıp
    //filmlerin bir liste halinde tutulmasını sağlamak aynı şekilde categoriler içinde geçerli bu. Birde
    //geri dönüş tipi Movie olan Movie ismine bir property var. Bu property i de tanımlamamızın sebebi
    //admincontrollerında ikinci actionda  productCategoryModel.Movie = Repository.GetById(id); komutu ile 
    //gönderilen ıd ye göre tek bir filme ait detaylar listelenecek. Ben bütün film detaylarını liste 
    //halinde  istemiyorum Movie geri dönüş tipine tek bir değer olarak istiyorum o yüzden bu propertyi tanımldım
    //bu arada bu detaylar tanımladığım Movie classını ve
    //bu classın içini doldurduğum repository sayesinde gelicek bize. Son olarak da bu verilerin bize gelebilmesi için
    //ilgili view de yani views/admin klasörünün altındaki Details viewinde üstte @model ProductCategoryModel
    //şeklinde bir tanımlama yapmamız gerekki bu classı orda kullanabilelim. verileri /lib//img/@Model.Movie.ImageUrl
    //şeklinde getirdik buna dikkat _movies.cshtml viewinde /lib/img/@item.ImageUrl böyle getirmiştik ve bunun üstündede
    //birden çok veri alacağım için yani birden fazla filmin verisini alacağım için @model IEnumerable<Movie> kullandım
    //ve liste tipinde olduğu için bunun içindeki verileri foreachle dönüp sayfaya bastım. 
    //ama burda <img src="/lib/img/@item.ImageUrl" alt="" class="card-img"> böyle kullandım detailsle bunun farkına dikkat!
    public class ProductCategoryModel
    {
        public Movie Movie {get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}