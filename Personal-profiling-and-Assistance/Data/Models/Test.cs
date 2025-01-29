using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("user")]
        public int userId { get; set; }
        public User user { get; set; }

        // public ICollection<Question> Questions { get; set; } = new HashSet<Question>(); 
    }
}
