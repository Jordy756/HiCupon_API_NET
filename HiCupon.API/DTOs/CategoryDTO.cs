namespace HiCupon.API.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public CategoryDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
