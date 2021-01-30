using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq; //linq use için
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //bellek üzerinde ürün erişimlerinin yazılacağı kod klasörn manası
   //aşagıdaki işlemler ben ürünümü çalışrtrdgmda gelecek bilgiler düşünki bu bir sqlden geliyor
    public class InMemoryProductDal : IProductDal  //ıproductdal dır ilk dataaccess i ekledik sonra using interface dedik ıproductdal dan aldığını yazdı
    {
        public InMemoryProductDal()
        {

            _products = new List<Product> {
            //yeni ürünler eklicez list product içinde bir süürü ürün barındırabilir
            new Product{ProductId=1, CategoryId=1,ProductName="Bardak", UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2, CategoryId=1,ProductName="Kamera", UnitPrice=500,UnitsInStock=35},
            new Product{ProductId=3, CategoryId=2,ProductName="Telefon", UnitPrice=1500,UnitsInStock=2},
            new Product{ProductId=4, CategoryId=2,ProductName="Klavye", UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5, CategoryId=2,ProductName="Fare", UnitPrice=85,UnitsInStock=1}
            //ctrl+space dersen prntex içindekiler gelir
            
            };
            //bellkete çalışan olay constructor
        }
        List<Product> _products;
        public void Add(Product product)
        {
            _products.Add(product);
    
        }

        public void Delete(Product product)
        {
         //   Product productToDelete =null;

            //foreach (var p in _products)
            //{ //listeyi tek tek dolaştk ve şart koyduj
            //    if (product.ProductId ==p.ProductId)
            //    {
            //        //tek tek listedeki elemanları dolaşıyo eger benim gönderdiğim ıd ye biir eşite sil

            //        productToDelete = p;
            //    } }
            //_products.Remove(productToDelete);
            ////linq ile bu yapılır bununa liste bazlı yapıları sql gibi filtrelersn ve kısa bi şekilde yazılır

         Product productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId); //single.. kodu üstteki foreach i yapıyo
            //üstte ki kod foreach ve if şartını yazdgmn yerine geçer her p için pnin o an dolaşmatgm ürüünn ıdsi bnm delete içinde gödnerdiğim paremetrenin ıdsine eşitse git sil



        }

        public List<Product> GetAll()
        {
            return _products;  //listenin tamamı olacak ve return olr
        
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün idsine sahip ürün idsini bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock; //product paremetredir
        
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //İmplement interface dedim
          return  _products.Where(p=>p.CategoryId==categoryId).ToList();

                //içinde uyan bütün elemanları yeni bir liste haline getirip döndürür where şartı
        }
    }
}
