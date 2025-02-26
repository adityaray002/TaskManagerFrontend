namespace TaskManager_Frontend.Data
{
    public class EmployeeTasks
    {
        // public int emp_Id { get; set; }
        public int Id { get; set; } 
        public int Task_Id { get; set; }
        public int EmpId { get; set; } 
        public Employees? Employee { get; set; }
    }
}
