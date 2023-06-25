using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Peter_sToDoManager.Data;

namespace Peter_sToDoManager.Pages
{
    public class ViewTaskModel : PageModel
    {

        public TaskModel task { get; set; }

        [BindProperty]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string step { get; set; }
        private readonly AppDbContext _context;
        public ViewTaskModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public void OnGetTask(int id)
        {
            task = _context.Tasks.FirstOrDefault(x => x.Id == id);
            if(task == null)
            {
                RedirectToPage("ViewAllTasks");
            }

        }
        public void OnGetRecover(int id)
        {

        }

    }
}
