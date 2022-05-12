using System.Text.Json.Serialization;

namespace TestApp2.Data
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Decription { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int ProjectId { get; set; }
        [JsonIgnore]
        public virtual Project? Project { get; set; }

        public  Task(){ 
        
        }


        //enum: ToDo / InProgress / Done
    }

    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public int Status { get; set; }

    }
}
