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
    }
}
