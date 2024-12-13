namespace Task_3
{
    public class SmartphoneFactory : ITechProductFactory
    {
        public IScreen CreateScreen() => new SmartphoneScreen();
        public IProcessor CreateProcessor() => new SmartphoneProcessor();
        public ICamera CreateCamera() => new SmartphoneCamera();
    }
}
