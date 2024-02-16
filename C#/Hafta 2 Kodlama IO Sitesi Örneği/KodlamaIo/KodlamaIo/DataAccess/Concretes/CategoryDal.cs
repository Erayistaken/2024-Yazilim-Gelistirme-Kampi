using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {


        public List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = Java , CategoryDescription="0 dan ileri seviyeye Java eğitimleri."},
                new Category() {CategoryId = 2, CategoryName = c# , CategoryDescription="0 dan ileri seviyeye c# eğitimleri."},
                new Category() {CategoryId = 3, CategoryName = python , CategoryDescription="0 dan ileri seviyeye python eğitimleri."},;

        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
             deletedCategory = categories.First(c => c.Id == category.Id);
         categories.Remove(deletedCategory);
        }



    public List<Category> GetAll()
    {
        return categories.ToList();
    }
    public Category GetById(int id)
    {
        return categories
    }

    public void Update(Category category)
    {
        var UpdateCategory = GetById(c.CategoryId);
        UpdateCategory.CategoryName = c.CategoryName;
        UpdateCategory.CategoryDescription = c.CategoryDescription;


    }

    public void PrintAll(List<Category> categories)
    {
        foreach (var c in categories)
        {
            PrintCategory(c);
        }
    }

    public void PrintCategory(Category c)
    {
        Console.WriteLine("Kategori ID'si: " + c.CategoryId);
        Console.WriteLine("Kategori İsmi: " + c.CategoryName);
        Console.WriteLine("Kategori Açıklaması: " + c.CategoryDescription);
        Console.WriteLine("");
    }
}






























