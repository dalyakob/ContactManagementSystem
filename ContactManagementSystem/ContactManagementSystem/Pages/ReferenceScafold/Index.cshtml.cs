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
    public class IndexModel : PageModel
    {
        private readonly ContactManagementSystem.Data.ApplicationDbContext _context;

        public IndexModel(ContactManagementSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ContactEntity> ContactEntity { get;set; }

        public async Task OnGetAsync()
        {
            ContactEntity = await _context.Contacts.ToListAsync();
        }
    }
}
