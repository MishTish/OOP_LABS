using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Workstation : Computer
    {
        public string UserName { get; set; }

        public Workstation(string ipAddress, int outputPower, string osType, string userName) : base(ipAddress, outputPower, osType)
        {
            UserName = userName;
        }


    }
}
