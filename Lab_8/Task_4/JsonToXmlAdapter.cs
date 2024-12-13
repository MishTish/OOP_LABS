namespace Task_4
{
    public class JsonToXmlAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            JsonTemplate json = sourceTemplate as JsonTemplate;
            XmlTemplate xml = targetTemplate as XmlTemplate;

            if (json != null && xml != null)
            {
                xml.XmlData = "<root><item>" + json.JsonData.Trim('[', ']').Replace(",", "</item><item>").Replace("\"", "") + "</item></root>";
            }
        }
    }
}
