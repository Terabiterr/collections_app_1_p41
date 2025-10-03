using collections_app_1.Services;

namespace collections_app_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            var students = studentService.GetAll();
            studentService.SortByName();
            //studentService.Reverse();
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
            Console.WriteLine("***********Binary Search***********");
            var found = studentService.BinarySearchByName("Bob");
            if(found != null)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
