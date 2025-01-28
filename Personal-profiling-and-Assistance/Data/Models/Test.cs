using System.ComponentModel.DataAnnotations;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
