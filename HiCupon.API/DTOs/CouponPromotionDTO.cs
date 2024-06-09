namespace HiCupon.API.DTOs
{
    public class CouponPromotionDTO
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PromotionDTO PromotionDTO { get; set; }

        public CouponPromotionDTO()
        {
            this.Id = 0;
            this.Discount = 0;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.PromotionDTO = new PromotionDTO();
        }

        public CouponPromotionDTO(int id, int discount, DateTime startDate, DateTime endDate, PromotionDTO promotionDTO)
        {
            Id = id;
            Discount = discount;
            StartDate = startDate;
            EndDate = endDate;
            PromotionDTO = promotionDTO;
        }
    }
}
