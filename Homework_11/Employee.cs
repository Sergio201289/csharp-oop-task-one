using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    interface IEmployee
    {
        string Name { get; set; }
        void ChangeTelephoneNumber(int index, string value);
        string PrintClient(int index);
    }
}
