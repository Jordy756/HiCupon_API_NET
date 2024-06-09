namespace HiCupon.BC.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Promotion()
        {
            this.Id = 0;
            this.Name = string.Empty;
        }

        public Promotion(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
