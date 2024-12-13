namespace Task_3
{
    public class TabletFactory : ITechProductFactory
    {
        public IScreen CreateScreen() => new TabletScreen();
        public IProcessor CreateProcessor() => new TabletProcessor();
        public ICamera CreateCamera() => new TabletCamera();
    }
}
