#pragma checksum "C:\Users\berkan\azad\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d81c488be8f2646a4d7deccaed306fca12b285f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\berkan\azad\Views\_ViewImports.cshtml"
using azad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berkan\azad\Views\_ViewImports.cshtml"
using azad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d81c488be8f2646a4d7deccaed306fca12b285f", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e87dfb8325920f061808c88134a233b49b58fc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- bir foreach kullanmıyoruz yani birden fazla veri ekrana basmıyoruz yani bir liste gerekmiyor\r\nsadece seçilen filmin detaylarının gözüktüğü o filme ait tek bir liste verisinin olduğu bir view bu-->\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n");
            WriteLiteral("<!-- Partial viewimi yorum satırına aldım yani iptal ettim\r\n        artık böyle kullanmıcam alttaki gibi kullanıcam-->\r\n       ");
#nullable restore
#line 9 "C:\Users\berkan\azad\Views\Admin\Details.cshtml"
  Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <!--Oluşturduğum Komponentimi burada kullandım 
        await komutuyla ve ınvokeasync komutuyla asenkron olarak çalışır category menu component view imin içinde
        bulunduğu klasörün adı buarada :) aynısını indexdede yaptım. Hatta bunu direk layoutda tanımlarsak
        bu layoutu kullanan bütün viewlerde bu menü içeriği gelir yorum satırına alıyorum bu kodu
        layouta atıyorum attığımda sıkıntı oldu şuanlık burda kullancam-->
    </div>
    <div class=""col-md-9"">
        <div class=""card mb-3"">
            <div class=""card-body"">
                <div class=""row no-gutter"">
                    <div class=""col-md-4"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1255, "\"", 1286, 2);
            WriteAttributeValue("", 1261, "/lib//img/", 1261, 10, true);
#nullable restore
#line 20 "C:\Users\berkan\azad\Views\Admin\Details.cshtml"
WriteAttributeValue("", 1271, Model.ImageUrl, 1271, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\">\r\n                    </div>\r\n              <div class=\"col-md-8\">\r\n                    <h5 class=\"card-title\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1440, "\"", 1471, 2);
            WriteAttributeValue("", 1447, "/Admin/Details/", 1447, 15, true);
#nullable restore
#line 24 "C:\Users\berkan\azad\Views\Admin\Details.cshtml"
WriteAttributeValue("", 1462, Model.Id, 1462, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\berkan\azad\Views\Admin\Details.cshtml"
                                                  Write(Model.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h5>\r\n                    <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\berkan\azad\Views\Admin\Details.cshtml"
               Write(Model.CourseCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <p class=""card-text"">
                    <small class=""text-muted"">3 days ago</small>
                    </p>
               </div>
                 </div>
                
            </div>
    
        
        
        </div>
    </div>
</div>
 ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
