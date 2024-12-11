namespace Task_2
{

    using System.Collections.Generic;

    public class Repository<T>
    {
        private List<T> items = new List<T>();


        public void Add(T item)
        {
            items.Add(item);
        }


        public delegate bool Criteria<Type> (Type item);


        public List<T> Find(Criteria<T> criteria)
        {
            List<T> results = new List<T>();
            foreach (T item in items)
            {
                if (criteria(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
