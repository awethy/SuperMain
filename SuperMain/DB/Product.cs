using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace SuperMain.DB
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Articul { get; set; }
        public string ProductName { get; set; }
        public string  Description { get; set; }
        public string Manufacture { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double Sale { get; set; }
    }
}