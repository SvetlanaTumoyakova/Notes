using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Notes.Data;
using Notes.Model;

namespace Notes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Note> Notes { get; set; }
        public async Task OnGetAsync()
        {
            Notes = await _context.Notes.ToListAsync();
        }
    }
}
