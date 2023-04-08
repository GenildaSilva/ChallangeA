

using ChallangeA.Interface;

namespace ChallangeA.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}