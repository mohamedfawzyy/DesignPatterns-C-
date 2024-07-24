using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class BackendCourse : ICourse
    {
        public string getCourseDuration()
        {
          return "5 months";
        }

        public int getCourseFees()
        {
            return 5000;
        }

        public string getCourseName()
        {
            return "Backend Course";
        }
    }
}
