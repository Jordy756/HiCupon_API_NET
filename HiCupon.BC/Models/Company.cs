namespace HiCupon.BC.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public Company(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
