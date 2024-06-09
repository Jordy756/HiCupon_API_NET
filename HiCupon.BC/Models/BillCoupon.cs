namespace HiCupon.BC.Models
{
    public class BillCoupon
    {
        public int Id { get; set; }
        public Bill Bill { get; set; }
        public int CouponId { get; set; }
        public int Quantity { get; set; }

        public BillCoupon()
        {
            this.Id = 0;
            this.Bill = new Bill();
            this.CouponId = 0;
            this.Quantity = 0;
        }

        public BillCoupon(int id, Bill bill, int couponId, int quantity)
        {
            this.Id = id;
            this.Bill = bill;
            this.CouponId = couponId;
            this.Quantity = quantity;
        }
    }
}
