using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_for_ex
{
    public class ServiceObj
    {
        public static void Add<T>(T entity) where T: class
        {
        }
    }
}
