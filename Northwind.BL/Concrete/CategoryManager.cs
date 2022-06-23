using Northwind.BL.Abstract;
using Nortwhind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BL.Concrete
{
    public class CategoryManager:ManagerBase<Category>, ICategoryManager
    {
    }
}
