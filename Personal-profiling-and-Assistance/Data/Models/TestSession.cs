using System.ComponentModel.DataAnnotations;

namespace Personal_profiling_and_Assistance.Data.Models
{
    public class TestSession
    {
        [Key]
        public int Id { get; set; }

        // date start and end  
        // forign key userid  and reference TestID
    }
}
