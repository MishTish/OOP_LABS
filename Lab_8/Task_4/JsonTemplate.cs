namespace Task_4
{
    public class JsonTemplate : DataTemplate
    {
        public string JsonData { get; set; }
        public override DataTemplate Clone()
        {
            return new JsonTemplate { JsonData = this.JsonData };
        }
    }
}
