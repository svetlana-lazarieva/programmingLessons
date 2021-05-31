using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2
{
    [Table("Order")]
    public class Order : TableBase
    {
        [NotMapped]
        public override int Id => OrderRecordId;
        [Key]
        public int OrderRecordId { get; set; }
        public string orderName { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int productQuantity { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }

        public override void Copy(TableBase otherTable)
        {
            PropertyCopier<Order, Order>.Copy(otherTable as Order, this);
        }

    }
}