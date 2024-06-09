namespace HiCupon.API.DTOs
{
    public class BillCouponDTO
    {
        public int Id { get; set; }
        public BillDTO BillDTO { get; set; }
        public int CouponId { get; set; }
        public int Quantity { get; set; }

        public BillCouponDTO()
        {
            this.Id = 0;
            this.BillDTO = new BillDTO();
            this.CouponId = 0;
            this.Quantity = 0;
        }

        public BillCouponDTO(int id, BillDTO billDTO, int couponId, int quantity)
        {
            this.Id = id;
            this.BillDTO = billDTO;
            this.CouponId = couponId;
            this.Quantity = quantity;
        }
    }
}
