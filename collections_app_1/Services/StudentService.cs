using collections_app_1.DbContext;
using collections_app_1.Models;

namespace collections_app_1.Services
{
    public interface IStudentService
    {
        public void CreateStudent(Student student);
        public IEnumerable<Student> GetAll();
        public void UpdateStudent(int id, Student student);
        public void DeleteStudent(int id);
        public Student? GetStudentById(int id);
        public void SortByName();
        public int BinarySearchByStudent(Student student);
        public void Reverse();
    }
    public class StudentService : IStudentService
    {
        private List<Student> Students = AcademyContext.GetStudents() as List<Student>;

        public int BinarySearchByStudent(Student student)
        {
            return Students.BinarySearch(student);
        }

        public void CreateStudent(Student student)
        {
            if(student != null)
            {
                Students.Add(student);
            }
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if(student != null)
            {
                Students.Remove(student);
            }
        }

        public IEnumerable<Student> GetAll() => Students;

        public Student? GetStudentById(int id)
        {
            var student = Students.Find(s => s.Id == id);
            return student;
        }

        public void Reverse()
        {
            Students.Reverse();
        }

        public void SortByName()
        {
            Students.Sort();
        }

        public void UpdateStudent(int id, Student student)
        {
            var student_update = GetStudentById(id);
            if(student_update != null)
            {
                student_update.Id = student.Id;
                student_update.Name = student.Name;
                student_update.Books = student.Books;
            }
        }
    }
}
