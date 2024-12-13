namespace Task_4
{
    public class CsvToXmlAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            CsvTemplate csv = sourceTemplate as CsvTemplate;
            XmlTemplate xml = targetTemplate as XmlTemplate;

            if (csv != null && xml != null)
            {
                xml.XmlData = "<root><item>" + csv.CsvData.Replace(",", "</item><item>") + "</item></root>";
            }
        }
    }

}
