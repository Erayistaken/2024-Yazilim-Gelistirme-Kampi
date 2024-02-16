using KodlamaIo.Business.Abstract;
using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Concretes
{
    public class CategoryManager : ICategoryDao
    {
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id)
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetAll(); ;
        }

        public void PrintAll(List<Category> categories)
        {
            _categoryDal.PrintAll(categories);
        }

        public void PrintCourse(Category category)
        {
            categoryDal.PrintCategory(category)
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
