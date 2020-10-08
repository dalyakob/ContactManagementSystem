using ContactManagementSystem.Data;
using ContactManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ContactManagementSystem.Services
{
    public class ContactService
    {
        private readonly ApplicationDbContext _context;

        public ContactService(ApplicationDbContext context)
        {
            _context = context;
        }

        //For CRUD Operation 

        //Get All Contacts
        public async Task<List<ContactEntity>> GetAll()
        {
            return await _context.Contacts.ToListAsync();
        }
        //Get Single Contact
        public async Task<ContactEntity> Get(Guid Id)
        {
            return await _context.Contacts.FirstOrDefaultAsync(x => x.Id == Id);
        }
        //Create A Contact
        public string Create(ContactEntity contact)
        {
            if (contact != null)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                return "Created Successfully";
            }

            return "Contact Could not be created please, try again!";
        }

        //Edit Contact
        public string Edit(ContactEntity contact)
        {
            if (contact != null)
            {
                _context.Contacts.Update(contact);
                _context.SaveChanges();
                return "Updated Successfully";
            }

            return "Contact Could not be updated please, try again!";
        }

        public string Delete(ContactEntity contact)
        {
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
                return "Deleted Successfully";
            }

            return "Contact could not be deleted, please try again!";
        }
    }
}
