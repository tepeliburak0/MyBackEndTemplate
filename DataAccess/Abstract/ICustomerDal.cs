using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Customer Entity veri erişim katmanı.
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
