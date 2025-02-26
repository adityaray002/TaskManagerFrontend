namespace TaskManager_Frontend.Data
{
    public class TaskTag
    {
        // public int TagId { get; set; }

        public int Id { get; set; } // Matches "id" from backend
        public int Task_Id { get; set; } // Matches "taskId" from backend
        public int TagId { get; set; } // Matches "tagId" from backend
        public Tags? Tag { get; set; }
    }
}
