using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerApp
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public string Task { get; set; }

        public DateTime? DueDate { get; set; }
        public string Priority { get; set; } = "Normal";
        [NotMapped]
        public TimeOnly? DueTime { get; set; }
    }
}
