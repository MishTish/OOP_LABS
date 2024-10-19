using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Server : Computer
    {
        public int StorageCapacity { get; set; }

        public Server(string ipAddress, int outputPower, string osType, int storageCapacity) : base(ipAddress, outputPower, osType)
        {
            StorageCapacity = storageCapacity;
        }

        public override void ReceiveData(Computer sender, string data)
        {
            if (data.Length > StorageCapacity)
            {
                Console.WriteLine("Recieved data exceeds storage capacity. Server cannot recieve data");
            }
            else
            {
                base.ReceiveData(sender, data);
            }
        }
    }
}
