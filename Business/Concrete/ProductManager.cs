using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService //önce using sonra implement yapcaz
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları yazılcak mesela yetkisi var mı kodları var
            //işkodlarını yazıp veri erişimini çağırmam lazım
            return _productDal.GetAll(); //productdal daki operasyonlar gelir
            //sonra bana ürünleri verebilirsn diyo ben kurallardan geçtim
        }
    }
}
