using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class OfflineCourseFactory : ICourseSourceFactory
    {
        public ICourse CreateCourse()
        {
            return new FrontendCourse();
        }

        public ISource CreateSource()
        {
            return new OfflineSource();
        }
    }
}
