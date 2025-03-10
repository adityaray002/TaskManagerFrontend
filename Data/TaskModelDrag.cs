namespace TaskManager_Frontend.Data
{
    public class TaskModelDrag
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
    }
    public class StatusModelDrag
    {
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}
