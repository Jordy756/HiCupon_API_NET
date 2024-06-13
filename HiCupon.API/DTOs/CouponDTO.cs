using HiCupon.BC.Models;

namespace HiCupon.API.DTOs
{
    public class CouponDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Location { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
        public CategoryDTO CategoryDTO { get; set; }
        public CompanyDTO CompanyDTO { get; set; }
        public IEnumerable<CouponPromotionDTO> CouponPromotionDTOs { get; set; }

        public CouponDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Image = string.Empty;
            this.CreationDate = DateTime.MinValue;
            this.ReleaseDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Price = 0;
            this.Location = string.Empty;
            this.Discount = 0;
            this.Stock = 0;
            this.CompanyDTO = new CompanyDTO();
            this.CategoryDTO = new CategoryDTO();
            this.IsActive = true;
            this.CouponPromotionDTOs = new List<CouponPromotionDTO>();
        }

        public CouponDTO(int id, string name, string description, string image, DateTime creationDate, DateTime releaseDate, DateTime expirationDate, decimal price, int stock, string location, int discount, bool isActive, CategoryDTO categoryDTO, CompanyDTO companyDTO, IEnumerable<CouponPromotionDTO> couponPromotionDTOs)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            CreationDate = creationDate;
            ReleaseDate = releaseDate;
            ExpirationDate = expirationDate;
            Price = price;
            Stock = stock;
            Location = location;
            Discount = discount;
            IsActive = isActive;
            CategoryDTO = categoryDTO;
            CompanyDTO = companyDTO;
            CouponPromotionDTOs = couponPromotionDTOs;
        }

        public CouponDTO(int id)
        {
            this.Id = id;
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Image = string.Empty;
            this.CreationDate = DateTime.MinValue;
            this.ReleaseDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Price = 0;
            this.Location = string.Empty;
            this.Discount = 0;
            this.Stock = 0;
            this.CompanyDTO = new CompanyDTO();
            this.CategoryDTO = new CategoryDTO();
            this.IsActive = true;
            this.CouponPromotionDTOs = new List<CouponPromotionDTO>();
        }
    }
}
