using System.ComponentModel.DataAnnotations;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // connect to testid  as a forigen key
    }
}
