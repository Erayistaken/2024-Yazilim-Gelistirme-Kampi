using Business.Concrete;
using Entities.Concretes;

Person person = new();

person.FirstName = "Eray";
person.LastName = "Şahin";
person.DateOfBirthYear = 2003;
person.NationalIdentity = 11223344556;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);