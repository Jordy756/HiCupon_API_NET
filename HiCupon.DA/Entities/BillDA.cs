using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiCupon.DA.Entities
{
    [Table("BILL")]
    public class BillDA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("BILL_ID")]
        public int Id { get; set; }

        [ForeignKey("USER_ID")]
        public virtual UserDA UserDA { get; set; } = null!;

        [Required, Column("TOTAL_BASE_PRICE", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalBasePrice { get; set; }

        [Required, Column("TOTAL_DISCOUNT", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalDiscount { get; set; }

        [Required, Column("TOTAL_TAX", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalTax { get; set; }

        [Required, Column("TOTAL_PRICE", TypeName = "DECIMAL(10, 2)")]
        public decimal TotalPrice { get; set; }

        public virtual ICollection<BillCouponDA> BillCouponDAs { get; set; } = null!;
    }
}
