using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Conctretes;
using KodlamaIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes
{
    public interface InstructorManager : : InstructerService
{
   public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }

    public Instructor GetById(int id)
    {
        return _instructorDal.GetById(id);
    }
} 
   
}
