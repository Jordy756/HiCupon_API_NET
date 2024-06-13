namespace HiCupon.BC.Models
{
    public class Coupon
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
        public Category Category { get; set; }
        public Company Company { get; set; }
        public IEnumerable<CouponPromotion> CouponPromotions { get; set; }

        public Coupon()
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
            this.Company = new Company();
            this.Category = new Category();
            this.IsActive = true;
            this.CouponPromotions = new List<CouponPromotion>();
        }

        public Coupon(int id, string name, string description, string image, DateTime creationDate, DateTime releaseDate, DateTime expirationDate, decimal price, string location, int discount, int stock, Company company, Category category, bool isActive, IEnumerable<CouponPromotion> CouponPromotions)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            CreationDate = creationDate;
            ReleaseDate = releaseDate;
            ExpirationDate = expirationDate;
            Price = price;
            Location = location;
            Discount = discount;
            Stock = stock;
            Company = company;
            Category = category;
            IsActive = isActive;
            this.CouponPromotions = CouponPromotions;
        }

        public Coupon(int id)
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
            this.Company = new Company();
            this.Category = new Category();
            this.IsActive = true;
            this.CouponPromotions = new List<CouponPromotion>();
        }
    }
}
