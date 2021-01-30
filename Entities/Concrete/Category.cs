using Entities.Abstract; //ilk ıentity yi implement ettik ama hata verdi bu kütüphaneyi eklemmeiz gerekti
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak class kalmasın(çck)
    //classı oluşturdk public yaptık
  public class Category:IEntity  //ıentity categori nin referansının tutuyo demek
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
