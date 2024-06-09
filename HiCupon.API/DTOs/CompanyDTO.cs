namespace HiCupon.API.DTOs
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CompanyDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public CompanyDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
