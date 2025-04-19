using System.ComponentModel.DataAnnotations;

namespace ToDoListAppApi.model
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string Task { get; set; }
        public bool ItCompilet { get; set; }
    }
}
