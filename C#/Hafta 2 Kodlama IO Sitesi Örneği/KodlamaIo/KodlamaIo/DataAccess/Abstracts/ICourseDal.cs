using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstracts
{
   public interface ICourseDal
    {

        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
