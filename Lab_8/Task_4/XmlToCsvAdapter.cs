namespace Task_4
{
    public class XmlToCsvAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            XmlTemplate xml = sourceTemplate as XmlTemplate;
            CsvTemplate csv = targetTemplate as CsvTemplate;

            if (xml != null && csv != null)
            {
                csv.CsvData = xml.XmlData.Replace("<item>", "").Replace("</item>", ",").TrimEnd(',');
            }
        }
    }
}
