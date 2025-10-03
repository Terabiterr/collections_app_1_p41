namespace collections_app_1.Models
{
    public class Student : IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Book>? Books { get; set; }

        public int CompareTo(object? obj)
        {
            Student? other = obj as Student;
            if (Id < other?.Id) return -1;
            if (Id > other?.Id) return 1;
            return 0;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
