namespace HiCupon.BC.Models
{
    public class BillCoupon
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public int Quantity { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }

        public BillCoupon()
        {
            this.Id = 0;
            this.Coupon = new Coupon();
            this.Quantity = 0;
            this.TotalBasePrice = 0;
            this.TotalDiscount = 0;
            this.TotalTax = 0;
            this.TotalPrice = 0;
        }

        public BillCoupon(int id, Coupon coupon, int quantity, decimal totalBasePrice, decimal totalDiscount, decimal totalTax, decimal totalPrice)
        {
            this.Id = id;
            this.Coupon = coupon;
            this.Quantity = quantity;
            this.TotalBasePrice = totalBasePrice;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.TotalPrice = totalPrice;
        }
    }
}
