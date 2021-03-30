using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;


namespace DataAccess.Abstract
{
    //Product Entity veri erişim katmanı.
   public interface IProductDal:IEntityRepository<Product>
   {
       List<ProductDetailDto> GetProductDetails();
   }
}
