using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class FrontendCourse : ICourse
    {
        public string getCourseDuration()
        {
            return "5 months";
        }

        public int getCourseFees()
        {
            return 3000;
        }

        public string getCourseName()
        {
            return "FrontEnd Course";
        }
    }
}
