using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal interface IConnectable
    {
        void Connect(Computer device);
        void Disconnect(Computer device);
    }

}