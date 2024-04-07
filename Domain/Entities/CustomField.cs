namespace Domain.Entities
{
    public class CustomField<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
