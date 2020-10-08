using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactManagementSystem.Data;
using ContactManagementSystem.Models;

namespace ContactManagementSystem
{
    public class DeleteModel : PageModel
    {
        private readonly ContactManagementSystem.Data.ApplicationDbContext _context;

        public DeleteModel(ContactManagementSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactEntity ContactEntity { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactEntity = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (ContactEntity == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactEntity = await _context.Contacts.FindAsync(id);

            if (ContactEntity != null)
            {
                _context.Contacts.Remove(ContactEntity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
