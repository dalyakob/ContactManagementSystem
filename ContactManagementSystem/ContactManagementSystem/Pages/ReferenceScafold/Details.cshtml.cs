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
    public class DetailsModel : PageModel
    {
        private readonly ContactManagementSystem.Data.ApplicationDbContext _context;

        public DetailsModel(ContactManagementSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
