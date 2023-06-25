

using Peter_sToDoManager.Data;
using System.ComponentModel.DataAnnotations;

namespace Peter_sToDoManager
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Time { get; set; }
        public List<Step>? steps { get; set; }
        public bool Matter { get; set; }
        public bool Complete { get; set; }
        public bool Deleted { get; set; }

        public TaskModel(string Name, string Description, DateTime Time, bool Matter)
        {
            this.Name = Name;
            this.Description = Description;
            this.Time = Time;
            this.Matter = Matter;
            Complete = false;
            Deleted = false;
        }
    }
}
