using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //classı public yaptık yani bu classa diğer katmanlarda ulaşabilsn
    //internal class deseydik yani sadece entities de ki erişebilsn

  public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
