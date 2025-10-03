namespace collections_app_1.Models
{
    public class Student : IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Book>? Books { get; set; }

        public int CompareTo(object? obj)
        {
            if(!(obj is Student))
            {
                return 0;
            }
            Student? other = obj as Student;
            //if (Name[0] < other?.Name[0]) return -1;
            //if (Name[0] > other?.Name[0]) return 1;
            //return 0;
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
