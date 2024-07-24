using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal interface ICourseSourceFactory
    {
        ICourse CreateCourse();
        ISource CreateSource();
    }
}
