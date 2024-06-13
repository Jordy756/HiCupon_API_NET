namespace HiCupon.BC.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<BillCoupon> BillCoupons { get; set; }

        public Bill()
        {
            this.Id = 0;
            this.TotalBasePrice = 0;
            this.TotalDiscount = 0;
            this.TotalTax = 0;
            this.TotalPrice = 0;
            this.BillCoupons = new List<BillCoupon>();
        }

        public Bill(int id, decimal totalBasePrice, decimal totalDiscount, decimal totalTax, decimal totalPrice, IEnumerable<BillCoupon> billCoupons)
        {
            this.Id = id;
            this.TotalBasePrice = totalBasePrice;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.TotalPrice = totalPrice;
            this.BillCoupons = billCoupons;
        }
    }
}
