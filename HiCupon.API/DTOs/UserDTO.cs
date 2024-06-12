namespace HiCupon.API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationCard { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<BillDTO> BillDTOs { get; set; }

        public UserDTO()
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.LastName = string.Empty;
            this.IdentificationCard = string.Empty;
            this.BirthDate = DateTime.MinValue;
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.BillDTOs = new List<BillDTO>();
        }

        public UserDTO(int id, string name, string lastName, string identificationCard, DateTime birthDate, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.IdentificationCard = identificationCard;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Password = password;
            this.BillDTOs = new List<BillDTO>();
        }
    }
}
