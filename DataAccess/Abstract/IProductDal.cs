using Entities.Concrete; //bu da yine kütüphanedir bunu manuel ekledik vs nn bugndan dolayı

using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract

    //dataccessde ürün listelyicez
{
    //I onun interface , Dal hangi katmana karşılık geldiği dal: data access 
  
 public interface IProductDal
    {
        //her oluşturdgmz classa public dedik niye diğer classlardan erişim olsn diye
        //productla iligli veritabnanında yapacağım operasyonları(ekle sil güncelle vs) tutacağım yer
        //ınterface ın operasyonları public ondan başına public dedik

        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        //interface metodları publictir.

        List<Product> GetAllByCategory(int categoryId);//ürünleri kategoriye göre filtrele



    }
}
