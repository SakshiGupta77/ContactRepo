using ContactRepo.Repository;
using Microsoft.AspNetCore.Mvc;
using ContactRepo.Models;
namespace ContactRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController:ControllerBase
    {
        IContactsRepository contactsRepository;
        public ContactsController(IContactsRepository _contactsRepository)
        {
            contactsRepository = _contactsRepository;
        }
        [HttpPost]
        public IActionResult CreateContact(Contacts contacts)
        {
            contactsRepository.Add(contacts);
            return Ok("Record is added");
        }
        [HttpPut]
        public IActionResult UpdateContact (Contacts contacts)
        {
            contactsRepository.Update(contacts);
            return Ok("record has been update");
        }
        [HttpDelete("{Id}")]
        public IActionResult RemoveContact (int Id)
        {
            contactsRepository.Remove(Id);
            return Ok("record has been deleted");
        }
        [HttpGet("{Id:int}")]
        public IActionResult SearchContact (int Id)
        {
            var temp = contactsRepository.Find(Id);
            return Ok(temp);
        }
        [HttpGet("{contactList}")]
        public IActionResult GetAllContact (int Id)
        {
            var temp = contactsRepository.GetAll();
            return Ok(temp);
        }
    }
}