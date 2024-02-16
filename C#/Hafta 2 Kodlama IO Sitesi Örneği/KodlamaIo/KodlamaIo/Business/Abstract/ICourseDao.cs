using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstract
{
    public class ICourseDao

    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
        void PrintCourse(Course course);
       void PrintAll(List<Course> courses);
    }
}
