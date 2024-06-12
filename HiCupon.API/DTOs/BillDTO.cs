namespace HiCupon.API.DTOs
{
    public class BillDTO
    {
        public int Id { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<BillCouponDTO> BillCouponDTOs { get; set; }

        public BillDTO()
        {
            this.Id = 0;
            this.BasePrice = 0;
            this.Iva = 0;
            this.Total = 0;
            this.BillCouponDTOs = new List<BillCouponDTO>();
        }

        public BillDTO(int id, decimal basePrice, decimal iva, decimal total, IEnumerable<BillCouponDTO> billCouponDTOs)
        {
            this.Id = id;
            this.BasePrice = basePrice;
            this.Iva = iva;
            this.Total = total;
            this.BillCouponDTOs = billCouponDTOs;
        }
    }
}
