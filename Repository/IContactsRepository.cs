using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts contacts);
        List<Contacts> GetAll(); //not recommended
        Contacts Find(int id); // searching record by id returning as a Contact
        void Update(Contacts contacts); // we can update a record by id or by mail
        void Remove(int id); // we are removing the record by id and returning as a void depends on the requirment
    }
}