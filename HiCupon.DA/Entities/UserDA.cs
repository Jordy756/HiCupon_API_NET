using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiCupon.DA.Entities
{
    [Table("USER")]
    public class UserDA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("USER_ID")]

        public int Id { get; set; }

        [Required, Column("NAME")]
        public string Name { get; set; } = string.Empty;

        [Required, Column("LAST_NAME")]
        public string LastName { get; set; } = string.Empty;

        [Required, Column("IDENTIFICATION_CARD")]
        public string IdentificationCard { get; set; } = string.Empty;

        [Required, Column("BIRTH_DATE")]
        public DateTime BirthDate { get; set; }

        [Required, Column("EMAIL")]
        public string Email { get; set; } = string.Empty;

        [Required, Column("PASSWORD")]
        public string Password { get; set; } = string.Empty;

        public virtual ICollection<BillDA> BillDAs { get; set; } = null!;
    }
}
