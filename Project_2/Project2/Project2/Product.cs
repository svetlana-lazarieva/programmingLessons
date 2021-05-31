using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2
{
    [Table("Product")]
    public class Product : TableBase
    {
        [NotMapped]
        public override int Id => ProductId;
        [Key]
        public int ProductId { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }

        public override void Copy(TableBase otherTable)
        {
            PropertyCopier<Product, Product>.Copy(otherTable as Product, this);
        }
    }
}