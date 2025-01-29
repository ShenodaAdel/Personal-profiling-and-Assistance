using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // connect to testid  as a forigen key
        [ForeignKey("test")]
        public int testId { get; set; }
        public Test test { get; set; }
    }
}
