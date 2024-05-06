namespace BlazorServerApp
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public string Task { get; set; }

        public DateTime? DueDate { get; set; }
        public string Priority { get; set; } = "Normal";
        public TimeOnly? DueTime { get; set; }
    }
}
