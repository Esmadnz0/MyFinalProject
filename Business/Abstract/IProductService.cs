using Entities.Concrete; //project reference den entities ve dataaccessi seçtik ve kütüphane geldi

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //iş katmanında kullanacağımız servis operasyonları
   public interface IProductService
    {
        List<Product> GetAll(); //tüm ürünleri listeleyecek ortam oluştrdm

    }
}
