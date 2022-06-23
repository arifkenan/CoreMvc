using Northwind.DAL.Abstract;
using Nortwhind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    public class ProductDal:RepositoryBase<Product>,IProductDal
    {



    }
}
