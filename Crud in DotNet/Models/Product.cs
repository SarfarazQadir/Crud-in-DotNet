using System.ComponentModel.DataAnnotations;

namespace Crud_in_DotNet.Data
{
    public class Product 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity{ get; set; }
        public string Description { get; set; }

    }
}
