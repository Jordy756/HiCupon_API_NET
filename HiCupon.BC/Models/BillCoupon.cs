namespace HiCupon.BC.Models
{
    public class BillCoupon
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public int Quantity { get; set; }

        public BillCoupon()
        {
            this.Id = 0;
            this.Coupon = new Coupon();
            this.Quantity = 0;
        }

        public BillCoupon(int id, Coupon coupon, int quantity)
        {
            this.Id = id;
            this.Coupon = coupon;
            this.Quantity = quantity;
        }
    }
}
