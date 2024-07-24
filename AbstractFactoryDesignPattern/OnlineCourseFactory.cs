using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class OnlineCourseFactory : ICourseSourceFactory
    {
        public ICourse CreateCourse()
        {
            return new BackendCourse();
        }

        public ISource CreateSource()
        {
            return new OnlineSource();
        }
    }
}
