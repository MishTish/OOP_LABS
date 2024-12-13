namespace Task_3
{
    public class LaptopFactory : ITechProductFactory
    {
        public IScreen CreateScreen() => new LaptopScreen();
        public IProcessor CreateProcessor() => new LaptopProcessor();
        public ICamera CreateCamera() => new LaptopCamera();
    }
}
