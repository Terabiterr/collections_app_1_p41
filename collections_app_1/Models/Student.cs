namespace collections_app_1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Book>? Books { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
