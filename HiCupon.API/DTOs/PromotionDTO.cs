namespace HiCupon.API.DTOs
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PromotionDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public PromotionDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
