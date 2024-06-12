namespace HiCupon.BC.Models
{
    public class CouponPromotion
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Promotion Promotion { get; set; }

        public CouponPromotion()
        {
            this.Id = 0;
            this.Discount = 0;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.Promotion = new Promotion();
        }

        public CouponPromotion(int id, int discount, DateTime startDate, DateTime endDate, Promotion promotion)
        {
            Id = id;
            Discount = discount;
            StartDate = startDate;
            EndDate = endDate;
            Promotion = promotion;
        }
    }
}
