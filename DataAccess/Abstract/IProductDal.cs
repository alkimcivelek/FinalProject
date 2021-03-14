using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /*Entities katmanı referans edildi. 
    Tüm katmanlar referans edilirse 
    circular dependency denilen kavram ortaya çıkar.*/
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring(Kodun iyileştirilmesi)
