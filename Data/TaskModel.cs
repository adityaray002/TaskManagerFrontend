namespace TaskManager_Frontend.Data
{
    public class TaskModel
    {
        public int Task_Id { get; set; }
        public string Task_Title { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Deadline { get; set; }
        public List<EmployeeTasks> EmployeeTasks { get; set; } = new();
        public List<TaskTag> TaskTags { get; set; } = new();
       

        public int StatusId { get; set; }
        public TaskStatusss Status { get; set; }
    }
  
}
