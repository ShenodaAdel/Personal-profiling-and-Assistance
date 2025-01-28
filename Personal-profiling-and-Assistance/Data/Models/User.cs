using System.ComponentModel.DataAnnotations;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // the first and last how can do this 
        [MaxLength(15)]
        public string Phone {  get; set; }
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength (50)]
        public string Password { get; set; }

        public byte[]? Image { get; set; }

        [MaxLength(20)]
        public string UserName { get; set; }
        public string Gender { get; set; }

    }
}
