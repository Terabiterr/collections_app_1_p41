namespace collections_app_1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}";
        }
    }
}
