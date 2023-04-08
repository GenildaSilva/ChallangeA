using ChallangeA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeA.Models
{
    public class ProductList : List<IProduct>, IProductList
    {
    }
}
