namespace Task_4
{
    public class JsonToCsvAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            JsonTemplate json = sourceTemplate as JsonTemplate;
            CsvTemplate csv = targetTemplate as CsvTemplate;

            if (json != null && csv != null)
            {
                csv.CsvData = json.JsonData.Trim('[', ']').Replace("\"", "");
            }
        }
    }
}
