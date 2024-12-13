namespace Task_4
{
    public class CsvTemplate : DataTemplate
    {
        public string CsvData { get; set; }
        public override DataTemplate Clone()
        {
            return new CsvTemplate { CsvData = this.CsvData };
        }
    }
}
