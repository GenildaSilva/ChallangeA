using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallangeA.Interface
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}