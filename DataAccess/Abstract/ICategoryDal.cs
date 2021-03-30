using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Category Entity veri erişim katmanı.
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
