using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstract
{
    public interface InstructorDao
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        void PrintCourse(Instructor instructor);
        void PrintAll(List<Instructor> instructors);
    }
}
