namespace Task_4
{
    public class XmlTemplate : DataTemplate
    {
        public string XmlData { get; set; }
        public override DataTemplate Clone()
        {
            return new XmlTemplate { XmlData = this.XmlData };
        }
    }
}
