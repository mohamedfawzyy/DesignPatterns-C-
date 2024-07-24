using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    internal class OfflineSource : ISource
    {
        public string GetSourceType()
        {
            return "Offline Source";
        }
    }
}
