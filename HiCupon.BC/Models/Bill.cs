namespace HiCupon.BC.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public User User { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<BillCoupon> BillCoupons { get; set; }

        public Bill()
        {
            this.Id = 0;
            this.User = new User();
            this.BasePrice = 0;
            this.Iva = 0;
            this.Total = 0;
            this.BillCoupons = new List<BillCoupon>();
        }

        public Bill(int id, User user, decimal basePrice, decimal iva, decimal total, IEnumerable<BillCoupon> billCoupons)
        {
            this.Id = id;
            this.User = user;
            this.BasePrice = basePrice;
            this.Iva = iva;
            this.Total = total;
            this.BillCoupons = billCoupons;
        }
    }
}
