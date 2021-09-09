using System.Collections.Generic;
using ContactRepo.Models;
using System.Linq;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        List<Contacts> Listcontacts = new List<Contacts>();  //listcontacts is an object to perform the manupulation
        void IContactsRepository.Add(Contacts contacts)
        {
            Listcontacts.Add(contacts);
        }

        Contacts IContactsRepository.Find(int id)
        {
            var contact = Listcontacts.Where(ctr=>ctr.EmployeeID==id).SingleOrDefault();
            return contact;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
            Listcontacts.Add(new Contacts{
                EmployeeID = 123,
                Employeename = "Sakshi",
                EmployeeMail = "Sakshi@123"
            });
            
            Listcontacts.Add(new Contacts{
                EmployeeID = 456,
                Employeename = "Gupta",
                EmployeeMail = "Gupta@456"
            });
            return Listcontacts;
        }

        void IContactsRepository.Remove(int id)
        {
            var contactToRemove = Listcontacts.Where(ctr=>ctr.EmployeeID==id).SingleOrDefault();
            if(contactToRemove!= null)
            {
                Listcontacts.Remove(contactToRemove);
            }
        }

        void IContactsRepository.Update(Contacts contacts)
        {
             var contactToUpdate = Listcontacts.Where(ctr=>ctr.EmployeeID==contacts.EmployeeID).SingleOrDefault();
             if (contactToUpdate != null)
             {
                 contactToUpdate.Employeename = contactToUpdate.Employeename;
                 contactToUpdate.EmployeeMail = contactToUpdate.EmployeeMail;
             }
        }
    }
}