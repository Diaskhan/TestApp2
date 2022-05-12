using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestApp2.Data
{
    public enum TaskStatus
    {
        ToDo,
        InProgress, 
        Done
    }

    public enum ProjectStatus
    {
        NotStarted, 
        Active, 
        Completed
    }

    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Decription { get; set; }
        public int Priority { get; set; }
        //public int Status { get; set; }
        public int ProjectId { get; set; }
        [JsonIgnore]
        public virtual Project? Project { get; set; }

        [Range(1, 3)]
        public TaskStatus TaskStatus { get; set; }

    }

    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        [Range(1, 3)]
        public ProjectStatus ProjectStatus { get; set; }

    }
}
