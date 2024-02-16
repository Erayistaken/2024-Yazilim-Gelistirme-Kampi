using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Conctretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>();
            new Course() { CourseId = 1, CourseName = "JAVA,", CourseDescription = "JAVA İleri Seviye Programlama Eğitimi", InstructorId = 1, CategoryId = 1, }
            new Course() { CourseId = 2, CourseName = "C#,", CourseDescription = "C# İleri Seviye Programlama Eğitimi", InstructorId = 2, CategoryId = 2, }

            }

        public void Add(Course course)
        {
            courses.Add(course);

        }

        public void Delete(Course course)
        {
            var DeleteCourse = GetById(id);
            courses.Remove(DeleteCourse);
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public Course GetById(int id)
        {
            return courses.First(c => c.Id == id);
        }
        public void Update(Course course)
        {
            var updatedCourse = courses.First(c => c.Id == course.Id);
            updatedCourse.Name = course.Name;
            updatedCourse.Description = course.Description;
            updatedCourse.Price = course.Price;
            updatedCourse.InstructorId = course.InstructorId;
            updatedCourse.CategoryId = course.CategoryId;
        }
    }
}
