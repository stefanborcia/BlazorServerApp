using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerApp
{
    public class TodoItem
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        [MaxLength(20)]
        public string Priority { get; set; } = "Normal";
        public DateTime? DueDateTime { get; set; }
    }
}
