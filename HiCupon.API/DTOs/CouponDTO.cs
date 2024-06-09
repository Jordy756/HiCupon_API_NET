namespace HiCupon.API.DTOs
{
    public class CouponDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
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
            this.ImageURL = string.Empty;
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

        public CouponDTO(int id, string name, string description, string imageUrl, DateTime creationDate, DateTime releaseDate, DateTime expirationDate, decimal price, string location, int discount, int stock, CompanyDTO companyDTO, CategoryDTO categoryDTO, bool isActive, IEnumerable<CouponPromotionDTO> CouponPromotionDTOs)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageURL = imageUrl;
            CreationDate = creationDate;
            ReleaseDate = releaseDate;
            ExpirationDate = expirationDate;
            Price = price;
            Location = location;
            Discount = discount;
            Stock = stock;
            CompanyDTO = companyDTO;
            CategoryDTO = categoryDTO;
            IsActive = isActive;
            this.CouponPromotionDTOs = new List<CouponPromotionDTO>();
        }
    }
}
