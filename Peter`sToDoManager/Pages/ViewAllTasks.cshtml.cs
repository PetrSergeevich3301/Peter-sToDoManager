using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Peter_sToDoManager.Pages
{
    public class ViewTasksModel : PageModel
    {
        public List<TaskModel> Tasks { get; set; }
        public List<TaskModel> CompletedTasks { get; set; }
        public List<TaskModel> DeletedTasks { get; set; }
        private readonly AppDbContext _context;
        public ViewTasksModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Tasks = _context.Tasks.Where(x=>!x.Deleted).Where(x=>!x.Complete).ToList();
            CompletedTasks = _context.Tasks.Where(x => !x.Deleted).Where(x => x.Complete).ToList();
            DeletedTasks = _context.Tasks.Where(x => x.Deleted).ToList();
        }

        public ActionResult OnGetDelete(int id)
        {
            if(id != null)
            {
                var taskModel = _context.Tasks.FirstOrDefault(x => x.Id == id);
                taskModel.Deleted = true;
                _context.SaveChanges();

            }
            return RedirectToPage("ViewAllTasks");
        }
        public ActionResult OnGetComplete(int id)
        {
            var taskModel = _context.Tasks.FirstOrDefault(x => x.Id == id);
            taskModel.Complete = true;
            _context.SaveChanges();
            return RedirectToPage("ViewAllTasks");
        }
    }
}
