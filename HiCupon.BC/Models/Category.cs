namespace HiCupon.BC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
