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

        [Required, Column("BASE_PRICE", TypeName = "DECIMAL(10, 2)")]
        public decimal BasePrice { get; set; }

        [Required, Column("IVA", TypeName = "DECIMAL(10, 2)")]
        public decimal Iva { get; set; }

        [Required, Column("TOTAL", TypeName = "DECIMAL(10, 2)")]
        public decimal Total { get; set; }

        public virtual ICollection<BillCouponDA> BillCouponDAs { get; set; } = null!;
    }
}
