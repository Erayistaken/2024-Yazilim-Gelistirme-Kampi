using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
  public class InstructorDal : IInstructorDal
    {
        public List<Instructor> instructors;

        public InstructDal()
        {
            instructors = new List<Instructor>
        {
            new Instructor{Id=1, FirstName="Engin", LastName="Demiroğ", NationalIdentity,="123456789", },
            new Instructor{Id=2,FirstName="Halit ",LastName="Kalaycı",NationalIdentity="12346788", }
        }
            public void Add(Instructor instructor)
            {
                instructors.Add(instructor);
            }

            public void Delete(Instructor instructor)
            {
                var deletedInstructor = instructors.First(i => i.Id == instructor.Id);
                instructors.Remove(deletedInstructor);
            }

            public List<Instructor> GetAll()
            {
                return instructors;
            }
            public Instructor GetById(int id)
            {
                return instructors.First(i => i.Id == id);
            }

            public void Update(Instructor instructor)
            {
                var updatedInstructor = instructors.First(i => i.Id == instructor.Id);
                updatedInstructor.FirstName = instructor.FirstName;
                updatedInstructor.LastName = instructor.LastName;
                updatedInstructor.NationalIdentity= instructor.NationalIdentity;
               
            }



        }
