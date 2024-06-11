using HiCupon.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace HiCupon.DA.Context
{
    public class HiCouponContext : DbContext
    {
        public HiCouponContext(DbContextOptions<HiCouponContext> options) : base(options)
        {
        }

        public virtual DbSet<UserDA> UserDAs { get; set; }
        public virtual DbSet<BillDA> BillDAs { get; set; }
        public virtual DbSet<BillCouponDA> BillCouponDAs { get; set; }
    }
}
