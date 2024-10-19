namespace Task_2
{
    internal class Network
    {
        private List<Computer> devices;


        public Network()
        {
            devices = new List<Computer>();
        }


        public void AddDevice(Computer device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.GetType().Name} added to the network.");
        }
        public void RemoveDevice(Computer device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.GetType().Name} removed from the network.");
        }


        public void TransferData(Computer sender, Computer reciever, string data)
        {
            sender.SendData(reciever, data);
        }


        public void ConnectDevices(Computer device1, Computer device2)
        {
            device1.Connect(device2);
            device2.Connect(device1);
        }
        public void DisconnectDevices(Computer device1, Computer device2)
        {
            device1.Disconnect(device2);
            device2.Disconnect(device1);
        }
    }
}
