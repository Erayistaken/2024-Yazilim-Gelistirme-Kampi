using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstract
{
    internal interface ICategoryDao
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        void PrintCourse(Category category);
        void PrintAll(List<Category> categories);
    }

}
