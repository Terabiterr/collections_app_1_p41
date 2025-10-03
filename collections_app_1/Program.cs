using collections_app_1.Services;

namespace collections_app_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            var students = studentService.GetAll();
            foreach (var student in students)
            {
                Console.WriteLine("**********************");
                Console.WriteLine(student);
                Console.WriteLine("Books:");
                foreach (var book in student.Books)
                {
                    Console.WriteLine(book);
                }
                Console.WriteLine("**********************");
            }
        }
    }
}
