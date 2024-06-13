namespace HiCupon.API.DTOs
{
    public class BillDTO
    {
        public int Id { get; set; }
        public decimal TotalBasePrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<BillCouponDTO> BillCouponDTOs { get; set; }

        public BillDTO()
        {
            this.Id = 0;
            this.TotalBasePrice = 0;
            this.TotalDiscount = 0;
            this.TotalTax = 0;
            this.TotalPrice = 0;
            this.BillCouponDTOs = new List<BillCouponDTO>();
        }

        public BillDTO(int id, decimal totalBasePrice, decimal totalDiscount, decimal totalTax, decimal totalPrice, IEnumerable<BillCouponDTO> billCouponDTOs)
        {
            this.Id = id;
            this.TotalBasePrice = totalBasePrice;
            this.TotalDiscount = totalDiscount;
            this.TotalTax = totalTax;
            this.TotalPrice = totalPrice;
            this.BillCouponDTOs = billCouponDTOs;
        }
    }
}
