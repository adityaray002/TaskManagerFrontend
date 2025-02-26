namespace TaskManager_Frontend.Data
{
    public class TaskStatuses
    {
        public int Id { get; set; } // Matches "id" from backend
        public int Task_Id { get; set; } // Matches "taskId" from backend
        public int StatusId { get; set; } // Matches "statusId" from backend
       
        public TaskStatusss? Status { get; set; }
    }
}
