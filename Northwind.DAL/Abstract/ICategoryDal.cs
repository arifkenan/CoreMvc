using Nortwhind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface ICategoryDal:IRepositoryBase<Category>
    {
        List<Product> GetProducts(string categoryName);
    }
}
