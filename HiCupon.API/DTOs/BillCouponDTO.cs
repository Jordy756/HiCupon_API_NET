namespace HiCupon.API.DTOs
{
    public class BillCouponDTO
    {
        public int Id { get; set; }
        public CouponDTO CouponDTO { get; set; }
        public int Quantity { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }

        public BillCouponDTO()
        {
            this.Id = 0;
            this.CouponDTO = new CouponDTO();
            this.Quantity = 0;
            this.TotalBasePrice = 0;
            this.TotalDiscount = 0;
            this.TotalTax = 0;
            this.TotalPrice = 0;
        }

        public BillCouponDTO(int id, CouponDTO couponDTO, int quantity, decimal totalBasePrice, decimal totalDiscount, decimal totalTax, decimal totalPrice)
        {
            this.Id = id;
            this.CouponDTO = couponDTO;
            this.Quantity = quantity;
            this.TotalBasePrice = totalBasePrice;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.TotalPrice = totalPrice;
        }
    }
}
