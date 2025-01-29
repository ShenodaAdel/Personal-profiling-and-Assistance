using System.ComponentModel.DataAnnotations;
namespace Personal_profiling_and_Assistance.Data.Models
{
    public class Choice
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
} 
