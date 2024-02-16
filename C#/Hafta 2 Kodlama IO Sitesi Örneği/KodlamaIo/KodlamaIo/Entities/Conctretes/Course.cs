using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Conctretes
{
    public class Course
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int CourseId { get; set; }

        public int CategoryId { get; set; }
    }
}
