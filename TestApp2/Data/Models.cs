namespace TestApp2.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Decription { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public Project? Project { get; set; }

        //enum: ToDo / InProgress / Done
    }

    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public int Status { get; set; }
        
        //the current status of the project (enum: NotStarted, Active, Completed)

    }
}
