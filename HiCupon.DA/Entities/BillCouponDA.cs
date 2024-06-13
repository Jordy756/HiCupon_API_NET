using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiCupon.DA.Entities
{
    [Table("BILL_COUPON")]
    public class BillCouponDA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("BILL_COUPON_ID")]
        public int Id { get; set; }

        [ForeignKey("BILL_ID")]
        public virtual BillDA BillDA { get; set; } = null!;

        [Required, Column("COUPON_ID")]
        public int CouponId { get; set; }

        [Required, Column("QUANTITY")]
        public int Quantity { get; set; }

        [Required, Column("TOTAL_BASE_PRICE", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalBasePrice { get; set; }

        [Required, Column("TOTAL_DISCOUNT", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalDiscount { get; set; }

        [Required, Column("TOTAL_TAX", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalTax { get; set; }

        [Required, Column("TOTAL_PRICE", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalPrice { get; set; }
    }
}
