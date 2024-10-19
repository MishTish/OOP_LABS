namespace Task_2
{
    internal abstract class Computer : IConnectable
    {
        public string IPAddress { get; set; }
        public int OutputPower { get; set; }
        public string OSType { get; set; }

        internal List<IConnectable> connectedDevices;


        public Computer(string ipAddress, int outputPower, string osType)
        {
            IPAddress = ipAddress;
            OutputPower = outputPower;
            OSType = osType;
            connectedDevices = new List<IConnectable>();
        }


        public virtual void Connect(Computer device)
        {
            connectedDevices.Add(device);
            Console.WriteLine($"{GetType().Name} at {IPAddress} connected to {device.GetType().Name} at {device.IPAddress}.");
        }
        public virtual void Disconnect(Computer device)
        {
            connectedDevices.Remove(device);
            Console.WriteLine($"{GetType().Name} at {IPAddress} disconnected from {device.GetType().Name} at {device.IPAddress}.");
        }


        public virtual void ReceiveData(Computer sender, string data)
        {
            if (connectedDevices.Contains(sender)) 
            {
                Console.WriteLine($"{GetType().Name} at {IPAddress} received data from {sender.GetType().Name} at {sender.IPAddress}: {data}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is not connected to {sender.GetType().Name}, can't recieve data.");

            }
        }
        public virtual void SendData(Computer reciever, string data)
        {
            if (connectedDevices.Contains(reciever))
            {
                Console.WriteLine($"{GetType().Name} at {IPAddress} is sending data to {reciever.GetType().Name} at {reciever.IPAddress}: {data}");
                reciever.ReceiveData(this, data);
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is not connected to {reciever.GetType().Name}, can't send data.");

            }
        }
    }
}
