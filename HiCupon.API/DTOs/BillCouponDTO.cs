namespace HiCupon.API.DTOs
{
    public class BillCouponDTO
    {
        public int Id { get; set; }
        public CouponDTO CouponDTO { get; set; }
        public int Quantity { get; set; }

        public BillCouponDTO()
        {
            this.Id = 0;
            this.CouponDTO = new CouponDTO();
            this.Quantity = 0;
        }

        public BillCouponDTO(int id, CouponDTO coupon, int quantity)
        {
            this.Id = id;
            this.CouponDTO = coupon;
            this.Quantity = quantity;
        }
    }
}
