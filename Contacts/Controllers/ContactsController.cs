using ProductsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ContactsController : ApiController
    {
        public ContactsController()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact { Id = 1, Name = "Emma", Phone = "13888888888", Email = "Emma@email.com" });
            contacts.Add(new Contact { Id = 2, Name = "Anne", Phone = "15666666666", Email = "Anne@email.com" });
            contacts.Add(new Contact { Id = 3, Name = "John", Phone = "17999999999", Email = "John@email.com" });
            contacts.Add(new Contact { Id = 4, Name = "Hary", Phone = "18333333333", Email = "Hary@email.com" });
        }
        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }
        public IHttpActionResult GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault((p) => p.Id == id);
            return contact == null ? NotFound() : (IHttpActionResult)Ok(contact);
        }
        private List<Contact> contacts;
    }
}
