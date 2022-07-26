using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_3_1
{
    public interface IUserRepository
    {
        IEnumerable < User > FindAll();
    }
}
