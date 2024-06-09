namespace HiCupon.API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationCard { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<BillDTO> BillDTOs { get; set; }

        public UserDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.LastName = string.Empty;
            this.IdentificationCard = string.Empty;
            this.DateBirth = DateTime.MinValue;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.BillDTOs = new List<BillDTO>();
        }

        public UserDTO(int id, string name, string lastName, string identificationCard, DateTime dateBirth, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.IdentificationCard = identificationCard;
            this.DateBirth = dateBirth;
            this.Email = email;
            this.Password = password;
            this.BillDTOs = new List<BillDTO>();
        }
    }
}
