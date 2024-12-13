namespace Task_3
{
    public interface ITechProductFactory
    {
        IScreen CreateScreen();
        IProcessor CreateProcessor();
        ICamera CreateCamera();
    }

}
