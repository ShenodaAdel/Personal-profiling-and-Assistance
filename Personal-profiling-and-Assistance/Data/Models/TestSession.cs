using System.ComponentModel.DataAnnotations;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class TestSession
    {
        // date start and end 
        // forign key userid  and reference TestID

        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = DateTime.MinValue; // true or false 
    }
}
