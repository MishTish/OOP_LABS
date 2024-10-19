using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Router : Computer
    {
        public int MaxConnections { get; set; }

        public Router(string ipAddress, int outputPower, string osType, int maxConnections) : base(ipAddress, outputPower, osType)
        {
            MaxConnections = maxConnections;
        }

        public override void Connect(Computer device)
        {
            if (connectedDevices.Count >= MaxConnections)
            {
                Console.WriteLine($"Router at {IPAddress} cannot connect more devices. Max connections reached.");
            }
            else
            {
                foreach (Computer connectedDevice in connectedDevices)
                {
                    connectedDevice.Connect(device);
                    device.Connect(connectedDevice);
                }

                base.Connect(device);
            }
        }
        public override void Disconnect(Computer device)
        {
            foreach (Computer connectedDevice in connectedDevices)
            {
                if (connectedDevice != device)
                {
                    connectedDevice.Disconnect(device);
                    device.Disconnect(connectedDevice);
                }
            }
            base.Disconnect(device);
        }
    }
}
