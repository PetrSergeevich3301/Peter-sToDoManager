using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Peter_sToDoManager.Pages.CRUD
{
    public class CompleteTaskModel : PageModel
    {
        private readonly AppDbContext _context;
        public CompleteTaskModel(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult OnGet(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) {
                return RedirectToPage("/ViewAllTasks");
            }
            task.Complete= true;
            _context.SaveChanges();
            return RedirectToPage("/ViewAllTasks");
        }
    }
}
