using System.ComponentModel.DataAnnotations;

namespace Peter_sToDoManager.Data
{
    public class Step
    {
        [Key]
        public int TaskId { get; set; }
        public string StepDiscription { get; set; }
        public bool IsComplete { get; set; }
        public Step()
        {
            
        }
        public Step(string discription) { 
            StepDiscription = discription;
            IsComplete = false;
        }
    }
}
