namespace TaskManager_Frontend.Data
{
    public class TaskResponse
    {
        public List<TaskModelList> Value { get; set; }
        public int StatusCode { get; set; }
    }
    public class TaskModelList
    {
        public int Task_Id { get; set; }
        public string Task_Title { get; set; }
        public DateTime Deadline { get; set; }
        public int StatusId { get; set; }  // ✅ Matches API response
        public TaskStatusModel TaskStatus { get; set; }
        public List<EmployeeTaskModel> EmployeeTasks { get; set; } = new();
        public List<TaskTagModel> TaskTags { get; set; } = new();
    }

    public class EmployeeTaskModel
    {
        public int Id { get; set; }
        public int EmpId { get; set; }  // ✅ Matches API response
        public EmployeeModel Employee { get; set; }
    }

    public class EmployeeModel
    {
        public int Emp_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Profile { get; set; }
    }

    public class TaskTagModel
    {
        public int Id { get; set; }
        public int TagId { get; set; }  // ✅ Matches API response
        public TagModel Tag { get; set; }
    }

    public class TagModel
    {
        public int Tag_Id { get; set; }
        public string Tag_Name { get; set; }
    }

    public class TaskStatusModel
    {
        public int Id { get; set; }  // ✅ Matches API response
        public string Status_Name { get; set; }  // ✅ Matches API response
    }
}
