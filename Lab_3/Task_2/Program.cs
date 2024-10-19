using Task_2;

Network network = new Network();

Server server = new Server("192.168.0.1", 500, "Linux", storageCapacity: 15);
Workstation workstation = new Workstation("192.168.0.2", 200, "Windows", userName: "User1");
Router router = new Router("192.168.0.254", 300, "MacOS", maxConnections: 2);


network.AddDevice(server);
network.AddDevice(workstation);
network.AddDevice(router);

network.ConnectDevices(workstation, router);
network.ConnectDevices(server, router);

network.TransferData(workstation, server, "Important Data");
network.TransferData(workstation, server, "Blablablablablablablabla");

network.DisconnectDevices(workstation, router);

network.TransferData(workstation, server, "Unimportant Data");

Console.ReadKey();