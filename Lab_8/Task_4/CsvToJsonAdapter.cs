namespace Task_4
{
    public class CsvToJsonAdapter : IDataAdapter
    {
        public void Convert(DataTemplate sourceTemplate, DataTemplate targetTemplate)
        {
            CsvTemplate csv = sourceTemplate as CsvTemplate;
            JsonTemplate json = targetTemplate as JsonTemplate;

            if (csv != null && json != null)
            {
                json.JsonData = "[" + string.Join(",", csv.CsvData.Split(',')) + "]";
            }
        }
    }

}
