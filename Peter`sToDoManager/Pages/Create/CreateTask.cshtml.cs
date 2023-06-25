using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Peter_sToDoManager.Pages.Create
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty]
        public UserBindingModel Model { get; set; }
        public TaskModel newTask { get; set; }

        private readonly AppDbContext _context;
        public CreateTaskModel(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult OnPost()
        {
            newTask = new TaskModel ( Model.TaskName, Model.TaskDescription, Model.DeadLine, Model.IsMetter );

            _context.Add(newTask);
            _context.SaveChanges();
            return RedirectToPage("TaskCreatedSucces");
        }


        public class UserBindingModel
        {
            //public string UserName { get; set;} //??
            [Required(ErrorMessage ="���� ����������� � ����������!")]
            [StringLength(60)]
            [DataType(DataType.Text)]
            [Display(Name = "�������� ������:")]
            public string TaskName { get; set; }

            
            [Display(Name = "�������� ������:")]
            public string TaskDescription { get; set; }


            
            [DataType(DataType.DateTime, ErrorMessage ="������������ ����!")]
            [Display(Name = "���� ���������� ������:")]
            public DateTime DeadLine { get; set; }


            [Display(Name = "������ ������")]
            public bool IsMetter { get; set; }

        }
    }
}
