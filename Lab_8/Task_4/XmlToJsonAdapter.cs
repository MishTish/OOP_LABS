namespace Task_4
{
    public class XmlToJsonAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            XmlTemplate xml = sourceTemplate as XmlTemplate;
            JsonTemplate json = targetTemplate as JsonTemplate;

            if (xml != null && json != null)
            {
                json.JsonData = "{ \"data\": \"" + xml.XmlData.Replace("<", "").Replace(">", "") + "\" }";
            }
        }
    }
}
